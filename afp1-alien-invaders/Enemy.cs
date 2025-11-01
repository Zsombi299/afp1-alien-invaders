using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace afp1_alien_invaders {
    internal class Enemy : Entity {
        static Player player = null;

        private byte hp;
        private byte score;

        public void Hurt(int dmg) {
            hp -= dmg;
            if (hp <= 0) {
                player.AddScore(score);
                GameSpace.Field[xCoord, yCoord] = null;
            }
        }

        public Enemy /*number one*/(int hp, string name, Image txtr, Player plyr)
        : base(name, txtr){
            this.hp = hp;
            score = hp;
            if (player == null)
                player = plyr;
        }

        public void Mv() { Move(yCoord); }
        protected override void Move(int yCoord) {
            base.Move(yCoord);
            GameSpace.Field[XCoord, YCoord] = this;
            if (player.XCoord == this.xCoord && player.YCoord == this.yCoord)
                EndGame(player.Score, this.name);
        }

        private void EndGame(int score,string name) {
            MessageBox.Show($"Skill Issue!\nFinal Score: {score}\nKilled by: {name}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace afp1_alien_invaders
{
    internal class Enemy : Entity
    {
        static Player player = null;

        private int hp;

        public Enemy /*number one*/(int hp, string name, Image txtr, Player plyr)
        : base(name, txtr){
            if (player == null)
                this.hp = hp;
                player = plyr;
        }

        public void Mv() { Move(yCoord); }
        protected override void Move(int yCoord)
        {
            base.Move(yCoord);
            if (player.XCoord == this.xCoord && player.YCoord == this.yCoord)
                EndGame(player.Score, this.name);
        }

        private void EndGame(int score,string name) {
            MessageBox.Show($"Skill Issue!\nFinal Score: {score}\nKilled by: {name}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

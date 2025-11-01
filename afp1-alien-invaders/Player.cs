using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace afp1_alien_invaders {
    internal class Player : Entity {
        private int score  = 0;
        private byte dmg;
        private GameInputHandler input;

        public int YCoord{get;}
        public int Score { get;}
        public int XCoord {get;}
        public GameInputHandler InputHandler {get;}

        public Player(byte dmg, Image texture)
        : base("Player", texture) {
            this.dmg = dmg;
            this.yCoord = GameSpace.Field.GetLength(1); // lent
            this.xCoord = (GameSpace.Field.GetLength(0) / 2) + 1; // középen
            if (Application.OpenForms != null && Application.OpenForms.Count > 0) {
                input = new GameInputHandler(Application.OpenForms[0]);
            } else if (Application.OpenForms.Count == 0) {
                throw new InvalidOperationException("Nincs form!!!");
            }
        }

        public void Move() { // Fel plusz, Le minusz, Jobb plusz, Bal minusz
            var values = input.Update();
            if (values.isShooting) {
                Shoot();
            }
            base.Move(xCoord, yCoord, values.xSpeed, values.ySpeed);
            Thread.Sleep(10);
            Move();
        }

        public void AddScore(int score) {
            if (score <= 0)
                throw new ArgumentException("Nulla vagy kissebb score!");
            this.score += score;
        }

        private void Shoot() {
            int i = GameSpace.Field.GetLength(1);
            while ((GameSpace.Field[xCoord, i] is Enemy) && i > 0) {
                if ((GameSpace.Field[xCoord, i - 1] is Enemy)) {
                    Enemy temp = (GameSpace.Field[xCoord, i] as Enemy);
                    temp.Hurt(dmg);
                }
            }
        }
    }
}

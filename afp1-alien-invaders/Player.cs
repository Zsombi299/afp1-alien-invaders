using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace afp1_alien_invaders
{
    internal class Player : Entity
    {
        private int score  = 0;
        private int dmg;

        public int YCoord{get;}
        public int Score { get;}
        public int XCoord {get;}

        public Player(int dmg, Image texture)
        : base("Player", texture) {
            this.dmg = dmg;
            this.yCoord = 7; // lent
            this.xCoord = 5; // középen (ha 9 széles a pálya)(ha nem akkor meg átírom hogy középen legyen)
        }

        public void Move(int xCoord, int yCoord, int xSpeed, int ySpeed) // Fel plusz, Le minusz, Jobb plusz, Bal minusz
        {
            base.Move(xCoord, yCoord, xSpeed, ySpeed);
        }
    }
}

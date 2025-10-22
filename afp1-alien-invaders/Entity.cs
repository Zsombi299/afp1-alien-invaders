using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace afp1_alien_invaders
{
    internal class Entity
    {
        protected int xCoord;
        protected int yCoord;
        protected string name;
        protected Image txtr;

        protected Entity(string name, Image tytr) {
            this.name = name;
            this.txtr = tytr;
        }

        protected virtual void Move(int yCoord)
        {
            this.yCoord++;
        }

        protected virtual void Move(int xCoord, int yCoord, int xSpeed, int ySpeed) {
            this.xCoord = xCoord + xSpeed;
            this.yCoord = yCoord + ySpeed;
        }
    }
}

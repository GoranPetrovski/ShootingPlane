using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProektnaVP
{
    class Explode:MovingObject
    {
        public static readonly int speed = 4;

        public Explode(int x, int y, Bitmap explodeImage): base(x, y, explodeImage = new Bitmap(Properties.Resources.exp1))
        {

        }

    }
}

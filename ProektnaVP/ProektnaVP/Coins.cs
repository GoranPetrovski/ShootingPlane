using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProektnaVP
{
    class Coins:MovingObject
    {
        public int speed { get; set; }

        public Coins(int x, int y, Bitmap bitmap) : base(x, y, bitmap = new Bitmap(Properties.Resources.coins))
        {
            speed = 2;
            
        }


        public void Move()
        {
            X = X - speed;

        }

    }
}

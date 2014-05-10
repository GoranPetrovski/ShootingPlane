using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProektnaVP
{
    class Rock:MovingObject
    {
        /*public int X { get; set; }
        public int Y { get; set; }
        public int speed { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Bitmap rockImage;
        */
        public int speed = 3;

        public Rock(int x, int y, Bitmap picture):base(x,y,picture=new Bitmap(Properties.Resources.Image1))
        {
            
        }


        public void Move()
        {
            X = X - speed;

        }

    }
}

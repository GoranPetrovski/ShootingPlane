using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProektnaVP
{
    public class Bullet:MovingObject
    {
        public int speed { get; set; }
        
        public Bullet(int x, int y, Bitmap bitmap):base(x,y,bitmap=new Bitmap(Properties.Resources.bullet))
        {
            speed = 2;
        }


        public void moveRock()
        {
            X = X + speed;

        }
    }
}

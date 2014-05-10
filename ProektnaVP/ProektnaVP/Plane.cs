using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProektnaVP
{
    public class Plane:MovingObject
    {
        public int speed = 5;
        public Bullet bullet{get;set;}
        

        Bitmap p;

        public Plane(int x, int y, Bitmap planeImage) : base(x, y, planeImage = new Bitmap(Properties.Resources.plane))
        {
                bullet = new Bullet(x, y, p);
                
        }

        public void Move()
        {
            Y = Y + speed;
        }
      
        public void Fire(Graphics g, Bullet b){
            b.X += 3;
            b.moveRock();
            b.Draw(g);
     
        }

       
    }
}

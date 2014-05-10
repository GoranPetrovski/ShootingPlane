using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProektnaVP
{
    class Cloud:MovingObject
    {
        public int speed { get; set; }
        
        public Cloud(int x, int y, Bitmap bitmap):base(x,y,bitmap = new Bitmap(Properties.Resources.cloud_md1))
        {
            speed = 18;
        }

        public void move()
        {
            X = X - speed;

        }   
    }
}

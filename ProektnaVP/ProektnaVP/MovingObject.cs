using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProektnaVP
{
    public class MovingObject
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Bitmap Image;

        public MovingObject(int x, int y, Bitmap pic)
        {
            this.X = x;
            this.Y = y;
            Image = pic;
            this.Width = Image.Width;
            this.Height = Image.Height;

        }

        //public abstract void Move();
        

        public void Draw(Graphics g)
        {
            g.DrawImage(Image, X, Y);
        }

        public bool Collisision(int x, int y, int width, int height)
        {
            Rectangle rec = new Rectangle(X, Y, Width, Height);

            Rectangle rec1 = new Rectangle(x, y, width, height);

            Rectangle intersect = Rectangle.Intersect(rec, rec1);

            if (intersect != Rectangle.Empty)
            {
                return true;
            }

            return false;
            
        }
    }
}

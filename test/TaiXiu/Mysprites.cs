using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiXiu
{
    internal class Mysprites
    {

        private Bitmap[] bMP;
        private int nBMP;
        private int iBMP;
        private float left;
        private float top;
        private int width;
        private int height;
        private float a, b;
        private float speed = 10;
        private float giatoc = 1;
        public Bitmap[] BMP
        {
            get => bMP;
            set
            {
                bMP = value;
                nBMP = bMP.Length;
                iBMP = 0;
                width = bMP[0].Width;
                height = bMP[0].Height;
            }
        }

        public int NBMP { get => nBMP; set => nBMP = value; }
        public int IBMP { get => iBMP; set => iBMP = value; }
        public float Left { get => left; set => left = value; }
        public float Top { get => top; set => top = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public Mysprites() { }

        public Mysprites(Bitmap[] bMP, int left, int top)
        {
            BMP = bMP;
            Left = left;
            Top = top;
        }
        public void tinhab(Point x2)
        {
            if (Left != x2.X)
            {
                a = (float)(Top - x2.Y) / (Left - x2.X);
                b = Top - a * Left;
            }
            else
            {
                a = 0;
                b = Left;
            }

        }
        public void dichuyen(int left, int top)
        {
            if (Left - left == 0)
            {
                if (Top > top)
                {
                    if (Top > top + 1)
                    {
                        Top -= speed;
                    }
                    else
                        Top--;
                }
                else if (Top < top)
                {
                    if (Top < top - 1)
                    {
                        Top += speed;
                    }
                    else
                        Top++;
                }
                else
                {

                }
            }
            else if (Left < left)
            {
                Left += speed;
                Top = a * Left + b;
            }
            else
            {
                Left -= speed;
                Top = a * Left + b;
            }
        }
        public void Update()
        {
            iBMP = (iBMP + 1) % nBMP;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(bMP[iBMP], left, top);
        }
    }
}

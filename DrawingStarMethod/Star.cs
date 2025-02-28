using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingStarMethod
{
    internal class Star
    {
        Random randgen = new Random();
        public PointF[] starPoints = new PointF[10];
        public Pen starPen;
        public int x, y;
        public float size;
        public float scale;

        public Star(Pen _starPen, int _x, int _y, float _size)
        {
            starPen = _starPen;
            x = _x;
            y = _y;
            size = _size;

            SetPoints();
        }

        private void SetPoints()
        {
            scale = size / 206;

            starPoints = new PointF[10];
            starPoints[0] = new PointF(0 * scale + x, 74 * scale + y);
            starPoints[1] = new PointF(79 * scale + x, 74 * scale + y);
            starPoints[2] = new PointF(103 * scale + x, 0 * scale + y);
            starPoints[3] = new PointF(127 * scale + x, 74 * scale + y);
            starPoints[4] = new PointF(206 * scale + x, 74 * scale + y);
            starPoints[5] = new PointF(142 * scale + x, 122 * scale + y);
            starPoints[6] = new PointF(166 * scale + x, 196 * scale + y);
            starPoints[7] = new PointF(103 * scale + x, 150 * scale + y);
            starPoints[8] = new PointF(39 * scale + x, 196 * scale + y);
            starPoints[9] = new PointF(64 * scale + x, 122 * scale + y);
        }

        public void Move()
        {
            x += 4;

            SetPoints();
        }

        public void Resize()
        {
            if (size < 60)
            {
                size++;
            }
            else
            {
                size--;
            }


            SetPoints();
        }
    }
}

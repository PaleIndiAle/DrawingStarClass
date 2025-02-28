using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        //Star newStar;
        //Pen blackPen = new Pen(Color.Black);

        List<Star> stars = new List<Star>();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 50; i++) 
            {
                CreateStar();
            }
        }

        public void CreateStar()
        {
            int x = random.Next(0, this.Width);
            int y = random.Next(0, this.Height);
            int size = random.Next(10, 50);

            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);

            Pen starPeen = new Pen(Color.FromArgb(r, g, b));

            Star newStar = new Star(starPeen, x, y, size);
            stars.Add(newStar);
        }

        private void starTimer_Tick(object sender, EventArgs e)
        {
            foreach (Star star in stars)
            {
                int switchy = random.Next(1, 4);

                star.Move();



                if (star.x > this.Width - star.size)
                {
                    star.x = 0 - (int)star.size;
                }
            }

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Star star in stars)
            {
                e.Graphics.DrawPolygon(star.starPen, star.starPoints);
            }

            //e.Graphics.DrawPolygon(newStar.starPen, newStar.starPoints);
            //e.Graphics.DrawPolygon(Star.starPen, Star.starPoints);
        }
    }
}

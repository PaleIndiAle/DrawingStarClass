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
        Star newStar;
        Pen blackPen = new Pen(Color.Black);

        public Form1()
        {
            newStar = new Star(blackPen, 100, 50, 100);

            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPolygon(newStar.starPen, newStar.starPoints);
        }
    }
}

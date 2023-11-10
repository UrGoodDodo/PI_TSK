using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi_tsk
{
    public partial class Form1 : Form
    {
        List<PointF> triangle_points = new List<PointF>();
        Color c;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var p1 = new Point(rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height));
            triangle_points.Add(p1);
            var p2 = new Point(rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height));
            triangle_points.Add(p2);
            var p3 = new Point(rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height));
            triangle_points.Add(p3);
            c = Color.FromArgb(rnd.Next(0,255),rnd.Next(0, 255), rnd.Next(0,255));
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (triangle_points.Count == 3) 
            {
                var t = triangle_points.ToArray();
                e.Graphics.DrawPolygon(new Pen(c), t);
                triangle_points.Clear();
            }
        }
    }
}

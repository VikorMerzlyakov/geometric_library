using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using graphLibrary;


namespace graphLibrary
{
    public partial class Form1 : Form
    {
        Graphics g;
        Line line;
        Triangle triangle;
        Rectangle rect;
        Circle circle;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Line_btn_Click(object sender, EventArgs e)
        {
            Point A = new Point(20, 20);
            Point B = new Point(40, 40);
            line = new Line(A, B);
            Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
            line.Draw(g, myPen);
        }

        private void Triangle_btn_Click(object sender, EventArgs e)
        {
            Point A = new Point(210, 20);
            Point B = new Point(260, 100);
            Point C = new Point(220, 80);
            triangle = new Triangle(A, B, C);
            Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
            triangle.Draw(g, myPen);
        }

        private void Rectangle_btn_Click(object sender, EventArgs e)
        {
            Point lu = new Point(110, 120);
            Point ru = new Point(160, 100);
            Point ld = new Point(120, 180);
            Point rd = new Point(180, 160);
            rect = new Rectangle(lu, ru, ld, rd);
            Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
            rect.Draw(g, myPen);

        }

        private void Circle_btn_Click(object sender, EventArgs e)
        {
            Point center = new Point(170, 170);
            int dia = 35;
            circle = new Circle(center, dia);
            Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
            circle.Draw(g, myPen);
        }

        private void Line_mov_btn_Click(object sender, EventArgs e)
        {
            if (dX_textBox.Text != "" && dY_textBox.Text != "")
            {
                int dx = Convert.ToInt32(dX_textBox.Text);
                int dy = Convert.ToInt32(dY_textBox.Text);
                line.Move(dx, dy);
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
                line.Draw(g, myPen);
            }
        }

        private void Triangle_mov_btn_Click(object sender, EventArgs e)
        {
            if (dX_textBox.Text != "" && dY_textBox.Text != "")
            {
                int dx = Convert.ToInt32(dX_textBox.Text);
                int dy = Convert.ToInt32(dY_textBox.Text);
                triangle.Move(dx, dy);
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
                triangle.Draw(g, myPen);
            }
        }

        private void Rect_mov_btn_Click(object sender, EventArgs e)
        {
            if (dX_textBox.Text != "" && dY_textBox.Text != "")
            {
                int dx = Convert.ToInt32(dX_textBox.Text);
                int dy = Convert.ToInt32(dY_textBox.Text);
                rect.Move(dx, dy);
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
                rect.Draw(g, myPen);
            }
        }

        private void Circle_mov_btn_Click(object sender, EventArgs e)
        {
            if (dX_textBox.Text != "" && dY_textBox.Text != "")
            {
                int dx = Convert.ToInt32(dX_textBox.Text);
                int dy = Convert.ToInt32(dY_textBox.Text);
                circle.Move(dx, dy);
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
                circle.Draw(g, myPen);
            }
        }

        private void Line_rot_btn_Click(object sender, EventArgs e)
        {
            if (deg_textBox.Text != "")
            {
                int deg = Convert.ToInt32(deg_textBox.Text);
                Point Center = new Point(60, 60);
                line.Rotate(Center, deg);
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
                line.Draw(g, myPen);
            }
        }

        private void Triangle_rot_btn_Click(object sender, EventArgs e)
        {
            if (deg_textBox.Text != "")
            {
                int deg = Convert.ToInt32(deg_textBox.Text);
                Point Center = new Point(260, 120);
                triangle.Rotate(Center, deg);
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
                triangle.Draw(g, myPen);
            }
        }

        private void Rect_rot_btn_Click(object sender, EventArgs e)
        {
            if (deg_textBox.Text != "")
            {
                int deg = Convert.ToInt32(deg_textBox.Text);
                Point Center = new Point(100, 100);
                rect.Rotate(Center, deg);
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
                rect.Draw(g, myPen);
            }
        }

        private void Circle_rot_btn_Click(object sender, EventArgs e)
        {
            if (deg_textBox.Text != "")
            {
                int deg = Convert.ToInt32(deg_textBox.Text);
                Point Center = new Point(100, 100);
                circle.Rotate(Center, deg);
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255));
                circle.Draw(g, myPen);
            }
        }

    }
}

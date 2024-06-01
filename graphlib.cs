using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using graphLibrary;
using System.Security.Cryptography;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;

namespace graphLibrary
{
    public interface ITransform
    {
        void Rotate(Point center, int deg);
        void Move(int dx, int dy);
    }

    internal static class CalcPoint
    {
        public static Point getNewPoint(Point x, Point center, int deg)
        {
            double ugol = deg * Math.PI / 180;

            int newX = (int)(center.X + (x.X - center.X) * Math.Cos(ugol) - (x.Y - center.Y) * Math.Sin(ugol));
            int newY = (int)(center.Y + (x.X - center.X) * Math.Sin(ugol) + (x.Y - center.Y) * Math.Cos(ugol));

            return new Point(newX, newY);
        }
    }


    public class Line : ITransform
    {
        private Point lBeg;
        private Point lEnd;

        public Point LBeg
        {
            get { return lBeg; }
            set { lBeg = value; }
        }
        public Point LEnd
        {
            get { return lEnd; }
            set { lEnd = value; }
        }

        public Line()
        {
            this.lBeg = new Point(0, 0);
            this.lEnd = new Point(0, 0);
        }

        public Line(Point lBeg, Point lEnd)
        {
            this.lBeg = lBeg;
            this.lEnd = lEnd;
        }

        public void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, lBeg, lEnd);
        }

        public void Rotate(Point center, int deg)
        {
            Point newBeg = CalcPoint.getNewPoint(lBeg, center, deg);
            Point newEnd = CalcPoint.getNewPoint(lEnd, center, deg);

            this.lBeg.X = newBeg.X;
            this.lBeg.Y = newBeg.Y;
            this.lEnd.X = newEnd.X;
            this.lEnd.Y = newEnd.Y;
        }

        public void Move(int dx, int dy)
        {
            lBeg.X += dx;
            lBeg.Y += dy;
            lEnd.X += dx;
            lEnd.Y += dy;
        }
    }

    public class Rectangle : ITransform
    {
        private Point leftUp;
        private Point rightUp;
        private Point leftDown;
        private Point rightDown;

        public Point LeftUp
        {
            get { return leftUp; }
            set { leftUp = value; }
        }

        public Point RightUp
        {
            get { return rightUp; }
            set { rightUp = value; }
        }

        public Point LeftDown
        {
            get { return leftDown; }
            set { leftDown = value; }
        }

        public Point RightDown
        {
            get { return rightDown; }
            set { rightDown = value; }
        }

        public Rectangle(Point leftUp, Point rightUp, Point leftDown, Point rightDown)
        {
            this.leftUp = leftUp;
            this.rightUp = rightUp;
            this.leftDown = leftDown;
            this.rightDown = rightDown;
        }

        public void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, leftUp, rightUp);
            g.DrawLine(pen, leftUp, leftDown);
            g.DrawLine(pen, leftDown, rightDown);
            g.DrawLine(pen, rightUp, rightDown);
        }

        public void Rotate(Point center, int deg)
        {
            leftUp = CalcPoint.getNewPoint(leftUp, center, deg);
            rightUp = CalcPoint.getNewPoint(rightUp, center, deg);
            leftDown = CalcPoint.getNewPoint(leftDown, center, deg);
            rightDown = CalcPoint.getNewPoint(rightDown, center, deg);
        }

        public void Move(int dx, int dy)
        {
            leftUp.X += dx;
            leftUp.Y += dy;
            rightUp.X += dx;
            rightUp.Y += dy;
            leftDown.X += dx;
            leftDown.Y += dy;
            rightDown.X += dx;
            rightDown.Y += dy;
        }
    }

    public class Triangle : ITransform
    {
        private Point p1;
        private Point p2;
        private Point p3;

        public Point P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public Point P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        public Point P3
        {
            get { return p3; }
            set { p3 = value; }
        }

        public Point RightDown
        {
            get { return RightDown; }
            set { RightDown = value; }
        }

        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

        }

        public void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p1, p3);
        }

        public void Rotate(Point center, int deg)
        {
            this.p1 = CalcPoint.getNewPoint(p1, center, deg);
            this.p2 = CalcPoint.getNewPoint(p2, center, deg);
            this.p3 = CalcPoint.getNewPoint(p3, center, deg);
        }

        public void Move(int dx, int dy)
        {
            p1.X += dx;
            p1.Y += dy;
            p2.X += dx;
            p2.Y += dy;
            p3.X += dx;
            p3.Y += dy;
        }
    }

    public class Circle : ITransform
    {
        private Point center;
        private int dia;

        public Point Center
        {
            get { return center; }
            set { center = value; }
        }

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public Circle()
        {
            this.center = new Point(0, 0);
            this.dia = 0;
        }

        public Circle(Point center, int dia)
        {
            this.center = center;
            this.dia = dia;
        }

        public void Draw(Graphics g, Pen pen)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(center.X, center.Y, dia, dia);
            g.DrawEllipse(pen, rect);
        }

        public void Rotate(Point center, int deg)
        {
            this.center = CalcPoint.getNewPoint(this.center, center, deg);
        }

        public void Move(int dx, int dy)
        {
            center.X += dx;
            center.Y += dy;
        }
    }
}

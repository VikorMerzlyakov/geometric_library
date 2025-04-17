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
    // Интерфейс для преобразования геометрических фигур (поворот и перемещение)
    public interface ITransform
    {
        void Rotate(Point center, int deg); // Метод для поворота фигуры вокруг заданной точки на заданный угол
        void Move(int dx, int dy); // Метод для перемещения фигуры на заданные смещения по осям X и Y
    }

    // Внутренний статический класс для расчета новых координат точки после поворота
    internal static class CalcPoint
    {
        // Метод для получения новых координат точки после поворота вокруг заданной точки на заданный угол
        public static Point getNewPoint(Point x, Point center, int deg)
        {
            double ugol = deg * Math.PI / 180; // Преобразование угла из градусов в радианы

            // Расчет новых координат точки после поворота
            int newX = (int)(center.X + (x.X - center.X) * Math.Cos(ugol) - (x.Y - center.Y) * Math.Sin(ugol));
            int newY = (int)(center.Y + (x.X - center.X) * Math.Sin(ugol) + (x.Y - center.Y) * Math.Cos(ugol));

            return new Point(newX, newY); // Возвращение новой точки
        }
    }

    // Класс для представления линии, реализующий интерфейс ITransform
    public class Line : ITransform
    {
        private Point lBeg; // Начальная точка линии
        private Point lEnd; // Конечная точка линии

        // Свойство для доступа к начальной точке линии
        public Point LBeg
        {
            get { return lBeg; }
            set { lBeg = value; }
        }

        // Свойство для доступа к конечной точке линии
        public Point LEnd
        {
            get { return lEnd; }
            set { lEnd = value; }
        }

        // Конструктор по умолчанию, инициализирующий линию с началом и концом в точке (0, 0)
        public Line()
        {
            this.lBeg = new Point(0, 0);
            this.lEnd = new Point(0, 0);
        }

        // Конструктор, инициализирующий линию с заданными начальной и конечной точками
        public Line(Point lBeg, Point lEnd)
        {
            this.lBeg = lBeg;
            this.lEnd = lEnd;
        }

        // Метод для рисования линии на графическом контексте с заданной пером
        public void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, lBeg, lEnd); // Рисование линии между начальной и конечной точками
        }

        // Метод для поворота линии вокруг заданной точки на заданный угол
        public void Rotate(Point center, int deg)
        {
            Point newBeg = CalcPoint.getNewPoint(lBeg, center, deg); // Получение новых координат начальной точки
            Point newEnd = CalcPoint.getNewPoint(lEnd, center, deg); // Получение новых координат конечной точки

            this.lBeg.X = newBeg.X; // Обновление координат начальной точки
            this.lBeg.Y = newBeg.Y;
            this.lEnd.X = newEnd.X; // Обновление координат конечной точки
            this.lEnd.Y = newEnd.Y;
        }

        // Метод для перемещения линии на заданные смещения по осям X и Y
        public void Move(int dx, int dy)
        {
            lBeg.X += dx; // Смещение начальной точки по оси X
            lBeg.Y += dy; // Смещение начальной точки по оси Y
            lEnd.X += dx; // Смещение конечной точки по оси X
            lEnd.Y += dy; // Смещение конечной точки по оси Y
        }
    }

    // Класс для представления прямоугольника, реализующий интерфейс ITransform
    public class Rectangle : ITransform
    {
        private Point leftUp; // Левый верхний угол прямоугольника
        private Point rightUp; // Правый верхний угол прямоугольника
        private Point leftDown; // Левый нижний угол прямоугольника
        private Point rightDown; // Правый нижний угол прямоугольника

        // Свойство для доступа к левому верхнему углу прямоугольника
        public Point LeftUp
        {
            get { return leftUp; }
            set { leftUp = value; }
        }

        // Свойство для доступа к правому верхнему углу прямоугольника
        public Point RightUp
        {
            get { return rightUp; }
            set { rightUp = value; }
        }

        // Свойство для доступа к левому нижнему углу прямоугольника
        public Point LeftDown
        {
            get { return leftDown; }
            set { leftDown = value; }
        }

        // Свойство для доступа к правому нижнему углу прямоугольника
        public Point RightDown
        {
            get { return rightDown; }
            set { rightDown = value; }
        }

        // Конструктор, инициализирующий прямоугольник с заданными углами
        public Rectangle(Point leftUp, Point rightUp, Point leftDown, Point rightDown)
        {
            this.leftUp = leftUp;
            this.rightUp = rightUp;
            this.leftDown = leftDown;
            this.rightDown = rightDown;
        }

        // Метод для рисования прямоугольника на графическом контексте с заданной пером
        public void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, leftUp, rightUp); // Рисование верхней стороны прямоугольника
            g.DrawLine(pen, leftUp, leftDown); // Рисование левой стороны прямоугольника
            g.DrawLine(pen, leftDown, rightDown); // Рисование нижней стороны прямоугольника
            g.DrawLine(pen, rightUp, rightDown); // Рисование правой стороны прямоугольника
        }

        // Метод для поворота прямоугольника вокруг заданной точки на заданный угол
        public void Rotate(Point center, int deg)
        {
            leftUp = CalcPoint.getNewPoint(leftUp, center, deg); // Получение новых координат левого верхнего угла
            rightUp = CalcPoint.getNewPoint(rightUp, center, deg); // Получение новых координат правого верхнего угла
            leftDown = CalcPoint.getNewPoint(leftDown, center, deg); // Получение новых координат левого нижнего угла
            rightDown = CalcPoint.getNewPoint(rightDown, center, deg); // Получение новых координат правого нижнего угла
        }

        // Метод для перемещения прямоугольника на заданные смещения по осям X и Y
        public void Move(int dx, int dy)
        {
            leftUp.X += dx; // Смещение левого верхнего угла по оси X
            leftUp.Y += dy; // Смещение левого верхнего угла по оси Y
            rightUp.X += dx; // Смещение правого верхнего угла по оси X
            rightUp.Y += dy; // Смещение правого верхнего угла по оси Y
            leftDown.X += dx; // Смещение левого нижнего угла по оси X
            leftDown.Y += dy; // Смещение левого нижнего угла по оси Y
            rightDown.X += dx; // Смещение правого нижнего угла по оси X
            rightDown.Y += dy; // Смещение правого нижнего угла по оси Y
        }
    }

    // Класс для представления треугольника, реализующий интерфейс ITransform
    public class Triangle : ITransform
    {
        private Point p1; // Первая вершина треугольника
        private Point p2; // Вторая вершина треугольника
        private Point p3; // Третья вершина треугольника

        // Свойство для доступа к первой вершине треугольника
        public Point P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        // Свойство для доступа ко второй вершине треугольника
        public Point P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        // Свойство для доступа к третьей вершине треугольника
        public Point P3
        {
            get { return p3; }
            set { p3 = value; }
        }

        // Конструктор, инициализирующий треугольник с заданными вершинами
        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        // Метод для рисования треугольника на графическом контексте с заданной пером
        public void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, p1, p2); // Рисование первой стороны треугольника
            g.DrawLine(pen, p2, p3); // Рисование второй стороны треугольника
            g.DrawLine(pen, p1, p3); // Рисование третьей стороны треугольника
        }

        // Метод для поворота треугольника вокруг заданной точки на заданный угол
        public void Rotate(Point center, int deg)
        {
            this.p1 = CalcPoint.getNewPoint(p1, center, deg); // Получение новых координат первой вершины
            this.p2 = CalcPoint.getNewPoint(p2, center, deg); // Получение новых координат второй вершины
            this.p3 = CalcPoint.getNewPoint(p3, center, deg); // Получение новых координат третьей вершины
        }

        // Метод для перемещения треугольника на заданные смещения по осям X и Y
        public void Move(int dx, int dy)
        {
            p1.X += dx; // Смещение первой вершины по оси X
            p1.Y += dy; // Смещение первой вершины по оси Y
            p2.X += dx; // Смещение второй вершины по оси X
            p2.Y += dy; // Смещение второй вершины по оси Y
            p3.X += dx; // Смещение третьей вершины по оси X
            p3.Y += dy; // Смещение третьей вершины по оси Y
        }
    }

    // Класс для представления круга, реализующий интерфейс ITransform
    public class Circle : ITransform
    {
        private Point center; // Центр круга
        private int dia; // Диаметр круга

        // Свойство для доступа к центру круга
        public Point Center
        {
            get { return center; }
            set { center = value; }
        }

        // Свойство для доступа к диаметру круга
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        // Конструктор по умолчанию, инициализирующий круг с центром в точке (0, 0) и диаметром 0
        public Circle()
        {
            this.center = new Point(0, 0);
            this.dia = 0;
        }

        // Конструктор, инициализирующий круг с заданным центром и диаметром
        public Circle(Point center, int dia)
        {
            this.center = center;
            this.dia = dia;
        }

        // Метод для рисования круга на графическом контексте с заданной пером
        public void Draw(Graphics g, Pen pen)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(center.X, center.Y, dia, dia); // Создание прямоугольника, вписываемого в круг
            g.DrawEllipse(pen, rect); // Рисование круга внутри прямоугольника
        }

        // Метод для поворота круга вокруг заданной точки на заданный угол
        public void Rotate(Point center, int deg)
        {
            this.center = CalcPoint.getNewPoint(this.center, center, deg); // Получение новых координат центра круга
        }

        // Метод для перемещения круга на заданные смещения по осям X и Y
        public void Move(int dx, int dy)
        {
            center.X += dx; // Смещение центра круга по оси X
            center.Y += dy; // Смещение центра круга по оси Y
        }
    }
}

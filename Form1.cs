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
    // Основная форма приложения, где происходит отображение и управление геометрическими фигурами
    public partial class Form1 : Form
    {
        // Объект для рисования графики
        Graphics g;
        // Переменные для хранения экземпляров различных геометрических фигур
        Line line;
        Triangle triangle;
        Rectangle rect;
        Circle circle;

        // Конструктор формы, инициализирует компоненты и создает объект для рисования
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        // Обработчик события нажатия кнопки для отображения линии
        private void Line_btn_Click(object sender, EventArgs e)
        {
            Point A = new Point(20, 20); // Координата точки A
            Point B = new Point(40, 40); // Координата точки B
            line = new Line(A, B); // Создание линии между точками A и B
            Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования линии с указанным цветом
            line.Draw(g, myPen); // Рисование линии на форме
        }

        // Обработчик события нажатия кнопки для отображения треугольника
        private void Triangle_btn_Click(object sender, EventArgs e)
        {
            Point A = new Point(210, 20); // Координата точки A
            Point B = new Point(260, 100); // Координата точки B
            Point C = new Point(220, 80); // Координата точки C
            triangle = new Triangle(A, B, C); // Создание треугольника с вершинами A, B и C
            Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования треугольника с указанным цветом
            triangle.Draw(g, myPen); // Рисование треугольника на форме
        }

        // Обработчик события нажатия кнопки для отображения прямоугольника
        private void Rectangle_btn_Click(object sender, EventArgs e)
        {
            Point lu = new Point(110, 120); // Левый верхний угол
            Point ru = new Point(160, 100); // Правый верхний угол
            Point ld = new Point(120, 180); // Левый нижний угол
            Point rd = new Point(180, 160); // Правый нижний угол
            rect = new Rectangle(lu, ru, ld, rd); // Создание прямоугольника с указанными углами
            Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования прямоугольника с указанным цветом
            rect.Draw(g, myPen); // Рисование прямоугольника на форме
        }

        // Обработчик события нажатия кнопки для отображения круга
        private void Circle_btn_Click(object sender, EventArgs e)
        {
            Point center = new Point(170, 170); // Центр круга
            int dia = 35; // Диаметр круга
            circle = new Circle(center, dia); // Создание круга с указанным центром и диаметром
            Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования круга с указанным цветом
            circle.Draw(g, myPen); // Рисование круга на форме
        }

        // Обработчик события нажатия кнопки для перемещения линии
        private void Line_mov_btn_Click(object sender, EventArgs e)
        {
            if (dX_textBox.Text != "" && dY_textBox.Text != "") // Проверка, что поля ввода не пустые
            {
                int dx = Convert.ToInt32(dX_textBox.Text); // Получение значения смещения по оси X из текстового поля
                int dy = Convert.ToInt32(dY_textBox.Text); // Получение значения смещения по оси Y из текстового поля
                line.Move(dx, dy); // Перемещение линии на указанные значения
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования линии с указанным цветом
                line.Draw(g, myPen); // Рисование перемещенной линии на форме
            }
        }

        // Обработчик события нажатия кнопки для перемещения треугольника
        private void Triangle_mov_btn_Click(object sender, EventArgs e)
        {
            if (dX_textBox.Text != "" && dY_textBox.Text != "") // Проверка, что поля ввода не пустые
            {
                int dx = Convert.ToInt32(dX_textBox.Text); // Получение значения смещения по оси X из текстового поля
                int dy = Convert.ToInt32(dY_textBox.Text); // Получение значения смещения по оси Y из текстового поля
                triangle.Move(dx, dy); // Перемещение треугольника на указанные значения
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования треугольника с указанным цветом
                triangle.Draw(g, myPen); // Рисование перемещенного треугольника на форме
            }
        }

        // Обработчик события нажатия кнопки для перемещения прямоугольника
        private void Rect_mov_btn_Click(object sender, EventArgs e)
        {
            if (dX_textBox.Text != "" && dY_textBox.Text != "") // Проверка, что поля ввода не пустые
            {
                int dx = Convert.ToInt32(dX_textBox.Text); // Получение значения смещения по оси X из текстового поля
                int dy = Convert.ToInt32(dY_textBox.Text); // Получение значения смещения по оси Y из текстового поля
                rect.Move(dx, dy); // Перемещение прямоугольника на указанные значения
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования прямоугольника с указанным цветом
                rect.Draw(g, myPen); // Рисование перемещенного прямоугольника на форме
            }
        }

        // Обработчик события нажатия кнопки для перемещения круга
        private void Circle_mov_btn_Click(object sender, EventArgs e)
        {
            if (dX_textBox.Text != "" && dY_textBox.Text != "") // Проверка, что поля ввода не пустые
            {
                int dx = Convert.ToInt32(dX_textBox.Text); // Получение значения смещения по оси X из текстового поля
                int dy = Convert.ToInt32(dY_textBox.Text); // Получение значения смещения по оси Y из текстового поля
                circle.Move(dx, dy); // Перемещение круга на указанные значения
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования круга с указанным цветом
                circle.Draw(g, myPen); // Рисование перемещенного круга на форме
            }
        }

        // Обработчик события нажатия кнопки для поворота линии
        private void Line_rot_btn_Click(object sender, EventArgs e)
        {
            if (deg_textBox.Text != "") // Проверка, что поле ввода не пустое
            {
                int deg = Convert.ToInt32(deg_textBox.Text); // Получение угла поворота из текстового поля
                Point Center = new Point(60, 60); // Точка вокруг которой будет происходить поворот
                line.Rotate(Center, deg); // Поворот линии на указанный угол вокруг указанной точки
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования линии с указанным цветом
                line.Draw(g, myPen); // Рисование повернутой линии на форме
            }
        }

        // Обработчик события нажатия кнопки для поворота треугольника
        private void Triangle_rot_btn_Click(object sender, EventArgs e)
        {
            if (deg_textBox.Text != "") // Проверка, что поле ввода не пустое
            {
                int deg = Convert.ToInt32(deg_textBox.Text); // Получение угла поворота из текстового поля
                Point Center = new Point(260, 120); // Точка вокруг которой будет происходить поворот
                triangle.Rotate(Center, deg); // Поворот треугольника на указанный угол вокруг указанной точки
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования треугольника с указанным цветом
                triangle.Draw(g, myPen); // Рисование повернутого треугольника на форме
            }
        }

        // Обработчик события нажатия кнопки для поворота прямоугольника
        private void Rect_rot_btn_Click(object sender, EventArgs e)
        {
            if (deg_textBox.Text != "") // Проверка, что поле ввода не пустое
            {
                int deg = Convert.ToInt32(deg_textBox.Text); // Получение угла поворота из текстового поля
                Point Center = new Point(100, 100); // Точка вокруг которой будет происходить поворот
                rect.Rotate(Center, deg); // Поворот прямоугольника на указанный угол вокруг указанной точки
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования прямоугольника с указанным цветом
                rect.Draw(g, myPen); // Рисование повернутого прямоугольника на форме
            }
        }

        // Обработчик события нажатия кнопки для поворота круга
        private void Circle_rot_btn_Click(object sender, EventArgs e)
        {
            if (deg_textBox.Text != "") // Проверка, что поле ввода не пустое
            {
                int deg = Convert.ToInt32(deg_textBox.Text); // Получение угла поворота из текстового поля
                Point Center = new Point(100, 100); // Точка вокруг которой будет происходить поворот
                circle.Rotate(Center, deg); // Поворот круга на указанный угол вокруг указанной точки
                Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 255)); // Создание пера для рисования круга с указанным цветом
                circle.Draw(g, myPen); // Рисование повернутого круга на форме
            }
        }
    }
}

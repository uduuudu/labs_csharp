using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public void print()
        { Console.WriteLine($"x: {x} y: {y}"); }
    }

    public class Line
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        //public double length;
        public Line()
        {
            p1 = new Point();
            p2 = new Point();
        }

        public Line(Point p1_, Point p2_)
        {
            p1 = p1_;
            p2 = p2_;
            //length = Math.Sqrt(Math.Pow((p2.y - p1.y), 2) + Math.Pow((p2.x - p1.x), 2));
        }
        public void print()
        {
            Console.WriteLine($"Сторона: {p1.x} {p1.y} {p2.x} { p2.y}  ");
        }

        public Point toVector() // отрезок как вектор
        {
            Point res = new Point(p2.x - p1.x, p2.y - p1.y);
            return res;
        }

        public void stretch(int factor)
        {
            Point vec = this.toVector();
            vec.x = vec.x * factor;
            vec.y = vec.y * factor;
            Point newPt2 = new Point(p1.x + vec.x, p1.y + vec.y);
            p2 = newPt2;
        }


        public void compress(int f)
        {
            Point vec = this.toVector();
            vec.x = vec.x / f;
            vec.y = vec.y / f;
            Point newPt2 = new Point(p1.x + vec.x, p1.y + vec.y);
            p2 = newPt2;
        }
    }

    public class Square
    {


        // Квадрат представлен точкой пересечения диагоналей(центром), полудиагональю(любой) и цветом
        public Point center;
        public Line semidg;
        public string color;

        public Square()
        {
            color = "Black";
            center = new Point();
            semidg = new Line();
        }

        public Square(string c, Point cen, Line smd)
        {
            color = c;
            center = cen;
            semidg = smd;
        }

        public int reSize(int f) // задаем полудиагональ
        {
            semidg.p1 = center;
            semidg.p2 = new Point(center.x + (f / Math.Sqrt(2)), center.y + (f / Math.Sqrt(2)));
            return f;
        }

        public int stretching(int f)
        {
            semidg.stretch(f);
            return f;

        }

        public int compressing(int f)
        {
            semidg.compress(f);
            return f;

        }

        public int turn(int angle)
        {
            Point vec = semidg.toVector();
            double x_ = vec.x, y_ = vec.y;
            vec.x = x_ * Math.Cos(angle * Math.PI / 180) - y_ * Math.Sin(angle * Math.PI / 180);
            vec.y = y_ * Math.Sin(angle * Math.PI / 180) + y_ * Math.Cos(angle * Math.PI / 180);
            Point newPt2 = new Point(semidg.p1.x + vec.x, semidg.p1.y + vec.y);
            semidg.p2 = newPt2;
            return angle;
        }

        public void setColor(string _color)
        {
            color = _color;
        }

    }
}

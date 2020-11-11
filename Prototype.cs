using System;

namespace Prototype
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямокутник довжиною {0} i шириною {1}", height, width);
        }
    }
    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радiусом {0}", radius);
        }
    }
    class Triangle : IFigure
    {
        int side1;
        int side2;
        int side3;
        public Triangle(int s1, int s2, int s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
        public IFigure Clone()
        {
            return new Triangle(this.side1, this.side2, this.side3);
        }
        public void GetInfo()
        {
            Console.WriteLine("Трикутник зi сторонами {0}, {1}, {2}", side1, side2, side3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Rectangle(10, 20);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Triangle(10, 20, 25);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
        }
    }
}
using System;

namespace Lesson3_Task1
{
    #region Фабрика

    public enum Shapes
    {
        Triangle,
        Rectangle,
        Circle
    }

    public interface IShapeFactory
    {
        IShape CreateShape(Shapes shape);
    }

    public class ShapeFactory : IShapeFactory
    {
        public IShape CreateShape(Shapes shape)
        {
            switch (shape)
            {
                case Shapes.Triangle:
                    return new Triangle();
                case Shapes.Rectangle:
                    return new Rectangle();
                case Shapes.Circle:
                    return new Circle();
                default:
                    return new UnknownShape();
            }
        }
    }

    #endregion

    #region Фабричный метод

    interface IShapeFactoryMethod
    {
        IShape CreateShape();
    }

    public class TriangleFactory : IShapeFactoryMethod
    {
        public IShape CreateShape()
        {
            return new Triangle();
        }
    }

    public class RectangleFactory : IShapeFactoryMethod
    {
        public IShape CreateShape()
        {
            return new Rectangle();
        }
    }

    public class CircleFactory : IShapeFactoryMethod
    {
        public IShape CreateShape()
        {
            return new Circle();
        }
    }

    #endregion

    #region Shape Classes

    public interface IShape
    {
        double Perimeter();
        double Area();
    }

    public class Triangle : IShape
    {
        public float SideA { get; set; } = 1;
        public float SideB { get; set; } = 1;
        public float SideC { get; set; } = 1;

        public void SetSides(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public double Area()
        {
            double HalfP = Perimeter() / 2;
            return Math.Sqrt(HalfP * (HalfP - SideA) * (HalfP - SideB) * (HalfP - SideC));
        }
    }

    public class Rectangle : IShape
    {
        public float Width { get; set; } = 1;
        public float Heigth { get; set; } = 1;

        public void SetWidthHeigth(float width, float heigth)
        {
            Width = width;
            Heigth = heigth;
        }

        public double Perimeter()
        {
            return (Width + Heigth) * 2;
        }
        public double Area()
        {
            return Width * Heigth;
        }
    }

    public class Circle : IShape
    {
        public float Radius { get; set; } = 1;

        public double Perimeter()
        {
            return Math.PI * Radius * 2;
        }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class UnknownShape : IShape
    {
        public double Perimeter()
        {
            return 0;
        }
        public double Area()
        {
            return 0;
        }
    }

    #endregion

    public class Program
    {
        public static void Main(string[] args)
        {
            // Фабрика
            IShapeFactory shapeFactory = new ShapeFactory();

            var firstShape = (Triangle)shapeFactory.CreateShape(Shapes.Triangle);

            firstShape.SetSides(10, 10, 10);

            Console.WriteLine("Площадь первой фигуры: {0}", firstShape.Area());
            Console.WriteLine("Периметр первой фигуры: {0}", firstShape.Perimeter());

            Console.WriteLine();


            // Фабричный метод
            IShapeFactoryMethod shapeFactoryMethod = new TriangleFactory();

            var secondShape = (Triangle)shapeFactoryMethod.CreateShape();

            secondShape.SetSides(20, 20, 20);

            Console.WriteLine("Площадь второй фигуры: {0}", secondShape.Area());
            Console.WriteLine("Периметр второй фигуры: {0}", secondShape.Perimeter());

            Console.ReadLine();
        }
    }
}
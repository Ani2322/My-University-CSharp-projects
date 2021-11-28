using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] factories = new Creator[3];
            factories[0] = new RectangleFactory();
            factories[1] = new SquareFactory();
            factories[2] = new CircleleFactory();
            Shape shape;
            foreach (Creator factory in factories)
            {
                shape = factory.FactoryMethod();
                shape.Input();
                shape.Output();
            }
        }
    }

    public abstract class Shape
    {
        public abstract void Input();
        public abstract void Output();
        public abstract double Area();        
    }

    class Circle: Shape
    {
        protected double r;
        
        public override void Input()
        {
            Console.WriteLine("Enter a value for the radius:");
            Console.Write("r = ");
            r = double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine("The Circle Area is {0}", Area());
        }

        public override double Area()
        {
            double S = r * r * Math.PI;
            return S;
        }

    }

    class Rectangle : Shape
    {
        protected double a, b;

        public override void Input()
        {
            Console.WriteLine("Enter sides for the Rectangle:");
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());

        }

        public override void Output()
        {
            Console.WriteLine("The Rectangle Area is {0}", Area());
        }

        public override double Area()
        {
            double S = a * b;
            return S;
        }
    }

    class Square: Shape
    {
        protected double a;
        public override void Input()
        {
            Console.WriteLine("Enter a side for the Square:");
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine("The Area is {0}", Area());
        }

        public override double Area()
        {
            double S = a * a;
            return S;
        }

    }

    abstract class Creator
    {
        public abstract Shape FactoryMethod();
    }

    class RectangleFactory : Creator
    {
        public override Shape FactoryMethod()
        {
            return new Rectangle();
        }
    }

    class SquareFactory : Creator
    {
        public override Shape FactoryMethod()
        {
            return new Square();
        }
    }

    class CircleleFactory : Creator
    {
        public override Shape FactoryMethod()
        {
            return new Circle();
        }
    }
}

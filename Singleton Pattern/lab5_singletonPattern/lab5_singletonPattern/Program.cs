using System;

namespace lab5_singletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangularArea NewArea = RectangularArea.GetInstance;
            NewArea.Info();
            Point NewPoint = new Point();
            bool isPointInArea = false;
            while(isPointInArea == false)
            {
                try
                {
                    int x = NewPoint.InputX();
                    int y = NewPoint.InputY();
                    if(x>=0 && x<=1000 && y>=0 && y<=1000)
                    {
                        isPointInArea = true;
                    }
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("The cordinates are out of area");
                }

            }
            NewPoint.Info();
        }

        sealed class RectangularArea
        {
            private static int top;
            private static int bottom; 
            private static int left;
            private static int right; 
            private static readonly object obj = new object(); 
            private static RectangularArea instance = null; 
            private RectangularArea()
            {
                top = 0; bottom = 1000;
                left = 0; right = 1000;
            }
            public static RectangularArea GetInstance 
            { 
                get { lock (obj) 
                    { 
                        if (instance == null) 
                            instance = new RectangularArea(); 
                        return instance; 
                    } 
                }
            }
            public int Left 
            {
                get 
                { 
                    return left; 
                }
            }
            public int Right 
            {
                get
                { 
                    return right;
                }
            }
            public int Top 
            {
                get 
                {
                    return top;
                }
            }
            public int Bottom {
                get { 
                    return bottom; 
                } 
            }
            public void Info() 
            {
                Console.WriteLine("BoundariesTop {0}, Bottom {1} Left {2} Right {3}", top, bottom, left, right); 
            }
        }
    }

    public class Point
    {
        int x,y;
        public Point()
        {
            int x, y;
        }
        public int InputX()
        {
            Console.WriteLine("Enter a value for x");
            Console.Write("x=");
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        public int InputY()
        {
            Console.WriteLine("Enter a value for y");
            Console.Write("y=");
            x = Convert.ToInt32(Console.ReadLine());
            return y;
        }

        public void Info()
        {
            Console.WriteLine("Cordinates of the points: x={0}, y={1}\n The point is in the area", x, y);
        }

       
    }

}


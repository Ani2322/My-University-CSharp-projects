using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90, 15, 1, 8 };

            Context context;
            
            Console.Write("Method: ");
            string method = Console.ReadLine();

            switch (method.ToLower())
            {
                case "bubblesort":
                context = new Context(new BubbleSort());
                context.ContextInterface(array, method);
                break;
                case "insertionsort":
                context = new Context(new InsertionSort());
                context.ContextInterface(array, method);
                break;
                default:
                    Console.WriteLine("There isn't sort method");
                break;

            }
        }
    }
}

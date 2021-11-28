using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    public abstract class SortMethod
    {
        public abstract void CreateSortMethod(int[] arr);
        public abstract void printArray(int[] arr);
        public void ShowMethod(string method)
        {
            Console.WriteLine($"The sort method is: {method}");
        }
    }
}

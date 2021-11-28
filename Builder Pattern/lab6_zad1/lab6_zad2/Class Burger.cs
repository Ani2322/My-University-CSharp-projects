using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_zad2
{
    class Burger
    {
        private string burgerType;
        private List<string> parts = new List<string>();
        public Burger(string type)
        {
            burgerType = type;
        }

        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine(burgerType);
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }

    }
}

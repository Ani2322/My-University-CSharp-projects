using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_zad2
{
    abstract class BurgerBuilder
    {
        protected Burger burger;
        public bool cucumber { get; set; }
        public bool tomatoes { get; set; }

        public bool salad { get; set; }

        public Burger Burger
        {
            get
            {
                return burger;
            }
        }

        public abstract void BuildBread(string BreadType);
        public abstract void BuildProduct();
        public abstract void BuildSalad(bool salad);
        public abstract double BuildPrice();
        
    }
}

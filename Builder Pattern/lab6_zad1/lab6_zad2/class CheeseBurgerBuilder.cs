using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_zad2
{
    class CheeseBurgerBuilder : BurgerBuilder
    {
        public CheeseBurgerBuilder()
        {
            burger = new Burger("CheeseBurger");

        }
        public override void BuildBread(string BreadType)
        {
            burger.Add(BreadType);
        }

        public override double BuildPrice()
        {
            return 4.59;
        }

        public override void BuildProduct()
        {
            burger.Add("Cheese");
        }

        public override void BuildSalad(bool ssalad)
        {
            if (salad)
            {
                burger.Add("Iceberg");

            }

            burger.Add("Cucumber");
            burger.Add("Tomatoes");
        }
    }
}

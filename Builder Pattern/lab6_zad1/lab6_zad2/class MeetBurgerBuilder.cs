using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_zad2
{
    class MeetBurgerBuilder:BurgerBuilder
    {
        public MeetBurgerBuilder()
        {
            burger = new Burger("MeetBurger");
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
            burger.Add("Meet");
        }

        public override void BuildSalad(bool ssalad)
        {
            if (salad)
            {
                burger.Add("Onion");
                
            }

            burger.Add("Cucumber");
            burger.Add("Tomatoes");
        }
    }

}

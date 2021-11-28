using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_zad2
{
    class Director
    {
        public void Construct(BurgerBuilder burgerBuilder, string breadType, string salad)
        {
            burgerBuilder.BuildBread(addBread(breadType));
            burgerBuilder.BuildProduct();
            burgerBuilder.BuildSalad(IsHasSalad(burgerBuilder, salad));
            burgerBuilder.BuildPrice();
        }

        private static string addBread(string breadType)
        {
            string bread = "";
            if (breadType.ToLower() == "white")
            {
                bread = Convert.ToString(Breads.White);
            }
            else if (breadType.ToLower() == "brown")
            {
                bread = Convert.ToString(Breads.Brown);
            }

            return bread;
        }

        private bool IsHasSalad(BurgerBuilder burgerBuilder, string salad)
        {
            bool isHasSalad = false;
            if (salad.ToLower() == "yes")
            {
                burgerBuilder.salad = true;
                isHasSalad = true;
            }

            return isHasSalad;
        }
    }юю
}

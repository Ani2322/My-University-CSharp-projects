using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_zad2
{
    class Program
    {
        public static void Main(string[] args)
        {
            BurgerBuilder[] burgerBuilders = new BurgerBuilder[2];

            Console.Write("Enter a bread type for your CheeseBurger - white or brown: ");
            string cheeseBurgerBreadType = Console.ReadLine();

            Console.Write("Do you want a Salad Isberg?: ");
            string saladCheeseBurger = Console.ReadLine();

            burgerBuilders[0] = new CheeseBurgerBuilder();
            Director producerCheeseBurger = new Director();
            producerCheeseBurger.Construct(burgerBuilders[0], cheeseBurgerBreadType, saladCheeseBurger);

            burgerBuilders[0].Burger.Show();
            Console.WriteLine();

            Console.Write("Enter a bread type for your MeetBurger - white or brown: ");
            string meetBurgerBreadType = Console.ReadLine();

            Console.Write("Do you want a Onion?: ");
            string saladMeetBurger = Console.ReadLine();

            burgerBuilders[1] = new MeetBurgerBuilder();
            Director producerMeerBurger = new Director();
            producerMeerBurger.Construct(burgerBuilders[1], meetBurgerBreadType, saladMeetBurger);

            burgerBuilders[1].Burger.Show();
        }
    }
}
using System;

namespace Lab_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentalFactory factory1 = new AfricanFactory();
            Client client1 = new Client(factory1);
            client1.Run();
            ContinentalFactory factory2 = new AsiaticFactory();
            Client client2 = new Client(factory2);
            client2.Run();
        }
    }

    abstract class Elephant
    {
        public abstract int GetWeight();
        public abstract int GetHeight();
        public abstract string GetHabitat();
        public abstract string GetFood();
        public abstract string GetLatinName();
    }

    abstract class Lion
    {
        public abstract string GetFeatures();
        public abstract string GetHabitat();
        public abstract string GetFood();
        public abstract string GetLatinName();
        public abstract void CanMeet(Elephant elephant);

    }

    class AfricanElephant : Elephant
    {
        public override int GetWeight()
        {
            return 7500;
        }
        public override int GetHeight()
        {
            return 4;
        }
        public override string GetHabitat()
        {
            string info = " lives in the African savannah";
            return info;
        }
        public override string GetLatinName()
        {
            string info = "The latin name is Loxodonta africana";
            return info;
        }
        public override string GetFood()
        {
            string info = " feeds on plants";
            return info;
        }

    }

    class IndianElephant : Elephant
    {
        public override int GetWeight()
        {
            return 6000;
        }
        public override int GetHeight()
        {
            return 3;
        }
        public override string GetHabitat()
        {
            string info = " lives in South Asia";
            return info;
        }
        public override string GetLatinName()
        {
            string info = "The latin name is Elephas maximus indicus";
            return info;
        }
        public override string GetFood()
        {
            string info = " feeds on plants";
            return info;
        }
    }

    class AfricanLion : Lion
    {
        public override string GetFeatures()
        {
            return "Има голяма грива";
        }
        public override string GetHabitat()
        {
            return "lives in West Indies";
        }
        public override string GetFood()
        {
            return " feeds on meet";
        }
        public override string GetLatinName()
        {
            return "The latin name is Panthera leo";
        }
        public override void CanMeet(Elephant elephant)
        {
            Console.WriteLine(this.GetType().Name + " може да срешне " + elephant.GetType().Name);
        }
    }

        class AsiaticLion : Lion
        {
            public override string GetFeatures()
            {
                return "Има малка грива";
            }
            public override string GetHabitat()
            {
                return " lives only in Sassan Gir National Park, India";
            }
            public override string GetFood()
            {
                return " feeds on meet";
            }
            public override string GetLatinName()
            {
                return "The latin name is Panthera leo persica";
            }
            public override void CanMeet(Elephant elephant)
            {
                Console.WriteLine(this.GetType().Name + " може да срешне " + elephant.GetType().Name);
            }
        }

    abstract class ContinentalFactory 
    { 
        public abstract Lion CreateLion();
        public abstract Elephant CreateElephant(); 
    }

    class AfricanFactory : ContinentalFactory
    {
        public override Lion CreateLion()
        {
            return new AfricanLion();
        }
        public override Elephant CreateElephant()
        {
            return new AfricanElephant();
        }
    }

    class AsiaticFactory : ContinentalFactory
    {
        public override  Lion CreateLion()
        {
            return new AsiaticLion();
        }
        public override  Elephant CreateElephant()
        {
            return new IndianElephant();
        }
    }

    class Client
    {
        private Lion lion;
        private Elephant elephant;
        public Client(ContinentalFactory factory)
        {
            lion = factory.CreateLion();
            elephant = factory.CreateElephant();
        }
        public void Run()
        {
            Console.WriteLine($"{elephant.GetType().Name} тежи {elephant.GetWeight()} кг");
            Console.WriteLine($"{elephant.GetType().Name} е висок {elephant.GetHeight()} м");
            Console.WriteLine($"{elephant.GetType().Name} {elephant.GetHabitat()}");
            Console.WriteLine($"{elephant.GetType().Name} {elephant.GetFood()}");
            Console.WriteLine($"{elephant.GetType().Name} {elephant.GetLatinName()}");

            Console.WriteLine(lion.GetType().Name + lion.GetFeatures());
            Console.WriteLine(lion.GetType().Name + lion.GetFood());
            Console.WriteLine(lion.GetType().Name + lion.GetHabitat());
            Console.WriteLine(lion.GetType().Name + lion.GetLatinName());
                    lion.CanMeet(elephant);
        }
    }
}

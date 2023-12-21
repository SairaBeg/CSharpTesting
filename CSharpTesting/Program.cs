using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSharpTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Circle cir = new Circle(5);
            Console.WriteLine(cir.area());
            Chef chef = new Chef();
            chef.SpecialDish();
            ItalianChef italianChef = new ItalianChef();
            italianChef.SpecialDish();
            Vehicle ford = new Vehicle("Ford Fiesta", 2000);
            Book bk = new Book("A star is born", "lady gaga", 50000, 50);
            Console.WriteLine(bk.Name);

            PowerOf pow = new PowerOf(2, 3);
            Console.WriteLine(pow.Power());

            string var = Console.ReadLine();
            

        }
        static string Phrase()
        {
            return "function";
        }
        static string Day(int day)
        {
            string dayName = "";
            switch (day)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                default:
                    dayName = "Invalid day name";
                    break;
            }
            return dayName;
        }
    }

    class Vehicle
    {
        public string name;
        public int price = 100;
        public Vehicle(string name, int price)
        {
            this.name = name;
            this.price = price;
        }



    }
    class Car : Vehicle
    {
        public Car(string name, int price) : base(name, price)
        {


        }



    }

}

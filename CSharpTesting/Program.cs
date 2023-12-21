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
            int [] arr = { 1,2,3,4,5};

            Circle cir = new Circle(5);
            Console.WriteLine(cir.area());
            Chef chef = new Chef();
            chef.MakeChicken();
            ItalianChef italianChef = new ItalianChef();
            italianChef.SpecialDish();


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



}


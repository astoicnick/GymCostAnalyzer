using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCost
{
    class SingleFileApp
    {
        static void Main(string[] Args)
        {
            int gymStuff = GymEquipment();
            int months = CollectInput();
            int pFitness = PlanetFitness(months);
            string message = CostComparison(gymStuff,pFitness);
            Console.WriteLine(message);
            Console.ReadLine();

        }
        static public int CollectInput()
        {
            Console.WriteLine("How many months would you like to use the gym for?");
            int numofmonths = int.Parse(Console.ReadLine());
            return numofmonths;
        }
        static public int GymEquipment()
        {
            int total;
            int backroller = 15;
            int dumbbells = 100;
            int kettlebells = 35;
            int bench = 40;
            total = dumbbells + kettlebells + bench;
            return total;
        }
        static public int PlanetFitness(int months)
        {
            int cost;
            int eighteenmonth = 199;
            int regularmonth = (29 / 12) + (39 / 12) + (10 * months);
            if (regularmonth > eighteenmonth)
            {
                //Console.WriteLine("Your cheapest option would be to purchase the" +
                //    "18 month plan for $199");
                cost = eighteenmonth;
            }
            else
            {
                //Console.WriteLine("Your cheapest option would be to purchase by" +
                //    " the month for $" + regularmonth + " total for " + months + ".");
                cost = regularmonth;
            }
            return cost;
        }
        static public string CostComparison(int gymEquipment, int planetFitness)
        {
            string message;
            if (gymEquipment > planetFitness)
            {
                message = "Your cheapest option is to buy the Planet" +
                    " Fitness membership for " + planetFitness + ".";
            }
            else
            {
               message = "Your cheapest option is to buy the " +
                    "gym equipment for " + gymEquipment + ".";
            }
            return message;
        }
    }
}

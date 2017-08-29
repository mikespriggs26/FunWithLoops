using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loops
            /*
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            foreach (string month in months)
            {
                Console.WriteLine(month);
                if (month == "Dec")
                {
                    Console.WriteLine("That's the best month");
                }
                else
                {
                    Console.WriteLine("That month is ok I guess...");
                }
            }
            

            string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            foreach (string musician in musicians)
            {
                Console.WriteLine(musician);
            }
            */
            //Create a program that asks the user for their fav food and stores that value in an array
            //Loop through the array and print the all of the foods

            //create an array of lucky numbers using a foreach loop print the following:
            // Your lucky number is: 4
            //your lucky number is: 19
            //your lucky number is:7

            Console.WriteLine("What is your favorite food");
            string food1 = Console.ReadLine();
            Console.WriteLine("What is your second favorite food");
            string food2 = Console.ReadLine();
            Console.WriteLine("What is your third favorite food");
            string food3 = Console.ReadLine();

            string[] favFood = { food1, food2, food3 };

            /*string[] favFood = new string[3];
            favFood[0] = food1;
            favFood[1] = food2;
            favFood[2] = food3;*/

            foreach(string food in favFood)
            {
                Console.WriteLine(food);

            }

            // Next problem




        }
    }
}

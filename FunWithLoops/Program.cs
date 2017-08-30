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

            /*Console.WriteLine("What is your favorite food");
            string food1 = Console.ReadLine();
            Console.WriteLine("What is your second favorite food");
            string food2 = Console.ReadLine();
            Console.WriteLine("What is your third favorite food");
            string food3 = Console.ReadLine();

            string[] favFood = { food1, food2, food3 };
            if (favFood.Contains("a"))
            {
                Console.WriteLine("contains a");
            }
            else
            {
                Environment.Exit(0);
            }*/
            ////string[] favFood = new string[3];
            //favFood[0] = food1;
            //favFood[1] = food2;
            //favFood[2] = food3;

            //foreach(string food in favFood)
            //{
            //    Console.WriteLine(food);

            //}

            // Next problem

            //int[] luckyNumbers = { 4, 19, 17 };
            //foreach ( int num in luckyNumbers)
            //{
            //    Console.WriteLine("Your lucky number is " + num);
            //}*/

            //string[] Names =  { "Jordan", "Max", "Peter" };
            //for (int i = 0; i < Names.Length; i++)
            //{
            //    //Names[i] = Names[i].ToLower();
            //    //Console.WriteLine(Names[i]);
            //}
            //for (int i = 50; i<=100;i++)
            //{
            //    Console.WriteLine(i);
            //}
            //string greetings = "My name is Mike";
            //string[] words = greetings.Split();

            //for (int i=0; i <words.Length;i++)
            //{
            //    Console.WriteLine(words[i]);
            //    if(words[i] == "Mike")
            //    {
            //        words[i] = "Max";
            //    }

            //}
            //Console.WriteLine(words[words.Length-1]);

            //  1.  Create an array called days with the elements mon, tues, etc.
            //use a for loop to print the elements
            //  2.  Create an int array size 25.  Put the numbers 1-25 in the array and print
            ////  3.  Start with the string "Once upon a time" and create an array called storyWords using the split method.
            //// Reverse the order of the elements in the array and using a for loop.  Print each word.

            ////  #1
            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //for (int i = 0; i<days.Length;i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            ////   #2
            //int[] numbers = new int[25];
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    numbers[i] = i+1;
            //    Console.WriteLine(numbers[i]);
            //}

            //  #3
            //string story = "Once upon a time";
            //string[] words = story.Split();
            //Array.Reverse(words);
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //while loops
            //Console.WriteLine("Do you want to play a game?");
            //string playAgain = Console.ReadLine();
            //while (playAgain == "Yes")
            //{
            //    Console.WriteLine("Its a rematch");
            //    Console.WriteLine("Do you want to play again?");
            //    playAgain = Console.ReadLine();
            //}

            //Console.WriteLine("What is your favorite roygbiv color?");
            //string userColor = Console.ReadLine();
            ////bool isRoygbivColor = false;
            //while (userColor != "red")
            //{
            //    Console.WriteLine("Sorry that is not the correct color. Please try again.");
            //    userColor = Console.ReadLine();

            //}
            string playAgain;
            do
            {
                Console.WriteLine("Do you want to build a snowman?");
                Console.WriteLine("That was fun.");
                Console.WriteLine("Do you want to build another snowman?");
                playAgain = Console.ReadLine();

            }
            while (playAgain == "Yes");




        }
    }
}

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
            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Do you want to build a snowman?");
            //    Console.WriteLine("That was fun.");
            //    Console.WriteLine("Do you want to build another snowman?");
            //    playAgain = Console.ReadLine();

            //}
            //while (playAgain == "Yes");

            int x = 1;
            //while (x<=10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //int lives = 3;
            //int magicNumber = 24;
            //bool isPlaying = true;
            //while (lives > 0 && isPlaying == true)
            //{
            //    Console.WriteLine("Guess my lucky number");
            //    int userGuess = int.Parse(Console.ReadLine());
            //    if (magicNumber == userGuess)
            //    {
            //        Console.WriteLine("You guessed right.");
            //        isPlaying = false;
            //        //break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry. Try again.");
            //        lives--;
            //        Console.WriteLine("You have " + lives + " lives left");
            //    }

            //Print the numbers 1 to 100
            //if the number is a multiple of 3 print fizz,
            //if the number is a multiple of 5 print 
            //if the number is a multiple of both print fizzbuzz

            //for (int i = 1; i <= 100; i++)
            //{
            //   if (i % 3  == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("fizzbuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("fizz");
            //    }
            //    else if (i % 5 ==0)
            //    {
            //        Console.WriteLine("buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////create an int array with elements.  Find the mean of these elements and print the results


            //int[] numbers = { 23, 55, 38, 96, 35, 58, 26, 84, 56, 62 };
            //int sum = 0;
            //foreach (int num in numbers)
            //{
            //     sum += num;

            //}
            //Console.WriteLine(sum/numbers.Length );

            //Write a program and ask the user for two numbers(n and m). 
            //Check to see if M is greater than N. If m is not larger than n
            //have the users enter new numbers.  M>N
            //Between n amd m find all the numbers that are multiple of 3 and print those numbers


            //foreach (int num in nums)
            //{
            //    Console.WriteLine(num);
            //    //if(num %3 == 0)
            //    //{
            //    //    Console.WriteLine(num);
            //    //}
            //}


            //foreach(int num in nums)
            //{
            //        nums
            //}

            //Console.WriteLine(numN + " " + numM);
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    numbers[i] = i+1;
            //    Console.WriteLine(numbers[i]);
            //}
            //*****************************************
            //int numM = 0;
            //int numN = 0;
            //do
            //{
            //    Console.WriteLine("Please enter a number");
            //    numM = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please enter a second number");
            //    numN = int.Parse(Console.ReadLine());
            //} while (numM < numN);

            //int remainder = numM - numN;

            //int[] nums = new int[remainder];
            //for (int i = numN; i < numM; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //***************************************************
            //         Nested Loops
            //for (int i = 1; i <=2; i++)
            //{
            //    for (int j = 1; j <=4; j++)
            //    {
            //        Console.Write(j); //columns
            //    }
            //    Console.WriteLine();  //row
            //}
            //Print a triangle
            //int n = 4;
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //******************
            //
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(i + "x" + j + "    ");
            //    }
            //    Console.WriteLine();
            //}

            //**************
            int num = 1;
            do
            {
                Console.WriteLine("Please enter a number");
                num = int.Parse(Console.ReadLine());
            } while (num %3 ==0);

            Console.WriteLine("You won");
            
            //int num = 2;
            //while (num % 3 == 0)
            //{
            //    Console.WriteLine("Please enter a number");
            //    num = int.Parse(Console.ReadLine());


            //}
            //Console.WriteLine("You won");

           









        }
    }
}

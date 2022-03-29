using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var array50 = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(array50);

            //Print the first number of the array
            Console.WriteLine(array50[0]);

            //Print the last number of the array
            Console.WriteLine(array50[array50.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(array50);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            //ReverseArray(array50);
            Array.Reverse(array50);
            NumberPrinter(array50);
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(array50);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(array50);
            NumberPrinter(array50);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var intList = new List<int>();
            //Print the capacity of the list to the console
            Console.WriteLine(intList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intList);
            
            //Print the new capacity
            Console.WriteLine(intList.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            bool numCheck;
            int result;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                numCheck = int.TryParse(Console.ReadLine(), out result);
                if (!numCheck)
                {
                    Console.WriteLine("Invalid input");
                }
            } while (!numCheck);
            NumberChecker(intList, result);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            NumberPrinter(intList);
            //Print all numbers in the list
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var newArray = intList.ToArray();

            //Clear the list
            intList.Clear();
            Console.WriteLine(intList.Count);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach(var number in numbers)
            {
                if(number % 3 != 0)
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(number => number % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is in the list");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not in the list");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }
        }

        private static void Populater(int[] numbers)
        {
            var rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rng.Next(0, 50);
                //Console.WriteLine(numbers[i]);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

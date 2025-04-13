using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var numArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numArray);

            //TODO: Print the first number of the array
            Console.WriteLine(numArray[0]);

            //TODO: Print the last number of the array  
            Console.WriteLine(numArray[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            
            Array.Reverse(numArray);
            NumberPrinter(numArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numArray);
            NumberPrinter(numArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(numArray);
            NumberPrinter(numArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numArray);
            NumberPrinter(numArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(numList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList);

            //TODO: Print the new capacity
            Console.WriteLine(numList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            int checkNumber = 0;
            
            while (!int.TryParse(Console.ReadLine(), out checkNumber))
            {
                Console.WriteLine("Please enter a valid integer.");
            }
            NumberChecker(numList, checkNumber);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            OddKiller(numList);
            NumberPrinter(numList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 1)
                {
                    numberList[i] = 0;
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
               if (numberList.Contains(searchNumber))
               {
                   Console.WriteLine($"{searchNumber} is on the list.");
               }
               else
               {
                   Console.WriteLine($"{searchNumber} is not on the list.");           
               }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 51));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for(int i =0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0,51);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            int first = 0;
            int last = array.Length - 1;
            
            while (first < last)
            {
                int temp = array[first];
                array[first] = array[last];
                array[last] = temp;
                
                first++;
                last--;
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

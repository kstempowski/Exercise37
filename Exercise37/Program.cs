using System;

namespace Exercise37
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                //Create an array of doubles that holds 5 values.
                int[] myArray = new int[5];

                //a loop. If int i is zero, and i is less than 5 increase i by 1
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Please enter number.");
                    //Convert the input values to integers
                    myArray[i] = Convert.ToInt32(Console.ReadLine());

                }
                int sum = myArray[0] +
                          myArray[1] +
                          myArray[2] +
                          myArray[3] +
                          myArray[4];

                //Output the sum of the array as an integer.
                Console.WriteLine($"The sum of the entered numbers is {sum}");

                Console.WriteLine("Would you like to input another set of numbers? y/n");

                //Loop back if the user selects y, all other selections will terminate the program.
                string answer = Console.ReadLine().ToLower();

                if(answer == "y")
                {
                    repeat = true;
                }
                else
                {
                    Console.WriteLine("Goodbye.");
                    repeat = false;
                }
            }
        }
    }
}

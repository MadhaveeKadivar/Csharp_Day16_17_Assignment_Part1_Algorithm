using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class NumberGuessingGame
    {
        public static int count=0;
        static char ans;
        public static int GuessTheNumber(double range) // Creating a method to get the user's number
        {
            int low = 0; // Storing 0 as low value
            int high = (int)range; // Storing maximum value as high
            int number = Guess(low, high);   // Call the method with passing low and high as parameters
            return number;
        }
        public static int Guess(int low,int high) // Creating a method to get the user's number
        {
            int mid = low + (high - low) / 2; // calculating mid value
 
            if (high - mid == 1) // Checking that only one number left between high amd mid
            {
                Console.WriteLine($"\nNumber of question asked to guess the number : {count}");
                return mid;//Returing a mid as user's number      
            }
            Again:
            Console.WriteLine($"\nIs your number {mid} ?");
            count++;
            ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y') // Ask user to find mid is User's number or not if yes then return mid value as user;s number
            {
                Console.WriteLine($"\nNumber of question asked to guess the number : {count}");
                return mid;
            }
            else if (ans == 'N' || ans == 'n') //If not then ask question to user that USer's number is greater than mid or not
            {
                Loop:
                Console.WriteLine($"\nIs your number Greater than {mid} ? ");
                count++;
                ans = Convert.ToChar(Console.ReadLine());
                if (ans == 'Y' || ans == 'y') // If greater than then call this method again with mid value as high
                {
                    return Guess(mid, high);
                }
                else if (ans == 'N' || ans == 'n') // If lesser than then call this method again with mid value as low
                {
                    return Guess(low, mid);
                }
                else
                {
                    Console.WriteLine("\nPlease Enter only y or n");
                    goto Loop;
                }
            }
            else
            {
                Console.WriteLine("\nPlease Enter only y or n");
                goto Again;
            }
        }
    }
}

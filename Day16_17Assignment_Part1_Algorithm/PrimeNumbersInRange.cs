using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class PrimeNumbersInRange
    {
        public static ArrayList FindPrimeNumbers(int start,int end) // Creating a method to find all prime numbers between given range
        {
            int prime = 0;
            ArrayList primeNumbers = new ArrayList(); // Creating a list to maintain all prime numbers
            if (start <= end) // Checking that start point not greater than end point
            {
                if (start == 0) // If start point point is 0 then we have to move it at 2
                {
                    start+=2;
                }
                if (start == 1) // If start point point is 1 then we have to move it at 2
                {
                    start++;
                }
                if (start == 2) // If start point point is 2 then we have to add it in prime array because 2 is prime number
                {
                    if (end >= 2)
                    {
                        primeNumbers.Add(2);
                        start += 1;
                    }
                }
                for (int i = start; i <= end; i++) // Iterate numbers from start to end
                {
                    for (int j = 2; j < i; j++) // Iterate number from 2 to that number
                    {
                        if (i % j == 0) // If any number from 2 to that number divides the number then it is not prime number
                        {
                            prime = 0;
                            break;
                        }
                        else
                            prime = 1;
                    }
                    if (prime == 1) // If number is prime number then add it to prime number list
                    {
                        primeNumbers.Add(i);
                    }
                }            
            }
            else
                Console.WriteLine("Starting point should not greater than ending point");
            return primeNumbers;//Returning the prime numbers array list
        }
    }
}

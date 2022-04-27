using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class BubbleSort
    {
        public static int[] BubbleSorting(int[] numArray) //Creating a method with takes array of numbers as parameter
        {
            int temp;
            int length = numArray.Length; // Storing length of array
            for(int i = 0; i < length-1; i++) // For number of passes
            {
                for(int j = 0; j < length-1-i; j++) // For comparisons in each passes
                {
                    if(numArray[j] > numArray[j+1]) // If number is less than the previous number then swap this two numbers
                    {
                        temp = numArray[j];
                        numArray[j] = numArray[j+1];
                        numArray[j+1] = temp;
                    }
                }
            }
            return numArray; // returning a sorted array
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class InsertionSort
    {
        public static int[] insertionSorting(int[] numArray)//Creating a method with takes array of numbers as parameter
        {
            int noToInsert, j;
            //check that number want to insert is greater than or less than all the previous element and find it's right position to insert
            for(int i = 1; i < numArray.Length; i++) 
            {
                noToInsert = numArray[i];
                j = i - 1;
                while(j >= 0 && numArray[j] > noToInsert)
                {
                    numArray[j+1] = numArray[j];
                    j--;
                }
                numArray[j+1] = noToInsert;
            }
            return numArray; // returning sorted array
        }
    }
}

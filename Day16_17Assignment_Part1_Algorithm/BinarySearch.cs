using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class BinarySearch
    {       
        public static int searchWord(String[] wordsArray, String word) //Creating a method with takes array of words and word which want to search as parameter
        {
            Array.Sort(wordsArray); // Sorting words array
            int left = 0, right = wordsArray.Length - 1; 
            while (left <= right)
            {
                int middle = (left + (right - left) )/ 2; // Calculating middle position of array 
                int result = word.CompareTo(wordsArray[middle]);
                // Check if word is present at mid
                if (result == 0)
                    return middle;
                // If word greater, ignore left half
                if (result > 0)
                    left = middle + 1;
                // If word is smaller, ignore right half
                else
                    right = middle - 1;
            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class MergeSort
    {
        //Creating method to merge two sorted array
        public static void merge(int[] arr, int low, int mid, int high) //Creating a method with takes array of numbers ,low ,mid and high as parameter
        {
            int i, j, k;
            int n1 = mid - low + 1; // Define total no of values which going to be store in left part
            int n2 = high - mid; // Define total no of values which going to be store in right part
            int[] leftPart = new int[n1]; // Creating a left part array having n1 values in it
            int[] rightPart = new int[n2]; // Creating a right part array having n2 values in it
            for (i = 0; i < n1; i++)  // Storing values in left part till mid
            {
                leftPart[i] = arr[low + i];
            }
            for (j = 0; j < n2; j++) //Storing after mid values in right part 
            {
                rightPart[j] = arr[mid + 1 + j];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < n1 && j < n2) 
            {
                if (leftPart[i] <= rightPart[j])
                {
                    arr[k] = leftPart[i];
                    i++;
                }
                else
                {
                    arr[k] = rightPart[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = leftPart[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = rightPart[j];
                j++;
                k++;
            }
        }
        //Creating method to divide array in two parts and again call merge for this both parts to sort the values
        public static int[] mergeSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2; // Calculating mid
                mergeSort(arr, low, mid); // Call this method for left part again
                mergeSort(arr, mid + 1, high); // call this method for right part again
                merge(arr, low, mid, high); // Merge both part using merge method
            }
            return arr; // returning sorted array
        }
    }
}

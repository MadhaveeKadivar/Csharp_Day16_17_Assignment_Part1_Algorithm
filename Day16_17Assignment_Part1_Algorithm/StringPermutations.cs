using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class StringPermutations
    {
        //Using Iterative Method
        public static void PermutationsUsingIterative(string str)
        {
            int n = str.Length; //Storing lenth of given string
            int noOfPermutations = FindFactorial(n); //Calculate the possible number of permutation
            for (int i = 0; i < noOfPermutations; i++)
            {
                char[] chars = str.ToCharArray(); // Storing the string letter in character array
                int temp = i;
                // Iterate Loop to find one permutation
                for (int div = n; div >= 1; div--)
                {
                    int quotient = temp/div;
                    int remainder = temp%div;
                    Console.Write(chars[remainder]);
                    chars = chars.Where((val, idx) => idx != remainder).ToArray();
                    temp = quotient;
                }
                Console.WriteLine();
            }
        }
        //Using recursion Method 
        public static void PermutationsUsingRecursion(string s, string ans)
        {
            if(s.Length == 0) 
            {
                Console.WriteLine(ans);
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i]; // Get particular characater
                string left = s.Substring(0, i); // Storing left part from c of string
                string right = s.Substring(i + 1); //Storing right part from c of string
                string result = left + right; // Combine left part and right part
                PermutationsUsingRecursion(result, ans+c); // calling method inside method with combine left part and right part as parameter - Recursion
            }
        }
        //Creating a method to find factorial
        public static int FindFactorial(int n)
        {
            int fact = 1;
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
        }
    }
}


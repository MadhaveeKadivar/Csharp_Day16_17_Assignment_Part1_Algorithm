using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class AnagramDetection
    {
        public static bool Anagram(string s1,string s2)
        {
            char[] str1 = s1.ToLower().ToCharArray(); // Storing the string letter in character array
            char[] str2 = s2.ToLower().ToCharArray(); // Storing the string letter in character array
            Array.Sort(str1); // Sorting string 1 array
            Array.Sort(str2); // Sorting string 2 array
            if (str1.Length != str2.Length) //Checking that length of both string is equal or not
            { 
                return false; 
            }
            for (int i = 0; i<str1.Length; i++) // Comparing all the character one by one in both strings
            {
                if (str1[i] != str2[i]) 
                { 
                    return false; 
                }
            }
            return true;
        }
    }
}

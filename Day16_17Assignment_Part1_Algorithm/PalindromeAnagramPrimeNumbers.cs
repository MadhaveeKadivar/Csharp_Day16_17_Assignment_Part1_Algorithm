using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class PalindromeAnagramPrimeNumbers
    {
        public static ListDictionary Check(int start ,int end)
        {
            ArrayList primeNumbers = FindPrimeNumbers(start,end); // Calling method for finding prime numbers
            ArrayList palindromeNumbers = Palindrome(primeNumbers); //calling method for finding palindrome prime number
            ListDictionary anagramPairs = AnagramNumbers(palindromeNumbers); // callling method for finding anagram palindrome prime numbers
            return anagramPairs; 

        }
        public static ArrayList FindPrimeNumbers(int start, int end) // Creating a method to find all prime numbers between given range
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

        public static ArrayList Palindrome(ArrayList primeNumbers)
        {           
            ArrayList palindromeNumbers = new ArrayList(); // Creating a list to maintain all palindrome numbers
            // Check all prime numbers that palindrome numbers or not 
            foreach (int number in primeNumbers)
            {
                int rev = 0;
                int rem = 0;
                int num = number;
                while (num > 0)
                {
                    rem = num % 10;
                    rev = rev * 10 + rem;
                    num = num / 10;
                }
                if (rev == number)
                {
                    palindromeNumbers.Add(number); // if palindrome then add in palindrome numbers list
                }
            }
            return palindromeNumbers;
        }
        public static bool Anagram(string s1, string s2)
        {
            char[] str1 = s1.ToCharArray(); // Storing the string letter in character array
            char[] str2 = s2.ToCharArray(); // Storing the string letter in character array
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
        public static ListDictionary AnagramNumbers(ArrayList palindromNumbers)
        {
            ListDictionary myDict = new ListDictionary(); //Creating a list dictionary for maintaining all anagram palindrome prime numbers
            for (int i = 0; i < palindromNumbers.Count; i++)
            {
                for (int j = i+1; j < palindromNumbers.Count; j++)
                {
                    if (Anagram(palindromNumbers[i].ToString(), palindromNumbers[j].ToString())) 
                    {
                        myDict.Add(palindromNumbers[i], palindromNumbers[j]); // If two pairs are anagram then add it in list dictionary               
                    }
                }
            }
            return myDict; // return list dictionary
        }       
    }
}

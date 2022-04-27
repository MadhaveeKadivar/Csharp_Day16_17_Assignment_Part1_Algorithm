using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            int[] numbers, sortedArray;
            Console.WriteLine("******Day - 16/17 Algorithm Problems*****");
            Console.WriteLine("\nProblem - 1 : Find all string's permutations");
            Console.WriteLine("Problem - 2 : Binary Search of word in List");
            Console.WriteLine("Problem - 3 : Insertion Sort");
            Console.WriteLine("Problem - 4 : Bubble Sort");
            Console.WriteLine("Problem - 5 : Merge Sort");
            Console.WriteLine("Problem - 6 : Anagram Detection");
            Console.WriteLine("Problem - 7 : Find All Prime Numbers in Range");
            Console.WriteLine("Problem - 8 : Find All Prime Numbers in Range which are palindrome and anagram");
            Console.WriteLine("Problem - 10 : Number Guessing Game");
            Console.WriteLine("Problem - 12 : Customize Message Demonstration");
            Console.WriteLine("\nEnter your choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                //Problem 1 : String Permutation 
                case 1:
                    Console.WriteLine("\nEnter any string : ");
                    string s = Console.ReadLine(); // Storing 
                    Console.WriteLine($"\nAll the permutations of {s} using iterative method are : ");
                    StringPermutations.PermutationsUsingIterative(s);
                    Console.WriteLine($"\nAll the permutations of {s} using recusion method are : ");
                    StringPermutations.PermutationsUsingRecursion(s,"");
                    break;
                //Problem 2 : Binary search of word in list 
                case 2:
                    Console.WriteLine("\nHow many words you want to add : ");
                    int noOfWords = Convert.ToInt32(Console.ReadLine());
                    string[] words = new string[noOfWords];
                    Console.WriteLine("\nEnter words one by one : ");
                    for (int i = 0; i < noOfWords; i++)
                    {
                        words[i] = Console.ReadLine();
                    }
                    Console.WriteLine("\nWhich word you want to search : ");
                    string w = Console.ReadLine(); 
                    int pos = BinarySearch.searchWord(words,w);
                    if(pos == -1)
                    {
                        Console.WriteLine($"\n\"{w}\" word not found");
                    }
                    else
                        Console.WriteLine($"\n\"{w}\" word founded");
                    break;
                //Problem 3 : Insertion Sort
                case 3:
                    Console.WriteLine("\nHow many numbers you want to add : ");
                    count = Convert.ToInt32(Console.ReadLine());
                    numbers = new int[count];
                    Console.WriteLine("\nEnter numbers one by one : ");
                    for (int i = 0; i < count; i++)
                    {
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    sortedArray = InsertionSort.insertionSorting(numbers);
                    Console.WriteLine("\nElements in Ascending Order is : \n");
                    for (int i = 0; i < sortedArray.Length; i++)
                    {
                        Console.Write(numbers[i]+" ");
                    }
                    break;
                //Problem 4 : Bubble Sort
                case 4:
                    Console.WriteLine("\nHow many numbers you want to add : ");
                    count = Convert.ToInt32(Console.ReadLine());
                    numbers = new int[count];
                    Console.WriteLine("\nEnter numbers one by one : ");
                    for (int i = 0; i < count; i++)
                    {
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    sortedArray = BubbleSort.BubbleSorting(numbers);
                    Console.WriteLine("\nElements in Ascending Order is : \n");
                    for (int i = 0; i < sortedArray.Length; i++)
                    {
                        Console.Write(numbers[i]+" ");
                    }
                    break;
                //Problem 5 : Merge Sort
                case 5:
                    Console.WriteLine("\nHow many numbers you want to add : ");
                    count = Convert.ToInt32(Console.ReadLine());
                    numbers = new int[count];
                    Console.WriteLine("\nEnter numbers one by one : ");
                    for (int i = 0; i < count; i++)
                    {
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    sortedArray = MergeSort.mergeSort(numbers,0,count-1);
                    Console.WriteLine("\nElements in Ascending Order is : \n");
                    for (int i = 0; i < sortedArray.Length; i++)
                    {
                        Console.Write(numbers[i]+" ");
                    }
                    break;
                //Problem - 6 Anagram Detection
                case 6:
                    Console.WriteLine("\nEnter any string : ");
                    string str1 = Console.ReadLine();
                    Console.WriteLine("\nEnter any string : ");
                    string str2 = Console.ReadLine();
                    bool result = AnagramDetection.Anagram(str1,str2);
                    if(result)
                    {
                        Console.WriteLine($"\n\"{str1}\" and \"{str2}\" are Anagram Strings");
                    }
                    else
                        Console.WriteLine($"\n\"{str1}\" and \"{str2}\" are not Anagram Strings");
                    break;
                // Problem - 7 Find all Prime Numbers Between Given Range
                case 7:
                    Console.WriteLine("Enter starting point : ");
                    int start = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Ending Point : ");
                    int end = Convert.ToInt32(Console.ReadLine());
                    ArrayList primeNumbers = PrimeNumbersInRange.FindPrimeNumbers(start, end);
                    Console.WriteLine($"\nAll the prime numbers between {start} and {end} are :");
                    foreach(int prime in primeNumbers)
                    {
                        Console.WriteLine(prime);
                    }
                    break;
                // Problem - 8 Find all Prime Numbers Between Given Range which are palindrome and 
                case 8:
                    Console.WriteLine("Enter starting point : ");
                    int sp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Ending Point : ");
                    int ep = Convert.ToInt32(Console.ReadLine());
                    ListDictionary anagramPairs = PalindromeAnagramPrimeNumbers.Check(sp, ep);
                    if (anagramPairs == null)
                    {
                        Console.WriteLine($"There is no prime numbers between {sp} and {ep} which are palindrome and anagram");
                    }
                    else
                    {
                        foreach (DictionaryEntry row in anagramPairs)
                        {
                            Console.WriteLine($"({row.Key},{row.Value}) are anagram palinedrom prime numbers");
                        }
                    }
                    break;
                // problem - 10 Number Guessing Game
                case 10:
                    Console.WriteLine("Enter any number : ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    double range = Math.Pow(2, n);
                    Console.WriteLine($"\nGuess any one number between 0 to {range-1}");
                    int number = NumberGuessingGame.GuessTheNumber(range);
                    if (number != 0)
                        Console.WriteLine($"\nThe number you thought was : {number}");
                    else
                        Console.WriteLine($"\nThe number was not found");
                    break;
                // Problem - 12 Customize Message Demonstration
                case 12:
                    CustomizeMessageDemonstration.FirstName();
                    CustomizeMessageDemonstration.LastName();
                    CustomizeMessageDemonstration.MobileNumber();
                    CustomizeMessageDemonstration.Message();
                    CustomizeMessageDemonstration.UpdateDetails();
                    CustomizeMessageDemonstration.Message();
                    break;
            }
            Console.ReadLine();
        }
    }
}

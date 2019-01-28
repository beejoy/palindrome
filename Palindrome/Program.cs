﻿using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = String.Empty;

            do
            {
                Console.Write("Enter a word or 'Q' to quit: ");
                inputWord = Console.ReadLine().ToLower();

                if (inputWord[0] != 'q')
                {
                    if (IsPalindrome(inputWord))
                    {
                        Console.WriteLine("The word is a palindrome word.");
                    }
                    else
                    {
                        Console.WriteLine("The word is not a palindrome word.");
                    }
                    Console.WriteLine();
                }

            } while (inputWord[0] != 'q');
        }

        private static bool IsPalindrome(string input)
        {
            string word = string.Empty;

            // remove whitespaces
            word = input.Replace(" ", "").Trim();

            // reverse the input string
            char[] temp = word.ToCharArray();
            Array.Reverse(temp);
            string reversedWord = new string(temp);

            return (word.Equals(reversedWord));
        }
    }
}

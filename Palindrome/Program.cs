using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = String.Empty;
            bool quitApp = false;
            do
            {
                Console.Write("Enter a word or 'Q' to quit: ");
                inputWord = Console.ReadLine().ToLower();

                //quitApp = inputWord.Equals("quit") ? true : false;

                if ((inputWord.Length == 1 && inputWord.Equals("q")) || inputWord.Equals("quit"))
                    quitApp = true;

                if (!quitApp)
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

            } while (!quitApp);
        }

        private static bool IsPalindrome(string input)
        {
            string word = string.Empty;

            // Use regular expression to remove characters other and A-Z, 1-9.
            String pattern = @"[^a-z1-9]";
            Regex rgx = new Regex(pattern);
            word=rgx.Replace(input, "");

            // reverse the input string
            char[] temp = word.ToCharArray();
            Array.Reverse(temp);
            string reversedWord = new string(temp);

            return (word.Equals(reversedWord));
        }
    }
}

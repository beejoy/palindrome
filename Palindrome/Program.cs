using System;

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

                // remove extraneous characters
                inputWord = inputWord.Replace(" ", "").Trim();

                // reverse the input string
                char[] temp = inputWord.ToCharArray();
                Array.Reverse(temp);
                string reverseWord = new string(temp);

                if (inputWord != "q")
                {
                    if (inputWord.Equals(reverseWord))
                    {
                        Console.WriteLine("The word is a palindrome word.");
                    }
                    else
                    {
                        Console.WriteLine("The word is not a palindrome word.");
                    }
                    Console.WriteLine();
                }

            } while (inputWord != "q");
        }
    }
}

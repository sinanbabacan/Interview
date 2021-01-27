using System;

namespace Interview.PalindromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check("Tact Coa "));

            // For example, “code” -> False, “aab” -> True, “carerac” -> True.

            Console.WriteLine(Check("code"));
            Console.WriteLine(Check("codec"));
            Console.WriteLine(Check("aab "));
            Console.WriteLine(Check("carerac"));
            Console.WriteLine(Check("arcerca"));
        }


        private static bool Check(string input)
        {
            int[] asciiChars = new int[128];

            int characterCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = Char.ToLower(input[i]);

                if (Char.IsLetter(c))
                {
                    asciiChars[c]++;
                    characterCount++;
                }
            }

            int sum = 0;

            for (int i = 0; i < asciiChars.Length; i++)
            {
                sum += asciiChars[i] % 2;

                if (sum > 1)
                {
                    return false;
                }
            }

            return characterCount % 2 == sum % 2;
        }
    }
}

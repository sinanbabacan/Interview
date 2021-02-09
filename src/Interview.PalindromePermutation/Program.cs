using System;

namespace Interview.PalindromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(CanPermutePalindrome("Tact Coa "));
            Console.WriteLine(CanPermutePalindrome("AaBb//a"));

            // For example, “code” -> False, “aab” -> True, “carerac” -> True.

            Console.WriteLine(CanPermutePalindrome("code"));
            Console.WriteLine(CanPermutePalindrome("codec"));
            Console.WriteLine(CanPermutePalindrome("aab "));
            Console.WriteLine(CanPermutePalindrome("carerac"));
            Console.WriteLine(CanPermutePalindrome("arcerca"));
        }


        private static bool CanPermutePalindrome(string s)
        {
            int[] chars = new int[Char.MaxValue];

            int characterCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                chars[s[i]]++;
                characterCount++;
            }

            int sum = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                sum += chars[i] % 2;
            }

            return sum <= 1;
        }
    }
}

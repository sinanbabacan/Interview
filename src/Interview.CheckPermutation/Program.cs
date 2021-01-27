using System;

namespace Interview.CheckPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check("god","dog"));
            Console.WriteLine(Check("God","Dog"));
            Console.WriteLine(Check("pen","pencil"));
            Console.WriteLine(Check("sinan", "nanis"));

        }

        private static bool Check(string input1, string input2)
        {
            if (input1.Length != input2.Length)
            {
                return false;
            }

            int[] characterCounter = new int[Char.MaxValue];

            foreach (Char item in input1)
            {
                characterCounter[item]++;
            }

            foreach (Char item in input2)
            {
                characterCounter[item]--;

                if (characterCounter[item] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

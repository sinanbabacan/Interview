using System;

namespace Interview.IsUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsUnique("sinan"));
            Console.WriteLine(IsUnique("miray"));
            Console.WriteLine(IsUnique("öğretmen"));
            Console.WriteLine(IsUnique("öğretim"));
            Console.WriteLine(IsUnique("derya"));
        }

        private static bool IsUnique(string input)
        {
            bool[] characters = new bool[Char.MaxValue];

            foreach (Char item in input)
            {
                if (characters[item])
                {
                    return false;
                }

                characters[item] = true;
            }

            return true;
        }
    }
}

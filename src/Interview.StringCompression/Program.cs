using System;
using System.Text;

namespace Interview.StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Compress("aabcccccaaazzzzzz"));
            Console.WriteLine(Compress("aabccccdefgghijzz"));
        }

        private static string Compress(string input)
        {
            var stringBuilder = new StringBuilder();

            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                counter++;

                if (i + 1 == input.Length || input[i] != input[i + 1])
                {
                    stringBuilder.Append(input[i]);
                    stringBuilder.Append(counter);

                    counter = 0;
                }
            }

            return stringBuilder.ToString();
        }
    }
}

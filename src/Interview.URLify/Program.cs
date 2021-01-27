using System;

namespace Interview.URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vs = Manupulate("Mr John Smith        ".ToCharArray(), 13);

            Console.WriteLine(vs);
        }

        private static char[] Manupulate(Char[] input, int length)
        {
            int whiteSpaceCount = 0;

            for(int i=0; i< length; i++)
            {
                if (Char.IsWhiteSpace(input[i]))
                {
                    whiteSpaceCount++;
                }
            }

            int c = length + whiteSpaceCount * 2;

            int index = length - 1;

            for (int i = c-1; i >= 0; i--)
            {
                if (Char.IsWhiteSpace(input[index]))
                {
                    input[i] = '0';
                    input[--i] = '2';
                    input[--i] = '%';
                }
                else
                {
                    input[i] = input[index];
                }

                index--;
            }

            return input;
        }
    }
}

using System;

namespace Interview.OneWay
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             
            pale, ple -> true
            pales, pale -> true
            pale, bale -> true
            pale, bake -> false 
             
             */

            //Console.WriteLine(Check("pale", "ple"));
            Console.WriteLine(Check("pales", "pale"));
            Console.WriteLine(Check("palesi", "pale"));
            Console.WriteLine(Check("pale", "bale"));
            Console.WriteLine(Check("pale", "bake"));
            Console.WriteLine(Check("pale", "pale"));

        }

        private static bool Check(string input, string modifiedInput)
        {
            if (input.Length == modifiedInput.Length)
            {
                bool updated = false;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != modifiedInput[i])
                    {
                        if (updated)
                        {
                            return false;
                        }

                        updated = true;
                    }
                }
            }
            else if(Math.Abs(input.Length - modifiedInput.Length) == 1)
            {
                int i = 0;
                int j = 0;
                bool updated = false;

                do
                {
                    if (modifiedInput[j] != input[i])
                    {
                        if (updated)
                        {
                            return false;
                        }

                        updated = true;
                    }
                    else
                    {
                        j++;
                    }

                    i++;

                } while (j < modifiedInput.Length);
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}

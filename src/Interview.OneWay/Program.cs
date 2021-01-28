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

            Console.WriteLine(Check("pale", "ple"));
            Console.WriteLine(Check("pales", "pale"));
            Console.WriteLine(Check("palesi", "pale"));
            Console.WriteLine(Check("pale", "bale"));
            Console.WriteLine(Check("pale", "bake"));
            Console.WriteLine(Check("pale", "pale"));
            Console.WriteLine(Check("pale", "apale"));
            Console.WriteLine(Check("pale", "palle"));
            Console.WriteLine(Check("pale", "apales"));

        }

        private static bool CheckInsertOrRemove(string s1, string s2)
        {
            int i = 0;
            int j = 0;
            bool updated = false;

            do
            {
                if (s2[j] != s1[i])
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

            } while (j < s2.Length);

            return true;
        }

        private static bool Check(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                bool updated = false;

                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        if (updated)
                        {
                            return false;
                        }

                        updated = true;
                    }
                }
            }
            else if (Math.Abs(s1.Length - s2.Length) == 1)
            {
                if (s1.Length > s2.Length)
                {
                    CheckInsertOrRemove(s1, s2);
                }
                else
                {
                    CheckInsertOrRemove(s2, s1);
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}

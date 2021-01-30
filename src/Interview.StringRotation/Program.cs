using System;
using System.Linq;

namespace Interview.StringRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check("erbottlewat", "waterbottle"));
        }

        private static bool Check(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();

            for (int i = 0; i < arr2.Length; i++)
            {
                if (Enumerable.SequenceEqual(arr1, arr2))
                {
                    return true;
                }

                char temp = arr2[0];

                for (int j = 0; j < arr2.Length - 1; j++)
                {
                    arr2[j] = arr2[j + 1];
                }

                arr2[arr2.Length - 1] = temp;
            }

            return false;
        }
    }
}

using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string s = Console.ReadLine();
            Console.Write("Output: ");
            Console.WriteLine(Reverse(s));
        }

        public static string Reverse(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return s;
            }

            char[] stringChars = s.ToCharArray();
            Array.Reverse(stringChars);
            return new string(stringChars);
        }
    }
}
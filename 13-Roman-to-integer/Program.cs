using System;

namespace _13_Roman_to_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "LVIII";
            Console.WriteLine(RomanToInt(value));

        }
        public static int RomanToInt(string s)
        {
            int counter = 0;

            for(int i=s.Length-1; i >=0; i--)
            {
                if (s[i] == 'I')
                {
                    counter = counter + 1;
                }
                else if (s[i] == 'V')
                {
                    counter = counter + 5;
                }
                else if (s[i] == 'L')
                {
                    counter = counter + 50;
                }
            }

            return counter;
        }
    }
}

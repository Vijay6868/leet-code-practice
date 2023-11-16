using System;
using System.Collections.Generic;
namespace _13_Roman_to_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "LVIII";
            Console.WriteLine(RomanToInt(value));
            value = "IV";
            Console.WriteLine(RomanToInt(value));
        }
        public static int RomanToInt(string s)
        {
            int num = 0;
            int counter = 0;

            Dictionary <char, int> romanNumerals =
                new Dictionary<char, int>
                {
                    {'M',1000 },
                    {'D',500 },
                    {'C',100 },
                    {'L',50 },
                    {'X',10 },
                    {'V',5 },
                    {'I',1 }
                };

            for(int i=s.Length-1; i >=0; i--)
            {
               if(counter<= romanNumerals[s[i]])
                {
                    num += romanNumerals[s[i]];
                }
               else if (counter > romanNumerals[s[i]])
                {
                    num -= romanNumerals[s[i]];
                }
                counter = romanNumerals[s[i]];
            }

            return num;
        }
    }
}

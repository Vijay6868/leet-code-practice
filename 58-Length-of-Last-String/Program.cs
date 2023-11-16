using System;

namespace _58_Length_of_Last_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            Console.WriteLine(LengthOfLastWord(s));
        }
        public static int LengthOfLastWord(string s)
        {
            int length = 0;

            for(int i = s.Length - 1; i >= 0; i--)
            {
                if(s[i]==' ' && length>0)
                {
                    break;
                }
                else if(s[i]!=' ')
                {
                    length += 1;
                }
            }
            return length;
        }
    }

}

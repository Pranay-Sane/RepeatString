using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatString("Hello", -1));
            Console.WriteLine(RepeatString("Hello", 4));
        }

        static string RepeatString(string str, int num)
        {
            string result = "";
            if(num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    result += str;
                    if (i < num - 1) result += " ";
                }
            }
            return result;
        }
    }
}

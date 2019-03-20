using System;

namespace Solution2
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
            if (num <= 0) return "";
            if (num == 1) return str;
            return str + " " + RepeatString(str, num - 1);
        }
    }
}

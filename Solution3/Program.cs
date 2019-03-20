using System;
using System.Linq;

namespace Solution3
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
            return String.Join(" ", Enumerable.Repeat(str, num));
        }
    }
}

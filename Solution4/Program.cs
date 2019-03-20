using System;
using System.Text;

namespace Solution4
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
            var sb = new StringBuilder(((str.Length + 1) * num) - 1);
            sb.Insert(0, str + " ", num - 1);
            sb.Append(str);
            return sb.ToString();
        }
    }
}

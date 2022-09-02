using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

namespace Regular_expr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст\n");
            string s = Console.ReadLine();
            Regex regex = new Regex(@"8[\(\s-]*[0-9]{3}[)\s-][0-9]{3}-[0-9]{2}-[0-9]{2}");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}

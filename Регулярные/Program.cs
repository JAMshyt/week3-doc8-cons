using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Регулярные
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.Write("Введите текс: ");
            String s =Console.ReadLine();
            Regex r = new Regex(@"(\d+,\d+|\d+)([eE](-|)\d+|)");
            foreach (Match it in r.Matches(s))
            {
                if (it.Success)
                {
                    sum += double.Parse(it.Value);
                }
            }
            Console.WriteLine("Сумма: "+sum);
        }
    }
}

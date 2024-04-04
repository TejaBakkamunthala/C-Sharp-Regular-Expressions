using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionss
{
    internal class Regexs1
    {

        public void Regex1()
        {

            Regex regex = new Regex("^[A-Za-z@0-9]*$");

            Console.WriteLine("Enter a character ");
            string inputVlaue = Console.ReadLine();
            bool result = regex.IsMatch(inputVlaue);
            Console.WriteLine(result);
        }
    }
}

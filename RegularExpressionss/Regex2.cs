using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionss
{
    internal class Regex2
    {

        public void Regexx2()
        {
          
            Regex regex = new Regex("^[0-9]*[A-Za-z]{3,}[A-Za-z0-9]*$");

            Console.WriteLine("Enter a Character ");
            string inputValue = Console.ReadLine();

            if (regex.IsMatch(inputValue))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("In Valid");
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionss
{
    internal class FirstUpperNextLower
    {


        public void FirstUpperNextLower1() {
            String str = "Tej7abcsd";

            //  Regex regex = new Regex("^[A-Z]{1}[a-z}{1,}[0-9}{1}$");
              Regex regex = new Regex("^[A-Z][a-z]*[0-9][a-z]*$");


            if (regex.IsMatch(str))
            {
                Console.WriteLine("Valid");
            }
            else
            {

                Console.WriteLine("Not a Valid ");
            }



        }

    }
}

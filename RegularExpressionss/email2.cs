using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionss
{
    internal class email2
    {

        public void email22()
        {
            //Regex r1 = new Regex("^[A-Za-z0-9]+[.][A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,4}$");
            Regex r1 = new Regex("^[A-Za-z0-9]+[.#$][A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,4}[.][A-Za-z]{2,3}$");

            String emailId = "abc1#xyz1@example.com" +
                ".in";
            if (r1.IsMatch(emailId))
            {
                Console.WriteLine("Email id is valid");
            }
            else
            {
                Console.WriteLine("Email Id is not valid");
            }


        }
    }
}

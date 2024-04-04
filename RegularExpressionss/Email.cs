using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionss
{
    internal class Email
    {

        public void email1()
        {
            Regex email = new Regex("^[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,3}$");

            Console.WriteLine("Enter a email id ");

            string email1=Console.ReadLine();
            if (email.IsMatch(email1)){

                Console.WriteLine("Email Is Valid");
            }
            else
            {
                Console.WriteLine("Email is Not Valid");
            }
        }
    }
}

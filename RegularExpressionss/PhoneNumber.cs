using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionss
{
    internal class PhoneNumber
    {


        public void PhoneNumber1()
        {

            string phoneNumber = "8976541233";

            Regex regex2 = new Regex("^[8 9]{1}[0-9]{9}$");

           if(regex2.IsMatch(phoneNumber))
            {
                Console.WriteLine("Phone Number Is Valid ");
            }
           else
            {
                Console.WriteLine("Phone Number is Not valid ");

            }

        
        }
    }
}

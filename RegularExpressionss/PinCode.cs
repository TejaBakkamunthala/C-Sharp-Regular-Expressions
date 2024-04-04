using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionss
{
    internal class PinCode
    {

        public void PinCode1()
        {
            // Regex regex3 = new Regex("^[1-9]{1}[0-9]{5}$");

            Regex regex3 = new Regex("^[1-9]{1,1}[0-9]{2,2}[ ]?[0-9]{3,3}");
            Console.WriteLine("Enter a pincode ");
            string num = "523274";

            //String num = Console.ReadLine();
            if (regex3.IsMatch(num)){

                Console.WriteLine("PinCode is valid");
            }
            else
            {
                Console.WriteLine("Pin Code is  not valid ");
            }
        }
    }
}

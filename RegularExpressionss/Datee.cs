using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionss
{
    public class Datee
    {

        public void Date1()
        {
            string dateee = "2001-12-04";

            // Regex re = new Regex("^[0-9]{4}[-][0-9]{2}[-][0-9]{2}$");
            Regex re = new Regex("^\\d{4}[-]\\d{2}[-]\\d{2}$");

            if (re.IsMatch(dateee))
            {

                Console.WriteLine("Valid");
            }
            else
            {
                {
                    Console.WriteLine("InValid");
                }
            }

        }
    }
}

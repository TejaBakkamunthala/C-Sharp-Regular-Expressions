using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionss
{
    internal class CharacterMatch
    {

        public void CharacterMatch1()
        {
           // String str = "Teja";
           String str = "Sunil";

            // Regex re = new Regex("^[s S t T]{1}[A-Z a-z]+$");
            Regex re = new Regex("^[s S t T]{1}unil$");
            if(re.IsMatch(str))
            {
                Console.WriteLine("First Character Is Match ");
            }

            else
            {
                Console.WriteLine("First Character is not match ");
            }
        }
    }
}

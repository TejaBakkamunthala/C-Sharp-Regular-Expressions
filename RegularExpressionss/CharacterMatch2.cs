using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionss
{
    public class CharacterMatch2
    {
        public  void CharacterMatch22() {

            String[] strArr = { "Teja", "Meja", "Keja", "Sunil", "Tunil", "Kunil","Seja"};

            Regex re = new Regex("^[A-Z a-z][eja]*$");

            bool flag = true;
            for(int i=0;i<strArr.Length;i++)
            {
                if (re.IsMatch(strArr[i]))
                {
                    Console.WriteLine(strArr[i]+" ");
                    flag = false;
                }

            }
            if (flag)
            {
                Console.WriteLine("Character DoesNot MAatch");
            }


        }
    }
}

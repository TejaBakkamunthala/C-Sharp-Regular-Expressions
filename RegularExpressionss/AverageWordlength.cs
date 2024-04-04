using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionss
{
    public  class AverageWordlength
    {

        public void  AverageWordlength1() {

            string input = "HELLO WORLD hello world";

            string[] ARR = Regex.Split(input,@"[\W+]");

            int total = 0;

            foreach(var arr1 in ARR) { 
             total=total+arr1.Length;
            }

            Console.WriteLine(total);

            int avg=total/ARR.Length;
            Console.WriteLine(avg);














        }


    }
}

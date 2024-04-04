using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionss
{
    public class WordOccurence
    {

        public void WordOccurence1()
        {

            String[] strArr = { "Teja", "Teja", "Sunil", "Sunil", "Jayanath", "Jaynath" ,"Teja123","123","456"};

            Regex re = new Regex("^[A-Z a-z]+$");

            for (int i = 0; i < strArr.Length; i++)
            {
                
                if (re.IsMatch(strArr[i]))
                {
                    int count = 0;
                    for (int j = 0; j < strArr.Length; j++)
                    {
                       
                        for (int k = j + 1; k < strArr.Length ; k++)
                        {

                            if (strArr[i].Equals(strArr[k]))
                            {
                                count++;
                            }
                        }
                    }

                        Console.WriteLine(strArr[i] + " " + count);
                    
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionss
{
    public class WordOcuurences2
    {
        //  String[] strArr = { "Teja", "Teja", "Sunil", "Sunil", "Jayanath", "Jaynath", "Teja123", "123", "456" };

        public void WordOccurence2()
        {

            string input = "Teja Sunil Jayanth Teja Sunil Jayanth 123 123";

            string[] words = Regex.Split(input.ToLower(), @"[\W]");

            Dictionary<string, int> di = new Dictionary<string, int>();

            foreach(string word in words)
            {
                di[word] = di.ContainsKey(word) ? di[word]+1 : 1;
            }
            foreach (KeyValuePair<string, int> kvp in di)

            {

                Console.WriteLine(kvp.Key+"  :  "+kvp.Value);
            }

            }
        }



    
}

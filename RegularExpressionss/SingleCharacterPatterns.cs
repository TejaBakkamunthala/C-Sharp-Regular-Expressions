using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace RegularExpressionss
{
    public class SingleCharacterPatterns
    {

        public void SingleCharacterPatterns1()
        {

            string input = "this is a great test teja aaa";
            String pattern = "aa";


            MatchCollection matches = Regex.Matches(input, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine("Index: " + match.Index);
                count++;
            }
            Console.WriteLine("Occurences Of a " + count);

            Console.WriteLine();

        }



        public void SingleCharacterPatterns2()
        {
            Console.WriteLine("capital A");
            string input = "this is a great test teja";
            String pattern = "(?i)A";


            MatchCollection matches = Regex.Matches(input, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine("Index: " + match.Index);
                count++;
            }
            Console.WriteLine("Occurences Of a " + count);
            Console.WriteLine();

        }


        public void SingleCharacterPatterns3()
        {
           
            string input = "this is the biggest test teji big bi";
            String pattern = "big";


            MatchCollection matches = Regex.Matches(input, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine("Index: " + match.Value+" " + match.Index);
                count++;
            }
            Console.WriteLine("Occurences Of a " + count);
            Console.WriteLine();

        }


        public void SingleCharacterPatterns4()
        {

            string input = "this is the biggest test teji big bi";
            String pattern = "[big]";
           // string pattern = "b|i|g";


            MatchCollection matches = Regex.Matches(input, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine("Index: " + match.Value + " " + match.Index);
                count++;
            }
            Console.WriteLine("Occurences Of a " + count);
            Console.WriteLine();

        }

        public void SingleCharacterPatterns5()
        {

            string input = "this is the biggest test teji big bi";
            String pattern = "[^big$]";
            // string pattern = "b|i|g";


            MatchCollection matches = Regex.Matches(input, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine("Index: " + match.Value + " " + match.Index);
                count++;
            }
            Console.WriteLine("Occurences Of a " + count);
            Console.WriteLine();

        }

        public void SingleCharacterPatterns6()
        {

            string input = "carpet a  car aa";
            String pattern = "car|carpet";


            MatchCollection matches = Regex.Matches(input, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine("Index: " + match.Value + " " + match.Index);
                count++;
            }
            Console.WriteLine("Occurences Of a " + count);
            Console.WriteLine();

        }


        public void SingleCharacterPatterns7()
        {

            string input = " is a carpet a  car aa car  aa carpet ";
             String pattern = @"(\bcar\b|\bcarpet\b)";
            //OR
            //string pattern = "car(pet)?";

            MatchCollection matches = Regex.Matches(input, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine("Index: " + match.Value + " " + match.Index);
                count++;
            }
            Console.WriteLine("Occurences Of a " + count);
            Console.WriteLine();

        }



        public void DotCharacterr6()
        {
            //dot Character accepts anything except new line 
            string input = "this. is. the  biggest test teji big bi";
            String pattern = ".";
            // string pattern = "b|i|g";


            MatchCollection matches = Regex.Matches(input, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine("Index: " + match.Value + " " + match.Index);
                count++;
            }
            Console.WriteLine("Occurences Of a " + count);
            Console.WriteLine();

        }


        public void DotCharacterrAccepts7()
        {
            //dot Character accepts anything except new line 
            string input = "this. is. the.  biggest test teji big bi";
            String pattern = "\\.";
            // string pattern = "b|i|g";


            MatchCollection matches = Regex.Matches(input, pattern);
             
            int count = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine("Index: " + match.Value + " " + match.Index);
                count++;
            }
            Console.WriteLine("Occurences Of a " + count);
            Console.WriteLine();

        }

        //ANCHORS

        public void Anchortags1() {

            string input = "logs log a catlog log";
            //  string pattern="log";
            string pattern = "\\blog\\b";

          MatchCollection matches=  Regex.Matches(input, pattern);
            int count = 0;
            foreach(Match match in matches)
            {
                Console.WriteLine("Index:  "+match.Index+" "+match.Value);
                count++;
            }
            Console.WriteLine(pattern +" Count is   "+count);

        }

        //Character Classe

        public void CharaterClass1()
        {

            String str = "1234";
          
            Regex regex = new Regex("^[0-9]{4}$");
            if (regex.IsMatch(str))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("In valid");
            }
        }



    }
}


   
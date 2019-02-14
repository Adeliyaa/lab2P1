using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2P1
{
    
    class Program
    {
        public static bool Palindromtest(string s)
            //function which will test the word for polindrom 
        {
            for (int i = 0; i < s.Length / 2; i++)

                if (s[i] != s[s.Length - i - 1])
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            string s; 
            // variable s with string type
            s = Console.ReadLine();
            //read the variable s 
            if(Palindromtest(s)) 
                //the function Polindrome test will return true or false 
            {
                Console.WriteLine("this line is polindrome!");
                //if the test is true , then assert that the word is polindrome 
            
            } else
            {
                Console.WriteLine("this line isn't polindrome! ");
                //if the test is false , then the word is not polindrome 

            }


        }
    }
}

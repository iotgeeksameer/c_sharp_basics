using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GettingSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Last night I dreamt of San Pedro"; 
            Console.WriteLine(str);
            string substr = str.Substring(24); //24 is the char location
            Console.WriteLine(substr);
            Console.ReadLine();

        } 
        
     }

}


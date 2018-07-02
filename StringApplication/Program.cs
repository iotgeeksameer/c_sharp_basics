using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringApplication 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            //from string literal and string concatenation 
            string fname, lname; 
            fname = "sameer"; 
            lname = "mishra"; 
            string fullname = fname + lname; 
            Console.WriteLine("Full Name: {0}", fullname); 
            //by using string constructor 
            char[] letters = { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);
            //methods returning string 
            string[] sarray = { "sameer", "From", "geek", "sameer" }; 
            string message = String.Join(" ", sarray); 
            Console.WriteLine("Message: {0}", message); 
            //formatting method to convert a value 
            DateTime waiting = new DateTime(2013, 10, 10, 7, 58,40); 
            string chat = String.Format("Message sent at {0:D} on {0:t}", waiting);
            Console.WriteLine("Message: {0}", chat); 
            Console.ReadKey() ; 
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure
{
    struct Books 
    { 
        public string title; 
        public string author; 
        public string subject; 
        public int book_id; 
    };
    class Program
    {
        static void Main(string[] args)
        {
            Books Book1; /* Declare Book1 of type Book */ 
            Books Book2; /* Declare Book2 of type Book */ 
            /* book 1 specification */ 
            Book1.title = "C# Programming"; 
            Book1.author = "sameer"; 
            Book1.subject = "C# Programming Tutorial"; 
            Book1.book_id = 6495407; 
            /* book 2 specification */ 
            Book2.title = "iot Designs"; 
            Book2.author = "sameer"; 
            Book2.subject = "iot system designs"; 
            Book2.book_id = 6495700; 
            /* print Book1 info */ 
            Console.WriteLine("Book 1 title : {0}", Book1.title); 
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject); 
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id); 
            /* print Book2 info */ 
            Console.WriteLine("Book 2 title : {0}", Book2.title); 
            Console.WriteLine("Book 2 author : {0}", Book2.author); 
            Console.WriteLine("Book 2 subject : {0}", Book2.subject); 
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id); 
            Console.ReadKey();
        }
    }
}
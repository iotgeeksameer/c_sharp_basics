using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

   namespace ConsoleApplication5
{
    class Program
    {
        public static Double Veg()
        {
            Double bill = 0.0;
            string v_choice;
            Console.WriteLine("\n what would you like to have?\n \n");
            Console.WriteLine("\t press \n a for north indian thali \n b for south indian thali \n c for standared indian thali \n  d  for chineese");
            v_choice=Console.ReadLine();
            switch (v_choice.ToUpper())
            {
                case "A":
                    {
                        Console.WriteLine("\n \n you have choosen north indian thali please pay rs 150 for it\n");
                        bill = bill + 150;
                        break;
                    }
                case "B":
                    {
                        Console.WriteLine("\nyou have choosen  south indian thali  please pay rs 180 for it\n");
                        bill = bill + 180;
                        break;
                    }
                case "C":
                    {
                        Console.WriteLine("\nyou have choosen standared indian thali  please pay rs 200 for it\n");
                        bill = bill + 200;
                        break;
                    }
                case "D":
                    {
                        Console.WriteLine("\nyou have choosen chineese please pay rs 120 for it\n");
                        bill = bill + 120;
                        break;
                    }
                Default:
                    {
                        Console.WriteLine("\nwrong choice\n");
                        break;
                    }
            }
            return bill;
        }
        public static Double Nonveg()
        {
             string Nv_choice;
             Double bill=0.0;
            Console.WriteLine("\n what would you like to have?\n");
            Console.WriteLine("\n\t press \n a for  chicken thali \n b for mutton thali \n c for standared non veg thali \n  d  for chineese non veg\n");
            Nv_choice=Console.ReadLine();
            switch (Nv_choice.ToUpper())
            {
                case "A":
                    {
                        Console.WriteLine("\n you have choosen chicken thali please pay rs 150 for it \n");
                        bill = bill + 150;
                        break;
                    }
                case "B":
                    {
                        Console.WriteLine("\n you have choosen  mutton thali  please pay rs 180 for it \n ");
                        bill = bill + 180;
                        break;
                    }
                case "C":
                    {
                        Console.WriteLine("\n you have choosen standared non veg thali  please pay rs 200 for it \n");
                        bill = bill + 200;
                        break;
                    }
                case "D":
                    {
                        Console.WriteLine("\n you have choosen chineese please pay rs 120 for it \n ");
                        bill = bill + 120;
                        break;
                    }
                Default:
                    {
                        Console.WriteLine("\n wrong choice \n ");
                        break;
                    }
            }
            return bill;
        }
        static void Main(string[] args)
        {
            int choice;
            string cont;
            Double total_bill = 0.0;
            Console.WriteLine(" \t WELCOME TO OUR CANTEEN \n");
            start:
            Console.WriteLine("\nPRESS 1 for VEGITERIAN \n\t AND \n 2 for Non-VEGITERIAN\n");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("\nyou have choosen VEGITERIAN \n");
                Double v_bill = Veg();
                total_bill = total_bill + v_bill;
               
            }
            else if (choice == 2)
            {
                Console.WriteLine("\n you have choosen non veg\n");
                Double Nv_bill = Nonveg();
                total_bill = total_bill + Nv_bill;
            }
            else
            {
                Console.WriteLine(" \n \t entered wrong choice");
            }
            Console.WriteLine("do you want to continue ? \n type yes or no");
            cont = Console.ReadLine();
            switch (cont.ToUpper())
            {
                case "YES":
                    goto start;

                case "NO":

                    break;
                default:
                    Console.WriteLine("you have entered wrong choice");
                    break;
            }
            Console.WriteLine(" \n your total bill is {0} \n ", total_bill);
            Console.WriteLine("\n \n \t thanks for shoping with us visit again ");
            Console.ReadKey();
        }

      
    }
    

}

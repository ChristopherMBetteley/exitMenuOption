using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exitMenuOption
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string userMenuInput;
            int startingBalance;
            int currentBalance;
            int newIncome;

            

            Console.WriteLine("Welcome" + "\n");
            Console.WriteLine("\a");
            
            
            //runs the main program
            while (true)
            {
                Console.WriteLine("\n"+"What is your STARTING balance?");
                startingBalance = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your NEW income?");
                newIncome = int.Parse(Console.ReadLine());

                currentBalance = newIncome + startingBalance;

                Console.WriteLine("\n" + "Your starting balance is............." + startingBalance);
                Console.WriteLine("Your pay for cleaning the attic is..." + newIncome);
                Console.WriteLine("Your current balance is.............." + currentBalance);

                while (true)
                {
                    Console.WriteLine("\n" + "What should we do next?");
                    Console.WriteLine("\t" + "1. Run program again");
                    Console.WriteLine("\t"+"2. Exit Program");

                    userMenuInput = Console.ReadLine();
                    if (userMenuInput == "1")
                    {
                        Console.WriteLine("\n" + "What is your STARTING balance?");
                        startingBalance = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is your NEW income?");
                        newIncome = int.Parse(Console.ReadLine());

                        currentBalance = newIncome + startingBalance;

                        Console.WriteLine("\n" + "Your starting balance is           " + startingBalance);
                        Console.WriteLine("Your pay for cleaning the attic is " + newIncome);
                        Console.WriteLine("Your current balance is            " + currentBalance);

                    }
                    else if (userMenuInput == "2")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\n" + "Invalid Option"+"\n" + "Please choose a valid option");

                    }
                }
              
            }
        }
    }
}

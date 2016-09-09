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
            string userMenuInput;

            while (true)
            {
                Console.WriteLine("This is the begining of the program's run");
                while (true)
                {
                    Console.WriteLine("What should we do next?");
                    Console.WriteLine("1. Run program again");
                    Console.WriteLine("2. Exit Program");

                    userMenuInput = Console.ReadLine();
                    if (userMenuInput == "1")
                    {
                        Console.WriteLine("This is the program looping back around");
                    }
                    else if (userMenuInput == "2")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("this is the invalid option tester");
                    }
                }
              
            }
        }
    }
}

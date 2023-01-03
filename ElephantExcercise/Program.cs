using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElephantExcercise
{
    internal class Program
    {

        public static void Main(string[] args)
        {

            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
                string line = Console.ReadLine();
                if (int.TryParse(line, out int selection))
                {
                    if (selection == 1)
                    {
                        Console.WriteLine("You Pressed 1");
                        Console.WriteLine("Calling lloyd.WhoAmI()");
                        lloyd.WhoAmI();

                    }
                    else if (selection == 2)
                    {
                        Console.WriteLine("You Pressed 2");
                        Console.WriteLine("Calling lucinda.WhoAmI");
                        lucinda.WhoAmI();
                    }
                    else if (selection == 3)
                    {
                        Console.WriteLine("You have pressed 3");
                        Console.WriteLine("References have been swapped");
                        Swap();
                    }
                    else
                    {
                        Console.WriteLine("bye");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }


            void Swap()
            {
                Elephant swap = new Elephant() { Name = "", EarSize = 0 };

                swap = lucinda;
                lucinda = lloyd;
                lloyd = swap;


            }
        }


    }
}

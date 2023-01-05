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

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 4 to Lloyd mess with Lucinda, 5 to greet Lloyd ");
            while (true)
            {
                string line = Console.ReadLine();
                Console.WriteLine($"You pressed {line}.");
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
                    else if (selection == 4)
                    {
                        lloyd = lucinda;
                        lloyd.EarSize = 4321;
                        lloyd.WhoAmI();

                    }
                    else if (selection == 5)
                    {
                        lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
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
                void Swap()
                {
                    Elephant swap;

                    swap = lucinda;
                    lucinda = lloyd;
                    lloyd = swap;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = null;

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" {0, 6}  ", ("red"));
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" {0, 6}  ", ("black"));
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write(" {0, 6}  ", ("cyan"));
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(" {0, 6}  ", ("blue"));
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write(" {0, 6}  ", ("gray"));
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" {0, 6}  ", ("yellow"));
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" {0, 6}  ", ("white"));
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" {0, 6}  ", ("magenta"));

                Console.BackgroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine("\n\nEnter your color:");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(">>> ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                userInput = Console.ReadLine().ToLower();

                if (userInput.Equals("red"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n\n>>> ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\t");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("This message is only for testing purpose!");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\tThis message is only for testing purpose!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nPress any key to continue . . .");
                    Console.ReadKey();
                }
                else if (userInput.Equals("black"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n\n>>> ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\t");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("This message is only for testing purpose!");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\tThis message is only for testing purpose!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nPress any key to continue . . .");
                    Console.ReadKey();
                }
                else if (userInput.Equals("cyan"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n\n>>> ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\t");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Write("This message is only for testing purpose!");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\tThis message is only for testing purpose!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nPress any key to continue . . .");
                    Console.ReadKey();
                }
                else if (userInput.Equals("blue"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n\n>>> ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\t");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("This message is only for testing purpose!");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n\tThis message is only for testing purpose!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nPress any key to continue . . .");
                    Console.ReadKey();
                }
                else if (userInput.Equals("gray"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n\n>>> ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\t");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("This message is only for testing purpose!");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\n\tThis message is only for testing purpose!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nPress any key to continue . . .");
                    Console.ReadKey();
                }
                else if (userInput.Equals("green"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n\n>>> ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\t");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("This message is only for testing purpose!");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\tThis message is only for testing purpose!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nPress any key to continue . . .");
                    Console.ReadKey();
                }
                else if (userInput.Equals("yellow"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n\n>>> ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\t");
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("This message is only for testing purpose!");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\tThis message is only for testing purpose!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nPress any key to continue . . .");
                    Console.ReadKey();
                }
                else if (userInput.Equals("white"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n\n>>> ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\t");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("This message is only for testing purpose!");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\tThis message is only for testing purpose!");
                    Console.WriteLine("\n\nPress any key to continue . . .");
                    Console.ReadKey();
                }
                else if (userInput.Equals("magenta"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n\n>>> ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\t");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Write("This message is only for testing purpose!");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n\tThis message is only for testing purpose!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nPress any key to continue . . .");
                    Console.ReadKey();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("\n\n>>> ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("No such color in here!");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nPress any key to continue . . .");
                    Console.ReadKey();
                }
            }
        }


    
    }
}

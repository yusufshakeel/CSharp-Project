using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixScreen2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Press ENTER to start...");
            Console.ReadKey();
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    for (int s = 1; s <= 8; s++)
                    {
                        if (rand.Next(10) > 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }

                        int n = rand.Next(2);
                        Console.Write(n);
                    }
                    if (j != 7)
                    {
                        Console.Write("    ");
                    }
                }
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}

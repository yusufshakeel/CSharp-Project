using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            //set text color
            Console.ForegroundColor = ConsoleColor.Green;

            //random number
            Random rand = new Random();

            //string pattern to print
            String str = "";

            Console.Write("Press ENTER to start...");
            Console.ReadKey();

            //loop to display string pattern
            //you can change the no. of times the loop execute
            for (int i = 0; i < 20000; i++)
            {
                //create new string pattern
                if (i % 2 == 0)
                {
                    str = "";
                    for (int j = 0; j < 79; j++)
                    {
                        int n = rand.Next(5);
                        if (n < 2)
                        {
                            str += n.ToString();
                        }
                        else
                        {
                            str += " ";
                        }
                    }
                }

                //print str pattern
                Console.WriteLine(str);
            }

            //end of loop
            Console.WriteLine("End of screen...");
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

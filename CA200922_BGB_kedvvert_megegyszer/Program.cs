using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200922_BGB_kedvvert_megegyszer
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));

                Console.Write("*");
            }

            Console.ReadKey(true);
        }
    }
}

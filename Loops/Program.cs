using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;

            //while (count < 3)
            //{
            //    count++;
            //    Console.WriteLine("The loop has run " + count + " times.");
            //}
            //Console.ReadKey();
            for( int count = 3; count >= 0; count -= 1)
            {
                Console.WriteLine("The value of count is now  " + count + ".");
                Console.ReadKey();
                if (count == 2)
                {
                    //break;
                    return;
                }
            }
            Console.WriteLine("The loop is now finished.");
            Console.ReadKey();
        }
    }
}

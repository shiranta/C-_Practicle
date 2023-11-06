using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @break
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            while (x < 20)
            {
                Console.WriteLine("Value is{0}", x);
                x++;

                if (x > 15)
                {
                    //terminating the loop from 15
                    break;
                }                
            }
            Console.ReadLine();
        }
    }
}

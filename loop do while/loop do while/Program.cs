using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing variables
            int a= 10;
            //do loop execution
            do
            {
                Console.WriteLine("value of a is:{0}", a);
                a = a + 1;

            }
            while (a < 20);
            Console.ReadLine();
        }
    }
}

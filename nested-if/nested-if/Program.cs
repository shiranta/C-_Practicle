using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //assing local variables
            int a = 100;
            int b = 200;
            //check the boolian condition
            if (a == 100)
            {
                //if conditon is true check the following
                Console.WriteLine("value of a is 100 and b is 200");
                  
            }
            Console.WriteLine("Exact value of a is 100");
            Console.WriteLine("exact value of b is 200");
            Console.ReadLine();
        }
    }
}

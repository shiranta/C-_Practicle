using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing variable           
            for(int x=10;x<20;x=x+1)
            {
                Console.WriteLine("value of x:{0}", x);
               // Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

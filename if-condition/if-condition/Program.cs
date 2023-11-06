using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            /* local variable definition*/
            int a= 10;
            /* check the boolian conditon*/
            if (a < 20)
            {
                //when if condition is true
                Console.WriteLine("a is less than 20");
            }
            Console.WriteLine("value of a is :{0}", a);
            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if__else
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable definition
            int a = 50;
            //check the boolian condition
            if (a < 20)
            {


                //ifcondition is true
                Console.WriteLine("a is less than 20");
                Console.WriteLine("value of a:{0}", a);
                Console.ReadLine();
            }
            else
            {
                //if conditon is faulse
                Console.WriteLine("a is not less than 20");
                Console.WriteLine("value of a is:{0} ", a);
                Console.ReadLine();
            }
        }
    }
}

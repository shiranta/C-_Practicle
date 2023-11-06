using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_app__method_
{
    class NumberManipulator
    {
        public int findmax(int num1,int num2)
        {
            //local variables
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
        static void Main(string[] args)
        {
            //local variable declaration
            int a = 100;
            int b = 200;
            int ret;
            //define an instant
            NumberManipulator n = new NumberManipulator();
            //calling find max method
            ret = n.findmax(a, b);
            Console.WriteLine("max value is:{0}", ret);
            Console.ReadLine();

        }
    }
}

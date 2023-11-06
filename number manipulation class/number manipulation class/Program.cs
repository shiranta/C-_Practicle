using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_manipulation_class
{
    class calculate
    {
        //asing variable
        
        public int findmax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
                result= num1;
            else
                result= num2;
            return result;
        }
    }
    class calmax
    {
        static void Main(string[] args)
        {
            //assing the variables
            int a = 100;
            int b = 300;
            int ret;
            //asing an instance of class calculat
            calculate n = new calculate();
            ret = n.findmax(a, b);
            Console.WriteLine("the grater number is :{0}", ret);
            Console.ReadLine();

        }        
    }
}

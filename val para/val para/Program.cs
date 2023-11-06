using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace val_para
{
    class numbermanipulate
    {
        public void swap(ref int x,ref int y)
        {
            //assing variables 
            int temp;
            temp = x;//save the value of x
            x = y;//put y into x
            y = temp;//put temp into y
        }
        static void Main(string[] args)
        {
            numbermanipulate n = new numbermanipulate();
            //local variable definition
            int a = 100;
            int b = 200;
            Console.WriteLine("Value of 'a' befor swap{0}", a);
            Console.WriteLine("value of 'b' befor swap{0}", b);
            //calling a function to swap
            n.swap( ref a, ref b);
            Console.WriteLine("value of 'a' after swap{0}", a);
            Console.WriteLine("value of 'b' after swap{0}", b);
            Console.ReadLine();


        }
    }
}

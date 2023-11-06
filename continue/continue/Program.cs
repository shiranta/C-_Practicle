using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            //initializing do while loop
            do
            {
                //initialize continue
                if (x == 15)
                {
                    x++;
                    continue;
                } 
                


                Console.WriteLine("the value is:{0}", x);
                x++;
            }
            while (x < 20);
                Console.WriteLine();
            
        }
        
    }
    
}

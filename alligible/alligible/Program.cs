using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alligible
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double age;
            Console.WriteLine("what is your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello:{0}", name);
            Console.ReadLine();
            Console.WriteLine("what is your age:");
            age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("{0} you are elligible for vote.", name);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} you are not elligible for vote.",name);
                Console.ReadLine();

            } 
                
            


        }
    }
}

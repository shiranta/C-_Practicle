using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grading_system
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Double marks;
            Console.WriteLine("what is your name:");
            name=Console.ReadLine();
            Console.WriteLine("Enter your marks:");
            marks = Convert.ToInt16(Console.ReadLine());
            if (marks < 0)
            {
                Console.WriteLine("{0} your marks are invalid.", name);
                Console.ReadLine();
            }
            else if (marks < 35)
            {
                Console.WriteLine("{0} your are fail.", name);
                Console.ReadLine();
            }
            else if (marks < 55)
            {
                Console.WriteLine("{0} you have a simple (s) pass.", name);
                Console.ReadLine();
            }
            else if (marks < 65)
            {
                Console.WriteLine("{0} you have a credit (c) pass.", name);
                Console.ReadLine();
            }
            else if (marks < 75)
            {
                Console.WriteLine("{0} you have a brillent (b) pass. ", name);
                Console.ReadLine();
            }
            else if(marks < 100)
        {
                Console.WriteLine("{0} you have an exallent (A) pass.", name);
                Console.ReadLine();

                    
        }
        

        }
    }
}

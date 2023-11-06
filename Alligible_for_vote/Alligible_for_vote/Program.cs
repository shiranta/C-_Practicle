using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alligible_for_vote
{
    class Program
    {
        static void Main(string[] args)
        {

            string name, myage;
            int age;
            Console.WriteLine("What`s your name:");
            name = Console.ReadLine();
            Console.WriteLine("What`s your age:");

            myage =  Console.ReadLine();
          age = Int32.Parse(myage);
            Console.WriteLine("Hello,{0} you are {1} years old", name, age);
            Console.ReadLine();
            
        }
    }
}

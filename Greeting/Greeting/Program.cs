using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Hello
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("What`s your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello,{0}! ", name);
            Console.ReadLine();

        }
    }
}

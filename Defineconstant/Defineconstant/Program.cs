﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defineconstant
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            //constant declaration
            Double r;
            Console.WriteLine("Enter radius:");
            r=Convert.ToDouble(Console.ReadLine());
            Double areacircle = pi * r * r;
            Console.WriteLine("Radius={0},area={1}", r, areacircle);
            Console.ReadLine();



        }
    }
}

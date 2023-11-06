using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class My_rectangle
    {
        //member variables
        double length;
        double width;
        public void acceptdetails()
        {
            length = 3.5;
            width = 4.5;
        }
        public double getarea()/*Here in this metod we put double because the
            variables are double*/
             
        {
            return length * width;
        }
        public void display()
        {
            Console.WriteLine("length:{0}",length);
            Console.WriteLine("width:{0}",width);
            Console.WriteLine("area:{0}", getarea());
       }
        class Executerectangle
        {
            static void Main(string[] args)
            {
                My_rectangle r = new My_rectangle();
                r.acceptdetails();
                r.display();
                Console.ReadLine();

            }
        }
    }
}

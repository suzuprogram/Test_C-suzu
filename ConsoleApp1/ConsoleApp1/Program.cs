using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Class1 cls1 = new Class1();
           int d =  cls1.Tasu(a,b);
            Console.WriteLine(d);
        }
    }
}

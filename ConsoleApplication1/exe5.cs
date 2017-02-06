using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class exe5
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Enter a Double number : ");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Your Double Number is {0:##00.00} ", a);
        }
    }
}

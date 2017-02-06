using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class exe4
    {
        static void Main()
        {
            double a;
            Console.Write("Enter a double presion number : ");
            a = Convert.ToDouble(Console.ReadLine());
            a *= a;
            Console.WriteLine("Square of the number : {0} ", a);
        }
    }
}

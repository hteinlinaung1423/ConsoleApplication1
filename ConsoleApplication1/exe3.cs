using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class exe3
    {
        static void Main()
        {
            int a;
            Console.Write("Enter an integer : ");
            a = Convert.ToInt32(Console.ReadLine());
            a *= a;
            Console.WriteLine("Square of the number : {0}", a);
        }
    }
}

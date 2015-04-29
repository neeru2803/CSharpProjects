using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of a");
            string a = Console.ReadLine();
            int c = Convert.ToInt32(a, 2);
            Console.WriteLine("enter the value of b");
            string b = Console.ReadLine();
            int d = Convert.ToInt32(b, 2);

            int e = c + d;
            string sol = Convert.ToString(e, 2);

            Console.WriteLine("the given value is :{0}", sol);
            Console.ReadLine();
        }
    }
}

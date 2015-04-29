using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, revs;
            Console.WriteLine("enter the string s");
            s = Console.ReadLine();
            Console.WriteLine("enter the string revs");
            revs = Console.ReadLine();
            int length = s.Length;
            
            for (int i = 0;i<length;i++)
            {
                string[] temps = new string[i];
            }
            if (revs == s)
            {
                Console.WriteLine("the string is matched", s, revs);
            }
            else
            {
                Console.WriteLine("the string is not matched", s, revs);
            }
            Console.ReadKey();
             







        }
    }
}

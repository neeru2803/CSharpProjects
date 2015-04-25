using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepCal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Name");
            var strName = Console.ReadLine();
            Console.WriteLine("how many hours did u sleep");
            int hoursOfSleep = int.Parse(Console.ReadLine());
            if (hoursOfSleep < 8)
            {
                Console.WriteLine("Hello,{0},{1}",strName, "you must be Tired");


            }
            else if (hoursOfSleep == 8)
            {
                Console.WriteLine("Hello,{0},{1}", strName, "you had perfect Sleep");

            }
            else
            {
                Console.WriteLine("Hello,{0},{1}", strName, "you are well rested");

            }








        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace TakeABreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            var strName = Console.ReadLine();
            Console.WriteLine("total no of break");
            var totalBreak = int.Parse(Console.ReadLine());
            var url = "https://www.youtube.com/watch?v=QB7WCCi6trk";
            var breakTime = 0;
             while (breakTime < totalBreak) 
             {
                 Thread.Sleep(13000);
                 breakTime++;
                 Process.Start(url);
                 Console.WriteLine("Music is the  best way to relax");

             }
            
        }
    }
}

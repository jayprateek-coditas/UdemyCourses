using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1
{
    internal class TimeSpan_1
    {
        public TimeSpan_1()
        {
            var timeSpan = new TimeSpan(1, 2, 3);        // means 1 hour 2 minute 3 sec 
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Minutes);
            Console.WriteLine($"Total Minutes : {timeSpan.TotalMinutes}");
        }
    }
}

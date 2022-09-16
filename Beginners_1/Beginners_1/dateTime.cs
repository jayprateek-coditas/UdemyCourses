using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1
{
    public  class dateTime
    {        public dateTime()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Hour : " + now.Hour);
            Console.WriteLine("Minute : " + now.Minute);

            var tomrrow = now.AddDays(1);
            var yesterday = tomrrow.AddDays(-1);

            Console.WriteLine($"Today : {now}");
            Console.WriteLine($"Yesterday : {yesterday}");
            Console.WriteLine($"Tommarrow : {tomrrow}");
        }
    }
}

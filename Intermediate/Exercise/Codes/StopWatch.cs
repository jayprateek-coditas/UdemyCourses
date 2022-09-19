using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Exercise.Codes
{
    public class StopWatch
    {
        DateTime start_Time;
        TimeSpan init_Time;
        TimeSpan dur_val;
        //DateTime start_1;
        public  void start()
        {
            start_Time= DateTime.Now;
            //return start_Time;
            Console.WriteLine($"Start Time is : {start_Time.Minute}:{start_Time.Millisecond/60}");
        }
        public void stop()
        {

            dur_val=dur_val+( DateTime.Now - start_Time);
            Console.WriteLine($"Duration is : {dur_val.TotalSeconds}");
        }

    }
}

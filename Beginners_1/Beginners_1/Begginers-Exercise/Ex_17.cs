using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_17
    {
        public Ex_17()
        {
            Console.WriteLine("Enter the time in 00:00 format \n");

            Console.Write("Enter the time : ");
            string time_1 = Console.ReadLine();

            int p1 = Convert.ToInt32(time_1.Substring(0, 2));
            int p2=Convert.ToInt32(time_1.Substring(3, 2));

            if (p1 <= 24 && p1 <= 60)
                Console.WriteLine("Time is Valid \n");
            else
                Console.WriteLine("Time is Not Valid \n");
        }
    }
}

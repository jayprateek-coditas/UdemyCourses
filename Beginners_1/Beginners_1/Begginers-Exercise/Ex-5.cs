using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_5
    {
        public Ex_5()
        {
            int count = 0;
            Console.Write("Number between 1 to 100 that are divisible by 3 are !! : ");
            for(int i=3;i<=100;i++)
            {
                count = (i % 3 == 0) ? count + 1 : count;
            }
            Console.WriteLine(count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public  class Ex_2
    {
        public Ex_2()
        {
            Console.Write("Enter Number 1 : ");
            int num_1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            int num_2=Convert.ToInt32(Console.ReadLine());

            if(num_1 > num_2)
                Console.WriteLine($"MAX NUMBER : {num_1}");
            else    
            Console.WriteLine($"MAX NUMBER : {num_2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public  class Ex_1
    {
        public Ex_1()
        {
            Console.Write("Enter Number between 1 to 10 : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num<1 || num>10)
            {
                Console.WriteLine("Invalid Number !!");
            }
            else
            {
                Console.WriteLine("Valid Number !!");
            }
        }
    }
}

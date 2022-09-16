using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public  class Ex_7
    {

        Int64 fact(Int64 num)
        {
            if (num == 1||num==0||num<0)
                return 1;

            return num * fact(num - 1);
        }
        public Ex_7()
        {
            Console.WriteLine("\nProgram to Find the Factorial of a Number !!\n");

            Console.Write("Enter the Number : ");
            var num=Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"Facotorial of a Number is {num} : {fact(num)}");

        }
    }
}

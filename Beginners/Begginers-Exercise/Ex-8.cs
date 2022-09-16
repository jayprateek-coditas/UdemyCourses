using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_8
    {
        public Ex_8()
        {
            Console.WriteLine("\nGuessing Number Game  !!\n");
            Random random = new Random();

            int num=random.Next(1, 10);

            int val = 4;
            int num_g = -1;
            while((val--)!=0)
            {
                Console.WriteLine($" Total Chance {val + 1}");
                Console.Write("Guess The Number 1 to 10 : ");
                 num_g=Convert.ToInt32(Console.ReadLine());
                if (num_g == num)
                {
                    Console.WriteLine("You Winn !!\n");
                }
                else
                    Console.WriteLine("Wrong !!! ");
            }
            if (num_g != num)
                Console.WriteLine($"Guessing Number is : {num}");
        }
    }
}

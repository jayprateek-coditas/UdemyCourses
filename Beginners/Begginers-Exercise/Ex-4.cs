using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public  class Ex_4
    {
        public Ex_4()
        {
            Console.Write("Set the Speed Limit above 20 ");
            int speed_Limit = Convert.ToInt32(Console.ReadLine());

            if(speed_Limit>=20)
            {
                Console.Write("Speed of Your Car : ");
                int speed=Convert.ToInt32(Console.ReadLine());

                if (speed <= speed_Limit)
                    Console.WriteLine("OK..");

                else
                {
                    int v = (speed - speed_Limit) / 5;

                    if (v >= 12)
                    {
                        Console.WriteLine("Licence Suspended !!");

                    }
                    else
                        Console.WriteLine($"Number of demerit points{v}");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input !!");
            }
            
        }
    }
}

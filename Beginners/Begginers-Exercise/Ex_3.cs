using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public  class Ex_3
    {
        public Ex_3()
        {
            Console.Write("Enter the Height of Image : ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Width of Image : ");
            double width = Convert.ToDouble(Console.ReadLine());

            if (height > width)
                Console.WriteLine("Portrait");
            else 
                Console.WriteLine("Landscape");
        }
    }
}

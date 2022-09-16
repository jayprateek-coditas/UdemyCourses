using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_19
    {
        public Ex_19()
        {
            Console.Write("Enter the String : ");
            string str = Console.ReadLine();
            int count = 0;
            foreach(var c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    count++;
            }

            Console.WriteLine($"Total Number of Vowels are : {count}");
        }
    }
}

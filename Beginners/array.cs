using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1
{
    public class array
    {
        public array()
        {
            Console.WriteLine("Program to Print the First 10 Even Elemenrs using Array \n");

            int[] arr = new int[10];

            int j = 0;
            for (int i = 1; j < 10; i++)
            {
                if (i % 2 == 0)
                {
                    arr[j++] = i;
                }
            }
            Console.Write("First 10 even numbers are ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1
{
    public class String_method_
    {
        public String_method_()
        {
            // Simple Declaring String 

            string str = "Hello World ";

            Console.WriteLine(str);

            // To Know the Length of the String ..

            Console.WriteLine(str.Length);

            // String  are Immutable in C#
            // Means Once created you cannot change the current  index value  

            Console.WriteLine("Program to Convert Array of numbers to String ..");

            int[] arr = { 1, 2, 3, 4, 5 };

            string str_1 = string.Join("", arr);
            Console.WriteLine(str_1);

        }

    }
}

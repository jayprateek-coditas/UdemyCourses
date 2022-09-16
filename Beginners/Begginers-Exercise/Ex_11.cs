using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_11
    {
        public Ex_11()
        {
            Console.Write("Enter your Name : ");
            string str=Console.ReadLine();

            // taking another string to store the reversed value
            string rev_str = "";
            
            for(int i=str.Length-1;i>=0;i--)
            {
                rev_str += str[i];
            }
            Console.Write("Reversed Name is : ");
            Console.WriteLine(rev_str);
        }
    }
}

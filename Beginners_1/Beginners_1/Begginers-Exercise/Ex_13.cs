using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_13
    {
        public Ex_13()
        {
            Console.WriteLine("Enter Number or else Enter QUIT to Exit \n");

            string str = String.Empty;
            var dup_arr = new HashSet<int> { };
            Console.Write("Enter Number : ");
            while((str=Console.ReadLine())!="QUIT")
            {
                 int val=Convert.ToInt32(str);
                dup_arr.Add(val);
                Console.Write("Enter Number : ");
            }

            if (dup_arr.Count > 0)
            {
                foreach (int i in dup_arr)
                    Console.Write(i + " ");
            }
                    else
                        Console.WriteLine("No INPUT !!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public  class Ex_9
    {
        public Ex_9()
        {
            Console.WriteLine("Enter the Comma seperated value : ");
            var value=Console.ReadLine();
            int max_1 = -1;
            int val = 0;
            for(int i=0;i<value.Length;i++)
            {         
                 if(value[i]>='0'&& value[i]<='9')
                        {
                    val = val * 10 + (value[i] - '0');                    
                        }
                 else
                {
                    val = 0;
                }
                max_1=Math.Max(max_1, val);
            }
            Console.WriteLine($"Maximum is : {max_1}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_14
    {
        public Ex_14()
        {
            Console.WriteLine("Enter the string Comma seperated value \n");

            Console.Write("Enter the String (Comma Seperated ) :");
            string str = Console.ReadLine();
            List<int> l1 = new List<int> {};
            int val_1 = -1;
            for(int i=0;i<str.Length;i++)
            {
                var val = str[i];
               if(val>='0' && val<='9')
                {
                    if (val_1 == -1)
                        val_1 = 0;
                    val_1 = val_1 * 10 + (val-'0');
                    if(i==str.Length-1)
                        l1.Add(val_1);
                }
               else
                {
                    if (val_1 != -1)
                        l1.Add(val_1);
                    val_1 = -1;
                }
            }
            
            if (l1.Count < 5)
                Console.WriteLine("Invalid !!\n");
            else
            {
                l1.Sort();
                Console.WriteLine($"{l1[l1.Count - 1]} {l1[l1.Count - 2]} {l1[l1.Count - 3]}");
            }

        }
    }
}

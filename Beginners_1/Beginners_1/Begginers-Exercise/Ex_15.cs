using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_15
    {
        public Ex_15()
        {
            Console.WriteLine("Program for cheking number are consecutive or not \n");
            string str = Console.ReadLine();

            bool count_1 = false;  // for checking the difference is 1 
            bool count_2 = false;  // for checking the difference is -1 
            bool out_1= false;
            List<int> l1 = new List<int> { };
            int val_1 = -1;
            for (int i = 0; i < str.Length; i++)
            {
                var val = str[i];
                if (val >= '0' && val <= '9')
                {
                    if (val_1 == -1)
                        val_1 = 0;
                    val_1 = val_1 * 10 + (val - '0');
                    if (i == str.Length - 1)
                        l1.Add(val_1);
                }
                else
                {
                    if (val_1 != -1)
                        l1.Add(val_1);
                    val_1 = -1;
                }
            }

            for (int i = 1; i < l1.Count; i++)
            {
                Console.Write(l1[i] + " ");
                if (l1[i - 1] - l1[i] == -1)
                {
                    if (count_1 == false)
                         count_2 = true;
                    else
                    {
                        count_2 = true;
                        Console.WriteLine("Invlid ");
                        break;
                    }
                }

                else if (l1[i - 1] - l1[i] == 1)
                {
                    if (count_2 == false)
                        count_1 = true;
                    else
                    {
                        count_1 = true;
                        Console.WriteLine("Invlid ");
                        break;
                    }
                }
                else
                { Console.WriteLine("Invalid "); out_1= true; }
            }
            if (out_1==false && count_1 != count_2)
                Console.WriteLine("IS Consecutive !!\n");
        }
    }
}


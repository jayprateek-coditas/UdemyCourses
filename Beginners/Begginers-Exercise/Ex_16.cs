using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_16
    {
        public Ex_16()
        {
            Console.WriteLine("Enter the Number string with hyphen\n");

            Console.Write("Enter : ");

            string str = String.Empty;

            if ((str = Console.ReadLine()) != String.Empty)
            {
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
                var hash=new HashSet<int>();

                int val_ = -1;
                foreach(var i in l1)
                {
                    hash.Add(i);
                    if (val_ == hash.Count)
                        Console.Write(i + " ");
                    val_=hash.Count;
                }
            }
            else
                Console.WriteLine("String is Empty !!");
            
        }
    }
}

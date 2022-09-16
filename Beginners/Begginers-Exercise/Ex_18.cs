using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_18
    {
        public Ex_18()
        {
            Console.Write("Enter the String : ");
            string str = Console.ReadLine();

            string out_1 = String.Empty;
            for(int i=0;i<str.Length;i++)
            {
                if (i==0||((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z')) && str[i-1]==' ')
                {
                    out_1 += char.ToUpper(str[i]);
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    out_1+=char.ToLower(str[i]);    
                }
            }
            Console.WriteLine($"OutPut String is : {out_1}");
        }
    }
}

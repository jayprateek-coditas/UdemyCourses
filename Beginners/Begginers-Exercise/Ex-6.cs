using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_6
    {
        public Ex_6()
         {
            int sum = 0;
            string str = "";
            while(!(str=="ok"||str=="Ok"||str=="OK"))
            {
                Console.Write("Enter the Number or Enter OK to exit :  ");

                str=Console.ReadLine();

                if (str == "ok" || str == "Ok" || str == "OK")
                {
                    Console.WriteLine(" Program Exit !!\n");
                    break; }
                else
                {
                    int num = Convert.ToInt32(str);
                    sum += num;
                    Console.WriteLine($"Sum is : {sum}");
                }


            }

            
        }

    }
}

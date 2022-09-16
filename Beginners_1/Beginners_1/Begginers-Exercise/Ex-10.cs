using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public  class Ex_10
    {
        public Ex_10()
        {
            Console.Write("Enter Name : ");
            string str = "";
            List<string> list = new List<string>();
         while((str=Console.ReadLine())!=String.Empty)
             {
                list.Add(str);
                str = String.Empty;
                Console.Write("Enter Name : ");  
            }

            if (list.Count > 0)
            {
                Console.WriteLine("Number of Peron like your Post are ");
                foreach (var item in list)
                {
                    Console.Write(item+"  ");
                }
            }
            else
                Console.WriteLine("Zero person liked your post");
        }
    }
}

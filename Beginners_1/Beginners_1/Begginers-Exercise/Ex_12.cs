using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_12
    {
        public Ex_12()
        {
            SortedSet<int> my_Set1 = new SortedSet<int>();
            int siz = my_Set1.Count;
            int i = 0;
            while(my_Set1.Count<5)
            {
                Console.Write("Enter the Number : ");
                int val = Convert.ToInt32(Console.ReadLine());
                my_Set1.Add(val);
                if (my_Set1.Count == i)
                { Console.WriteLine("Duplicate Number Try again"); }
                else
                {
                  i = my_Set1.Count;
                     
                } 
            }
            Console.Write("Values are : ");
            foreach(int val in my_Set1)
                Console.Write(val+" ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1
{
    public class Random_1
    {

        public Random_1()
        {
            Console.WriteLine("Generate 10 Random File Name Using Random ");

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                var val = Convert.ToString(rand.Next(100000, 999999));   // FileName  size of 6

                string str = String.Empty;
                foreach (char c in val)
                {
                    str += (char)(65 + c - '0');
                }
                Console.WriteLine(str);
            }

        }
    }
}



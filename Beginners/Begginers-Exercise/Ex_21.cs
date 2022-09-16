using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_21
    {
        public Ex_21()
        {
            string str = @"C:\Udemy-Course\Beginners_1\Beginners_1\File_Read.txt";

            Console.WriteLine($"File Path is {str}");

            string text = File.ReadAllText(str);


            int count = 0;
            int max_length = 0;
            string out_string = String.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                string str1 = "";
                while (i < text.Length && text[i] != ' ')
                {
                    str1 += text[i];
                    i++;
                }
                if (str1.Length != 0)
                {
                    if (max_length < str1.Length)
                        out_string = str1;
                    max_length = Math.Max(str1.Length, max_length);
                    
                    count++;
                }

            }
            Console.WriteLine($"Maximum Length of string is  : {max_length}  {out_string}");
        }
    }
}

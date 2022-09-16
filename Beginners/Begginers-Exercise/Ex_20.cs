using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1.Begginers_Exercise
{
    public class Ex_20
    {
        public Ex_20()
        {
            string str = @"C:\Udemy-Course\Beginners_1\Beginners_1\File_Read.txt";

            Console.WriteLine($"File Path is {str}");

           string text = File.ReadAllText(str);

           
            int count = 0;
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

                    count++;
                }

            }
            Console.WriteLine($"Total Number of Words in string : {count}");


        }
    }
}

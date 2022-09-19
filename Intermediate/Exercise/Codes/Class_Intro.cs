using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Codes
{
    // Create a class object by giving the string 
    public  class Class_Intro
    {
        public string Name=String.Empty;

        public void Introduce()
        {
            Console.WriteLine($"Hii {this.Name},I am Alpha Welcome to C# Programming...");
        }
        public static Class_Intro Parse(string str)
        {
            var person = new Class_Intro();

            person.Name = str;  
            return person;

            
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_1
{
    public  class Value_Type_Refrence_Type
    {
        public class person_Age
        {
            public int age;
        }
        public void age_1(int number)
        {
            number += 10;
        }
        public Value_Type_Refrence_Type()
        {
            // Check the  value type 
            int number = 10;
            age_1(number);
            System.Console.WriteLine("Value of Number : " + number);

            // Check for the refrence type 
            person_Age person = new person_Age { age = 21 };

            age_person(person);

            System.Console.WriteLine(person.age);
        }
        public void age_person(person_Age person)
        {
            person.age += 10;
        }
    }
}

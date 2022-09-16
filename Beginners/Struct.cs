namespace Beginners
{

    public class Struct
    {

          public struct person_info{
                public string name;
                public int age;
                public string Gender;

                public person_info(string name, int age, string Gender)
                {
                    this.name=name;
                    this.age=age;
                    this.Gender=Gender;
                }
            }
         public Struct()
        {
            Console.WriteLine("Start with structure");

          

            person_info person_1=new person_info("John Smith",22,"Male");

       
          Console.WriteLine($"Person name is :{person_1.name} Age is :{person_1.age} Gender is :{person_1.Gender}");
        }
    }
}
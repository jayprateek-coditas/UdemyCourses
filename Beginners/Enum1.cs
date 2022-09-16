namespace Beginners
{
    public class Enum1
    {
        public enum EnumValue{
            monday=2,
            tuesday=3,
            wednesday=4,
        }
        public Enum1()
        {
            System.Console.WriteLine(EnumValue.monday);     // this will display the key 
             System.Console.WriteLine((int)EnumValue.monday); // this will display the value 

             // To get the key using the values

            var v1=3;
            Console.WriteLine((EnumValue)v1);         // output is tuesday

            Console.WriteLine(v1.ToString());
        }
    }
}
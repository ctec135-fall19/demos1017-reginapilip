using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            double d = 456.789;
            string s = "some string";
            // creates a class, invokes a constructor via "new"
            MyClass mc = new MyClass();

            // create and instantiate an array
            Object[] myArray = new object[4];
            myArray[0] = i;
            myArray[1] = d;
            myArray[2] = s;
            myArray[3] = mc;

            // iterate array
            // example of polymorphism
            foreach(object o in myArray)
            {
                // methods provided by the System.Object class 
                // we did not create these ourselves
                Console.WriteLine("GetType():");
                Console.WriteLine(o.GetType());
                Console.WriteLine("ToString():");
                Console.WriteLine(o.ToString());
                Console.WriteLine();
            }
        }
    }
}

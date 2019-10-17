using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating objects of MyClass
            MyClass mc1 = new MyClass(123, "str1");
            MyClass mc2 = new MyClass(123, "str1");
            MyClass mc3 = new MyClass(456, "str1");

            Console.WriteLine("USING == FOR COMPARING OBJECTS");
            // does mc1 == mc2 * using == operator
            if (mc1 == mc2) Console.WriteLine("mc1 == mc2");
            else Console.WriteLine("mc1 does not equal mc2");

            Console.WriteLine();
            // when using == to compare two objects, remember that
            // objects are compared by the two addresses they refer to 
            // in memory. This is why you need to use the Equals() -
            // to compare the VALUES of the objects

            Console.WriteLine("USING Equals() FOR COMPARING OBJECTS");
            // * using equals()
            if (mc1.Equals(mc2)) Console.WriteLine("mc1 equals mc2");
            else Console.WriteLine("mc1 does not equal mc2");

            if (mc1.Equals(mc3)) Console.WriteLine("mc1 equals mc3");
            else Console.WriteLine("mc1 does not equal mc3");

            Console.WriteLine();
        }

    }
}

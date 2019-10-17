using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // AbstractBaseClass abc = AbstractBaseClass();  
            // this wont work because you are instantiating an abstract class

            // instantiating an object of ChildClass
            ChildClass cc = new ChildClass();
            Console.WriteLine(cc.AbstractMethod(123));
        }
    }
}

// refactoring - revising as you program
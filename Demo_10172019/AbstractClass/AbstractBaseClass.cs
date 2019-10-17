using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // abstract modifier notifies that no instantiation of this class is allowed
    abstract class AbstractBaseClass
    {
        public abstract int AbstractMethod(int num);
            // no implementation! done in child classes
    }
}

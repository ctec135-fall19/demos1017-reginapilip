﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // contracts the child classes to implement certain methods
    class ChildClass : AbstractBaseClass
    {
        public override int AbstractMethod(int num)
        {
            // throw new NotImplementedException(); generated by IntelliSense
            return num;
        }
    }
}

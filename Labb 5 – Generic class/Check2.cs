using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_5___Generic_class
{
    class Check2<Unkown> : Check<Unkown>
    {

        public override void ToCheck(Unkown firstVariable, Unkown secondVariable)
        {
            base.ToCheck(firstVariable, secondVariable);
        }
    }
}

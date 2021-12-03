using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_5___Generic_class
{
    abstract class Check<Unkown>
    {

        public virtual void ToCheck(Unkown firstVariable, Unkown secondVariable)
        {
            if (firstVariable.Equals(secondVariable))
            {
                Console.WriteLine($"{firstVariable} and {secondVariable} are Equal.");
            }
            else
            {
                Console.WriteLine($"{firstVariable} and {secondVariable} are NOT Equal.");
            }
        }
    }
}

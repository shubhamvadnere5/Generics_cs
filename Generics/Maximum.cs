using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_cs
{
    /// <summary>
    /// UC1 Finding Maximum interger number
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Maximum  //T is referes to a type
    {
        public static int Maxnumber(int first, int second, int third) //created max number method
        {
            //returns true if the both condition are true 
            // if (18 > 16 && 18 > 23) condition will be returns false and goes to the next elseif statement 
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            //returns true if the both condition are true 
            // if (16 > 18 && 16 > 23) condition will be returns false and goes to the next elseif statement 
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            //returns true if the both condition are true
            // if (23 > 18 && 23 > 16) condition will be returns true
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            //if the 2 or more values are same then else block will be executed
            else
            {
                Console.WriteLine("More than 2 numbers are same");
                return default;
            }
        }
    }
}
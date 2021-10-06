using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_cs
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 12, 14, 17, 86, 92, 76 };
            GenericMethod<int> generic = new GenericMethod<int>(arr);
            generic.PrintMaxValue();
            Console.ReadLine();
        }
    }
}
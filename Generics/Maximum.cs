using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_cs
{
    /// <summary>
    /// UC4 Finding max num in array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class GenericMethod<T> where T : IComparable //T perform multiple Operations when we compare values
    {
        public T[] value;

        /// method for initialize  the contructors of instance variables
        public GenericMethod(T[] value)
        {
            this.value = value;  //parameterized constructor
        }
        public T[] sort(T[] values) /// method is created for sorting values
        {
            Array.Sort(values); //sorting the Array
            return values; 
        }

        public T MaxValue(params T[] values) //params use for when programer dont have any prior knowledge about the number of parameter to give
        {
            T[] sortedArray = sort(this.value); //sorted array is stored in sort array
            return sortedArray[sortedArray.Length - 1]; //array starts from 0
        }

        public void PrintMaxValue() //method created for printing the max generic value
        {
            var max = MaxValue(this.value); //from max value method
            Console.WriteLine("The maximum value is : " + max);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class MathRelated
    {
        //Given an array of ints, write a C# method to total all of the values that are even numbers
        public int ReturnSumOfEvenNumbers(int[] ArrayOfInts)
        {
            return ArrayOfInts.Where(x => x % 2 == 0).Sum();
        }
    }
}

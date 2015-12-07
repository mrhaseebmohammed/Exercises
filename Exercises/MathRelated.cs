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
            return ArrayOfInts != null ? ArrayOfInts.Where(x => x % 2 == 0).Sum() : 0;
        }

        //Given an array of ints, write a C# method to total all of the values that are odd numbers
        public int ReturnSumOfOddNumbers(int[] ArrayOfInts)
        {
            return ArrayOfInts != null ? ArrayOfInts.Where(x => x % 2 == 1).Sum() : 0;
        }


        //Given an instance circle of the following class:
        //write code to calculate the circumference of the circle, without modifying the Circle class itself.
        public sealed class Circle
        {
            private double radius;

            public double CalculateCircumference(Func<double, double> op)
            {
                return op(radius);
            }

            public Circle(int newRadius)
            {
                radius = newRadius;
            }
        }
        
    }
}

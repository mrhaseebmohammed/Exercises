using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class MathRelatedTests
    {
        [TestMethod()]
        public void ReturnSumOfEvenNumbersTest()
       {
            // arrange
            int[] ArrayOfInts = new int[5];
            ArrayOfInts[0] = 2;
            ArrayOfInts[1] = 15;
            ArrayOfInts[2] = 16;
            ArrayOfInts[3] = 13;
            ArrayOfInts[4] = 0;


            var x = new MathRelated();
            int actual = x.ReturnSumOfEvenNumbers(ArrayOfInts);

            int expected = 18;
            
            Assert.AreEqual(actual,expected);
        }

        [TestMethod()]
        public void ReturnSumOfOddNumbersTest()
        {
            // arrange
            int[] ArrayOfInts = new int[5];
            ArrayOfInts[0] = 2;
            ArrayOfInts[1] = 15;
            ArrayOfInts[2] = 16;
            ArrayOfInts[3] = 13;
            ArrayOfInts[4] = 0;


            var x = new MathRelated();
            int actual = x.ReturnSumOfOddNumbers(ArrayOfInts);

            int expected = 28;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void ReturnSumOfEvenNumbersTestWithNoInput()
        {
            // arrange
            int[] ArrayOfInts = new int[4];
            //ArrayOfInts[0] = 2;
            //ArrayOfInts[1] = 15;
            //ArrayOfInts[2] = 16;
            //ArrayOfInts[3] = 13;


            var x = new MathRelated();
            int actual = x.ReturnSumOfEvenNumbers(ArrayOfInts);

            int expected = 0;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void ReturnSumOfOddNumbersTestWithNoInput()
        {
            // arrange
            int[] ArrayOfInts = new int[4];
            //ArrayOfInts[0] = 2;
            //ArrayOfInts[1] = 15;
            //ArrayOfInts[2] = 16;
            //ArrayOfInts[3] = 13;


            var x = new MathRelated();
            int actual = x.ReturnSumOfOddNumbers(ArrayOfInts);

            int expected = 0;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void ReturnSumOfEvenNumbersTestWithNull()
        {
            // arrange
            //int[] ArrayOfInts = new int[4];
            //ArrayOfInts[0] = 2;
            //ArrayOfInts[1] = 15;
            //ArrayOfInts[2] = 16;
            //ArrayOfInts[3] = 13;


            var x = new MathRelated();
            int actual = x.ReturnSumOfEvenNumbers(null);

            int expected = 0;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void ReturnSumOfOddNumbersTestWithNull()
        {
            // arrange
            //int[] ArrayOfInts = new int[4];
            //ArrayOfInts[0] = 2;
            //ArrayOfInts[1] = 15;
            //ArrayOfInts[2] = 16;
            //ArrayOfInts[3] = 13;


            var x = new MathRelated();
            int actual = x.ReturnSumOfOddNumbers(null);

            int expected = 0;

            Assert.AreEqual(actual, expected);
        }

        //write code to calculate the circumference of the circle, without modifying the Circle class itself.
        [TestMethod()]
        public void CalculateCircumferenceTest()
        {
            var circle = new MathRelated.Circle(2);

            var radius = circle.CalculateCircumference(r => r);
            var circumference = circle.CalculateCircumference(r => r * Math.PI * 2);
            var roundedCircumference = Math.Round(circumference, 2);

            Assert.AreEqual(radius, 2);
            Assert.AreEqual(roundedCircumference, 12.57);
        }

        //ProjectEuler Problem 1
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.
        [TestMethod()]
        public void SumOfMultiplesOf3or5Test()
        {
            var x = new MathRelated();

            var sum = x.SumOfMultiplesOf3or5(10);

            Assert.AreEqual(23, sum);
        }
    }
}
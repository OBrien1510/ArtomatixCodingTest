using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtomatixCodingExercise;


namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        /// <summary>
        /// TODO: Add as many test cases as required to fully validate your implementation of 
        /// MedianCalculator and GetMedianValueHighPerformance methods
        /// </summary>
        [TestMethod]
        public void TestGetMedianSingleArray1()
        {
            int[] a = { 2, 1, 3 };
            double result = MedianCalculator.GetMedianValue(a);
            double expected = 2;
            Assert.AreEqual(expected, result);

            a = new int[] { 1, 2, 3, 4 };
            int[] b = { 5, 6, 7 };
            result = MedianCalculator.GetMedianValueHighPerformance(a, b);
            expected = 4;
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// This test uses a large data set.
        /// Within this test case implement a scheme that validates that GetMedianValueHighPerformance 
        /// returns the correct result.
        /// 
        /// For additional credit, perform memory and performance analysis of algorithms developed, and report on the results.
        /// </summary>
        [TestMethod]
        public void TestVeryLargeSourceData()
        {
            Random randNumber = new Random();
            int[] a = CreateRandomDataSet(randNumber.Next(3, 10000000));
            int[] b = CreateRandomDataSet(randNumber.Next(3, 10000000));

            double result = MedianCalculator.GetMedianValueHighPerformance(a, b);
            // TODO: validate correct result is given
            // TODO: measure and report on memory and performance of the algorithm
            //       what is the scaling factor when the data set is doubled in size?
        }

        private int[] CreateRandomDataSet(int size)
        {
            Random rnd = new Random();
            int[] a = new int[size];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next();
            }
            return a;
        }
                
    }
}

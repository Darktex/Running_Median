using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Running_Median;
using System.Collections.Generic;
using System.Linq;

namespace Running_Median_Unit_Test
{
    [TestClass]
    public class TestMaxHeap
    {

        [TestMethod]
        public void TestInsert()
        {
            var list = new List<int> { 1, 9, 3, 6, 5, 2, 7, 11, 9 };
            var maxHeap = new MaxHeap();

            list.ForEach(elem => maxHeap.Add(elem));

            Assert.AreEqual(11, maxHeap.peekMax());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void testRemoveMaxWhenEmpty() {
            var maxHeap = new MaxHeap();
            maxHeap.removeMax();
        }

        [TestMethod]
        public void testBunchOfInsertionsAndDeletions()
        {
            var list = new List<double> { 74, 101, 11, 1000, 4, -101, -1000 };
            var maxHeap = new MaxHeap();

            list.ForEach(elem => maxHeap.Add(elem));

            list.Sort();
            list.Reverse();
            var maxes = new List<double>();

            for (int i = 0; i < list.Count; i++)
            {
                maxes.Add(maxHeap.removeMax());
            }

            List<Tuple<double, double>> expectedVsActual = list.Zip(maxes, Tuple.Create).ToList();

            foreach(var tuple in expectedVsActual)
            {
                Assert.AreEqual(tuple.Item1, tuple.Item2);
            }

        }
    }
}

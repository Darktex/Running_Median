using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Running_Median;
using System.Collections.Generic;
using System.Linq;

namespace Running_Median_Unit_Test
{
    [TestClass]
    public class TestMinHeap
    {

        [TestMethod]
        public void TestInsert()
        {
            var list = new List<int> { 1, 9, 3, 6, 5, 2, 7, 11, 9 };
            var minHeap = new MinHeap();

            list.ForEach(elem => minHeap.Add(elem));

            Assert.AreEqual(1, minHeap.peekMin());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void testRemoveMaxWhenEmpty() {
            var minHeap = new MaxHeap();
            minHeap.removeMax();
        }

        [TestMethod]
        public void testBunchOfInsertionsAndDeletions()
        {
            var list = new List<double> { 74, 101, 11, 1000, 4, -101, -1000 };
            var minHeap = new MinHeap();

            list.ForEach(elem => minHeap.Add(elem));

            list.Sort();
            var mins = new List<double>();

            for (int i = 0; i < list.Count; i++)
            {
                mins.Add(minHeap.removeMin());
            }

            List<Tuple<double, double>> expectedVsActual = list.Zip(mins, Tuple.Create).ToList();

            foreach(var tuple in expectedVsActual)
            {
                Assert.AreEqual(tuple.Item1, tuple.Item2);
            }

        }
    }
}

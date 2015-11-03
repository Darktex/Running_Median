using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Running_Median
{
    public class MedianFinder
    {

        // Adds a num into the data structure.
        public void AddNum(double num)
        {

        }

        // return the median of current data stream
        public double FindMedian()
        {
            return 2.0;
        }
    }

    // Your MedianFinder object will be instantiated and called as such:
    // MedianFinder mf = new MedianFinder();
    // mf.AddNum(1);
    // mf.FindMedian();

    public class MaxHeap
    {
        private List<int> A;

        public MaxHeap()
        {
            A = new List<int>();
        }

        public void Add(int elem)
        {
            A.Add(elem);
            swim();
        }

        public int peekMax()
        {
            return A[0];
        }

        public int removeMax()
        {
            int result = A[0];
            A[0] = -1;
            sink();

            return result;
        }

        private void sink()
        {
            int parentIdx = 0; // We only remove from the top of the array
            int leftChildIdx = 2 * parentIdx + 1;
            int rightChildIdx = 2 * parentIdx + 2;

            int parent = A[0];
            int leftChild = A[leftChildIdx];
            int rightChild = A[rightChildIdx];

            while (parent > leftChild || parent > rightChild)
            {


            }
        }

        private void swim()
        {
            int childIdx = A.Count - 1; // We only add at the bottom of the array
            int parentIdx = (int) Math.Truncate(((double) childIdx - 1) / 2);
            int child = A[childIdx];
            int parent = A[parentIdx];

            while (child > parent && parentIdx >= 0)
            {
                swap(childIdx, parentIdx);
                parentIdx = (int) Math.Truncate(((double) childIdx - 1) / 2);
            }

        }

        private void swap(int firstIdx, int secondIdx)
        {
            int temp = A[firstIdx];
            A[firstIdx] = A[secondIdx];
            A[secondIdx] = temp;
        }
    }
}

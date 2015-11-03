using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Running_Median
{
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
                swim(A.Count - 1);
            
        }

        public int peekMax()
        {
            return A[0];
        }

        public int removeMax()
        {
            if (A.Count == 0) throw new InvalidOperationException();
            int result = A[0];
            swap(0, A.Count - 1);
            A.RemoveAt(A.Count - 1);
            sink();

            return result;
        }

        private void sink()
        {
            int parentIdx = 0; // We only remove from the top of the array
            int leftChildIdx = 2 * parentIdx + 1;
            int rightChildIdx = 2 * parentIdx + 2;

            int parent = A[0];]
            if(A.Count > 1)
            int leftChild = A[leftChildIdx];
            int rightChild = A[rightChildIdx];

            while (parent < leftChild || parent < rightChild) // this leaves holes
            {
                int biggerChildIdx = (rightChild > leftChild) ? rightChildIdx : leftChildIdx;
                swap(parentIdx, biggerChildIdx);
                parentIdx = biggerChildIdx;
                leftChildIdx = 2 * parentIdx + 1;
                rightChildIdx = 2 * parentIdx + 2;

                if (rightChildIdx > A.Count - 1) break;

                parent = A[parentIdx];
                leftChild = A[leftChildIdx];
                rightChild = A[rightChildIdx];

            }
        }

        private void swim(int childIdx)
        {
            int parentIdx = (int)Math.Truncate(((double)childIdx - 1) / 2);
            int child = A[childIdx];
            int parent = A[parentIdx];

            while (child > parent && childIdx != parentIdx)
            {
                swap(childIdx, parentIdx);
                childIdx = parentIdx;
                child = A[parentIdx];
                parentIdx = (int)Math.Truncate(((double)childIdx - 1) / 2);
                parent = A[parentIdx];
            }

        }

        private void swap(int firstIdx, int secondIdx)
        {
            int temp = A[firstIdx];
            A[firstIdx] = A[secondIdx];
            A[secondIdx] = temp;
        }

        public static void Main()
        {
            var list = new List<int> { 74, 101, 11, 1000, 4, -101, -1000 };
            var maxHeap = new MaxHeap();

            list.ForEach(elem => maxHeap.Add(elem));

            list.Sort();
            list.Reverse();
            var maxes = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                maxes.Add(maxHeap.removeMax());
            }

            List<Tuple<int, int>> expectedVsActual = list.Zip(maxes, Tuple.Create).ToList();

            foreach (var tuple in expectedVsActual)
            {
                Console.WriteLine(tuple.Item1 + tuple.Item2);
            }
        }

    }
}

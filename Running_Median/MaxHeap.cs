using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Running_Median
{
    public class MaxHeap
    {
        private List<double> A;

        public MaxHeap()
        {
            A = new List<double>();
        }

        public int Count()
        {
            return A.Count;
        }

        public void Add(double elem)
        {
            A.Add(elem);
            swim(A.Count - 1);

        }

        public double peekMax()
        {
            if (A.Count == 0) throw new InvalidOperationException();
            return A[0];
        }

        public double removeMax()
        {
            if (A.Count == 0) throw new InvalidOperationException();
            double result = A[0];
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

            if (A.Count == 2 && A[0] < A[1]) swap(0, 1);
            if (A.Count == 3)
            {
                if (A[0] < A[1])
                    swap(0, 1);
                else if (A[0] < A[2])
                    swap(0, 2);
            }

                double parent = A[0];
                double leftChild = A[leftChildIdx];
                double rightChild = A[rightChildIdx];

                while (parent < leftChild || parent < rightChild)
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
            int parentIdx = (childIdx - 1) / 2;
            double child = A[childIdx];
            double parent = A[parentIdx];

            while (child > parent && childIdx != parentIdx)
            {
                swap(childIdx, parentIdx);
                childIdx = parentIdx;
                child = A[parentIdx];
                parentIdx = (childIdx - 1) / 2;
                parent = A[parentIdx];
            }

        }

        private void swap(int firstIdx, int secondIdx)
        {
            double temp = A[firstIdx];
            A[firstIdx] = A[secondIdx];
            A[secondIdx] = temp;
        }
    }
}

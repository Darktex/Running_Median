using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Running_Median
{
    public class MedianFinder
    {
        MinHeap upperPortion;
        MaxHeap lowerPortion;

        public MedianFinder()
        {
            upperPortion = new MinHeap();
            lowerPortion = new MaxHeap();
        }

        // Adds a num into the data structure.
        public void AddNum(double num)
        {
            if (upperPortion.Count() == lowerPortion.Count())
            {
                // Insert the new element where it belongs
                if (upperPortion.Count() > 0 && num > upperPortion.peekMin())
                {
                    upperPortion.Add(num);
                    lowerPortion.Add(upperPortion.removeMin()); // Rebalance the heaps so that lowerPortion has N/2 + 1 elements
                }
                else
                    lowerPortion.Add(num);
            }

            else // after the insertion we'll have an even number of elements
            {
                if (upperPortion.Count() > 0 && num > upperPortion.peekMin())
                {
                    upperPortion.Add(num);
                    if (upperPortion.Count() > lowerPortion.Count())
                        lowerPortion.Add(upperPortion.removeMin());
                }
                else
                {
                    lowerPortion.Add(num);
                    if (lowerPortion.Count() > upperPortion.Count())
                        upperPortion.Add(lowerPortion.removeMax());
                }
                
            }
        }

        // return the median of current data stream
        public double FindMedian()
        {
            if (upperPortion.Count() == lowerPortion.Count())
                return (upperPortion.peekMin() + lowerPortion.peekMax()) / 2;
            else
                return lowerPortion.peekMax();
        }

        public static void Main()
        {
            // Your MedianFinder object will be instantiated and called as such:
            MedianFinder mf = new MedianFinder();
            mf.AddNum(1);
            double q = mf.FindMedian();

            mf.AddNum(2);
            mf.AddNum(3);
            q = mf.FindMedian();
        }
    }
}



 

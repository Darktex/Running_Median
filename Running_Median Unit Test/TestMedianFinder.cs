using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Running_Median;
using System.Collections.Generic;
using System.Linq;

namespace Running_Median_Unit_Test
{
    [TestClass]
    public class TestMedianFinder
    {

        [TestMethod]
        public void Test1()
        {
            MedianFinder mf = new MedianFinder();
            mf.AddNum(40);
            mf.FindMedian();
            mf.AddNum(12);
            mf.FindMedian();
            mf.AddNum(16);
            mf.FindMedian();
            mf.AddNum(14);
            mf.FindMedian();
            mf.AddNum(35);
            mf.FindMedian();
            mf.AddNum(19);
            mf.FindMedian();
            mf.AddNum(34);
            mf.FindMedian();
            mf.AddNum(35);
            mf.FindMedian();
            mf.AddNum(28);
            mf.FindMedian();
            mf.AddNum(35);
            mf.FindMedian();
            mf.AddNum(26);
            mf.FindMedian();
            mf.AddNum(6);
            mf.FindMedian();
            mf.AddNum(8);
            mf.FindMedian();
            mf.AddNum(2);
            mf.FindMedian();
            mf.AddNum(14);
            mf.FindMedian();
            mf.AddNum(25);
            mf.FindMedian();
            mf.AddNum(25);
            mf.FindMedian();
            mf.AddNum(4);
            mf.FindMedian();
            mf.AddNum(33);
            mf.FindMedian();
            mf.AddNum(18);
            mf.FindMedian();
            mf.AddNum(10);
            mf.FindMedian();
            mf.AddNum(14);
            mf.FindMedian();
            mf.AddNum(27);
            mf.FindMedian();
            mf.AddNum(3);
            mf.FindMedian();
            mf.AddNum(35);
            mf.FindMedian();
            mf.AddNum(13);
            mf.FindMedian();
            mf.AddNum(24);
            mf.FindMedian();
            mf.AddNum(27);
            mf.FindMedian();
            mf.AddNum(14);
            mf.FindMedian();
            mf.AddNum(5);
            mf.FindMedian();
            mf.AddNum(0);
            mf.FindMedian();
            mf.AddNum(38);
            mf.FindMedian();
            mf.AddNum(19);
            mf.FindMedian();
            mf.AddNum(25);
            mf.FindMedian();
            mf.AddNum(11);
            mf.FindMedian();
            mf.AddNum(14);
            mf.FindMedian();
            mf.AddNum(31);
            mf.FindMedian();
            mf.AddNum(30);
            mf.FindMedian();
            mf.AddNum(11);
            mf.FindMedian();
            mf.AddNum(31);
            mf.FindMedian();
            mf.AddNum(0);
            mf.FindMedian();
        }

    }
}

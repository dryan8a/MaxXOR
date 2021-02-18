using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using MaxXOR;

namespace MaxXORTests
{
    public class Test
    {
        [Theory]
        [ClassData(typeof(Data))]
        public void NaiveTest(int expectedMax, int[] nums)
        {
            int testedMax = MaxXORFuncs.GetNaive(nums);
            Assert.Equal(expectedMax, testedMax);
        }

        [Theory]
        [ClassData(typeof(Data))]
        public void EfficientTest(int expectedMax, int[] nums)
        {
            int testedMax = MaxXORFuncs.GetEfficient(nums);
            Assert.Equal(expectedMax, testedMax);
        }
    }

    public class Data : IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>
        {
            new object[] {7, new[] { 1, 2, 3, 4, 5, 6, 7 }},
            new object[] {111, new[] { 100, 65, 64, 2, 0, 11, 46 }},
            new object[] {95, new[] { 29, 10, 7, 90, 5, 3 }},
            new object[] {1088, new[] { 2, 1024, 8, 64 }}, 
            new object[] {48, new[] { 1, 2, 4, 8, 16, 32 }},
            new object[] {1004, new[] { 256, 255, 14, 4, 4, 1000, 3 }}
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

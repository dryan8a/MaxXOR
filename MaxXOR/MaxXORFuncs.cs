using System;
using System.Collections.Generic;
using System.Text;

namespace MaxXOR
{
    public static class MaxXORFuncs
    {
        public static int GetNaive(int[] nums)
        {
            int currentMax = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    currentMax = Math.Max(nums[i] ^ nums[j], currentMax);
                }
            }
            return currentMax;
        }

        public static int GetEfficient(int[] nums)
        {
            int currentMax;

            throw new NotImplementedException();
        }
    }
}

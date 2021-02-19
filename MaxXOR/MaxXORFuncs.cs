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
            int currentMax = 0;
            int prefix = 0;

            HashSet<int> prefixedNums = new HashSet<int>(); //HashSet used so that duplicates aren't added

            for(int bit = 30;bit >= 0;bit--)
            {
                prefix |= 1 << bit; //sets the current bit to 1

                foreach(int num in nums)
                {
                    prefixedNums.Add(num & prefix); 
                }

                int potentialNewMax = currentMax | (1 << bit); 
                foreach(int prefixedNum in prefixedNums)
                {
                    if(prefixedNums.Contains(potentialNewMax ^ prefixedNum))
                    {
                        currentMax = potentialNewMax;
                        break;
                    }
                }
                prefixedNums.Clear();
            }

            return currentMax;
        }
    }
}

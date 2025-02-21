using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRepo._3046SeparateArray
{
    public class Separate
    {
        public bool IsPossibleToSplit(int[] nums)
        {
            bool result = false;
            Dictionary<int, int> set1 = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set1.ContainsKey(nums[i]))
                {
                    set1.Add(nums[i], 1);
                }
                else
                {
                    set1[nums[i]]++;
                }
            }
            result = !set1.Values.Any(x => x >= 3);
            return result;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRepo.RotateArray
{
    public class Rotate
    {
        public void Rotation(int[] nums, int k)
        {
            k = k % nums.Length;
            int[] temp = nums.Skip(nums.Length - k).ToArray();
            for (int i = k; i >= 0; i--)
            {
                nums[k + i] = nums[i];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                nums[i] = temp[i];
            }

            //k = k % nums.Length;           
            //Array.Reverse(nums,nums.Length-k, k);
            //Array.Reverse(nums, 0, nums.Length-k);
            //Array.Reverse(nums);
        }
    }
}

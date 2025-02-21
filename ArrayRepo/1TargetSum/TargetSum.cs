using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayRepo.TargetSum;

namespace ArrayRepo.TargetSum
{
    internal class TargetSum
    {
        public int[] arr = new int[] { 2, 7, 11, 15 };

        public int[] Sum(int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int diff = target - arr[i];
                if (dict.ContainsKey(diff))
                {
                    return new int[] { dict[diff], i };
                }
                else
                {
                    dict.Add(arr[i], i);
                }
            }
            throw new Exception("not found");
        }
    }
}

//TargetSum sum = new TargetSum();
//var a = sum.Sum(9);




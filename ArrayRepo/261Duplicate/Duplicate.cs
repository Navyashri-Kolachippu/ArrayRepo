using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRepo._261Duplicate
{
    public class Duplicate
    {

        public bool ContainsDuplicate(int[] nums)
        {
            bool value= true;
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(hs.Contains(nums[i]))
                {
                    value = false;
                    return value;
                }
                else
                {
                    hs.Add(nums[i]);
                }
            }

            return value;
        }
    }

    //Duplicate ds = new Duplicate();
    //    int[] data = new int[] { 1, 2, 3, 1 };
    //    var a = ds.ContainsDuplicate(data);

    }

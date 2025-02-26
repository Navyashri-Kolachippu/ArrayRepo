using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRepo.UniqueOccurance
{
    public class Unique
    {
        public bool UniqueOccurrences(int[] arr)
        {
            bool flag = false;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            HashSet<int> uniqueValues = new HashSet<int>(dict.Values);

            flag = uniqueValues.Count() == dict.Count();

            return flag;
        }
    }
}

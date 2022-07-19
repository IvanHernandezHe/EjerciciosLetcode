using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int [] arreglo1 = new int[] { 2, 7, 11, 15 };
            int meta = 9;

            TwoSum(arreglo1, meta);
            
            Console.WriteLine("");
            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int [] TwoSum2 = new int[2];

            for (int i = 0; i <= nums.Length; i++)
            {
                if (nums[i] + nums[i + 1] == target)
                {
                    TwoSum2[i] = nums[i];
                    Console.WriteLine(nums[i]);
                    TwoSum2[i + 1] = nums[i + 1];
                    Console.WriteLine(nums[i + 1]);
                }
            }

            return TwoSum2;
        }
    }
}

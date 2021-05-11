// Solution in C#
using System;

namespace ConsoleApp
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int[] array = { -6, 0, 2, 40 };
            int result = Solution.HasSameNumberAsIndex(array);
            Console.WriteLine("{0}", result == -1 ? "False" : Convert.ToString(result));
        }
        public static int HasSameNumberAsIndex(int[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] == i)
                {
                    return array[i];
                }
            }
            return -1;
        }

    }

}

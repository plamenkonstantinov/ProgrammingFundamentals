using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sumOfRotations = new int[nums.Length];

            for (int curRotation = 0; curRotation < rotations; curRotation++)
            {
                int lastElement = nums[nums.Length - 1];
                for (int curElement = nums.Length - 1; curElement>0 ; curElement--)
                {
                    nums[curElement] = nums[curElement - 1];
                }
                nums[0] = lastElement;
                for (int curElement = 0; curElement < nums.Length; curElement++)
                {
                    sumOfRotations[curElement] += nums[curElement];
                }
            }
            Console.WriteLine(string.Join(" ", sumOfRotations));
        }
    }
}

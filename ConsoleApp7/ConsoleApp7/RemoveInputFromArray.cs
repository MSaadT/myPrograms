////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace ConsoleApp7
////{
////    internal class RemoveInputFromArray
////    {
////    }
////}

////Assignment 3 - Question 1

////Solution # 1
//{
//    int[] nums = { 3, 2, 2, 3 };
//    int val = 3, k = 0;

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] != val)
//        {
//            nums[k] = nums[i];
//            k++;
//        }
//    }
//    Console.WriteLine("Array Length: k = " + k);

//    Array.Resize(ref nums, k);

//    Console.Write("Updated nums array: ");
//    for (int i = 0; i < nums.Length; i++)
//    {
//        Console.Write(nums[i] + ", ");
//    }
//}

////Solution # 2
//{
//    int[] nums = { 3, 2, 2, 3 };
//    int val = 3, k = 0;

//    Console.Write("After removing " + val + " from the nums array: ");
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] != val)
//        {
//            nums[k] = nums[i];
//            Console.Write(nums[k] + ", ");
//            k++;
//        }
//    }
//    Console.WriteLine();
//    Console.WriteLine("Array Length: k = " + k);
//}

////Solution # 3
//{
//    int[] nums = { 3, 2, 2, 3 };
//    int val = 3;
//    int temp;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] == val)
//        {
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (nums[j] != val)
//                {
//                    temp = nums[i];
//                    nums[i] = nums[j];
//                    nums[j] = temp;
//                }
//            }
//        }
//    }

//    foreach (int x in nums)
//    {
//        if (x != val)
//        {
//            Console.Write(x + " ");
//        }
//    }
//}
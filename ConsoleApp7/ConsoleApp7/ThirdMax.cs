////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace ConsoleApp7
////{
////    internal class ThirdMax
////    {
////    }
////}
////{
////Assignment 3 - Question # 3

//{
//    int[] array = { 3, 2, 1 };
//    int firstHighest = array[0], secondHighest = int.MinValue, thirdHighest = int.MinValue;
//    for (int i = 1; i < array.Length; i++)
//    {
//        if (array[i] > firstHighest)
//        {
//            thirdHighest = secondHighest;
//            secondHighest = firstHighest;
//            firstHighest = array[i];
//        }
//        else if (array[i] > secondHighest)
//        {
//            thirdHighest = secondHighest;
//            secondHighest = array[i];
//        }
//        else if (array[i] > thirdHighest)
//        {
//            thirdHighest = array[i];
//        }
//    }
//    if (array.Length >= 3)
//    {
//        Console.Write("Third highest element: " + thirdHighest);
//    }
//    else
//    {
//        Console.WriteLine("No Third Maximum Present in the Array");
//        Console.WriteLine("First Maximum: " + firstHighest);
//    }
//}
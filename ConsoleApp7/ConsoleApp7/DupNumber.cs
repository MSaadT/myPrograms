using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class DupNumber
    {
        //internal class Program
        //{
        //    private static void Main()
        //    {
        //        Program.DupNum();
        //    }
        //    public static void DupNum()
        //    {
        //        //int[] socks = { 1, 1, 2, 3, 4, 10, 2, 4, 11, 4, 4, 2 };
        //        //int[] pair;

        //        //for (int i = 1; i < socks.Length; i++)
        //        //{

        //        //}
        //        int[] socks = { 1, 1, 2, 3, 4, 10, 2, 4, 11, 4, 4, 2 };
        //        Dictionary<int, int> count = new Dictionary<int, int>();
        //        List<int> pairs = new List<int>();

        //        foreach (int num in socks)
        //        {
        //            if (count.ContainsKey(num))
        //            {
        //                count[num]++;
        //                if (count[num] % 2 == 0)
        //                {
        //                    pairs.Add(num);
        //                }
        //            }
        //            else
        //            {
        //                count[num] = 1;
        //            }
        //        }

        //        int[] pairsArray = pairs.ToArray();
        //        Console.WriteLine(string.Join(",", pairsArray));

        //    }
        //}

        //---------------------------------------------------------------------------------------------

        //internal class Program
        //{
        //    public static void ShowPairs()
        //    {
        //        int[] socks = { 1, 1, 2, 3, 4, 10, 2, 4, 11, 4, 4, 2 };
        //        int[] pairs = new int[socks.Length];

        //        int count = 0;

        //        Array.Sort(socks);

        //        for (int i = 0; i < socks.Length - 1; i++)
        //        {
        //            if (socks[i] == socks[i + 1])
        //            {
        //                pairs[count] = socks[i];
        //                count++;
        //                i = i + 1;
        //            }
        //        }

        //        Console.Write("No. of Pairs in sock's Array are: ");
        //        for (int i = 0; i < count; i++)
        //        {
        //            Console.Write(pairs[i] + ", ");
        //        }
        //        Console.WriteLine();
        //        Console.WriteLine("Total num of Pairs: " + count);
        //    }
        //    static void Main(String[] args)
        //    {
        //        Program.ShowPairs();
        //    }
        //}
    }
}

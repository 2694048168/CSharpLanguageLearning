/**
 * @file 12_for_each.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-17
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 12_for_each.cs /out:a.exe
 *
 * --------------------------------------
 *  C# 中 for-each 循环, 有点类似 C++ 中 for-range
 * --------------------------------------
 *
 */

using System;

namespace WeiLi
{
    class ExecuteMain
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 6, 13, 5, 22, 33 };

            // 有点类似 C++ 中 for-range
            foreach (int elem in arr)
            {
                System.Console.WriteLine("{0}", elem);

            }

            // --------------------------------
            int[] arr_sum = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arr_sum[i] = i + 1;
            }

            int sum = 0;
            foreach (int elem in arr_sum)
            {
                sum = sum + elem;
            }
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("1~100 以内数字的和为：{0}", sum);

            System.Console.ReadKey();
        }
    }

}

/**
 * @file 16_Array.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-17
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 16_Array.cs /out:a.exe
 *
 * --------------------------------------
 *  C# Array class
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
            // 创建一个数组并赋值 
            int[] arr = new int[6] { 15, 33, 29, 55, 10, 11 };
            // 创建一个空数组
            int[] arr2 = new int[6];

            // 获取数组的长度
            Console.WriteLine("数组 arr 的长度为：" + arr.Length);

            // 为数组排序
            Array.Sort(arr);
            Console.Write("排序后的数组 arr 为：");
            // 打印排序后的 arr
            PrintArray(arr);

            // 查找数组元素的索引
            Console.WriteLine("\n数组 arr 中值为 29 的元素的索引为：" + Array.IndexOf(arr, 29));

            // 拷贝 arr 到 arr2 
            Array.Copy(arr, arr2, arr.Length);
            Console.Write("打印数组 arr2：");
            // 打印数组 arr2 
            PrintArray(arr2);

            Array.Reverse(arr);
            Console.Write("\n反序排列数组 arr： ");
            PrintArray(arr);

            // Console.ReadLine();
        }

        static void PrintArray(int[] arr)
        {
            foreach (Object elem in arr)
            {
                Console.Write(elem + " ");
            }
        }
    }
}

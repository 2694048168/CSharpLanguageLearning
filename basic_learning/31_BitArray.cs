/**
 * @file 31_BitArray.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-24
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 31_BitArray.cs /out:a.exe
 *
 * ----------------------------------------------------
 *  C# BitArray：点阵列
 *  
 * ----------------------------------------------------
 *
 */

using System;
using System.Collections;

namespace WeiLi
{
    class ExecuteMain
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("--------------------------------");
            // 创建两个大小为 8 的点阵列
            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);
            byte[] a = { 60 };
            byte[] b = { 13 };

            // 把值 60 和 13 存储到点阵列中
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);

            // ba1 的内容
            System.Console.WriteLine("点阵列 ba1: 60");
            for (int i = 0; i < ba1.Count; i++)
            {
                System.Console.Write("{0, -6} ", ba1[i]);
            }
            System.Console.WriteLine();

            // ba2 的内容
            Console.WriteLine("点阵列 ba2: 13");
            for (int i = 0; i < ba2.Count; i++)
            {
                System.Console.Write("{0, -6} ", ba2[i]);
            }
            System.Console.WriteLine();


            BitArray ba3 = new BitArray(8);
            ba3 = ba1.And(ba2);

            // ba3 的内容
            System.Console.WriteLine("执行按位与操作后的点阵列 ba3:");
            for (int i = 0; i < ba3.Count; i++)
            {
                System.Console.Write("{0, -6} ", ba3[i]);
            }

            System.Console.WriteLine();

            ba3 = ba1.Or(ba2);

            // ba3 的内容
            System.Console.WriteLine("执行按位或操作后的点阵列 ba3:");
            for (int i = 0; i < ba3.Count; i++)
            {
                System.Console.Write("{0, -6} ", ba3[i]);
            }

            System.Console.WriteLine();

            // System.Console.ReadKey();
        }
    }
}

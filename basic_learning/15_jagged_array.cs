/**
 * @file 15_jagged_array.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-17
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 15_jagged_array.cs /out:a.exe
 *
 * --------------------------------------
 *  C# 值传递、引用传递、输出传递
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
            // jagged array 交错数组
            int[][] arr = new int[3][]{
                new int[]{31, 22, 16, 88},
                new int[]{21, 54, 6, 77, 98, 52},
                new int[]{112, 25}
            };

            // 遍历数组
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------");

            string[] names = { "小明", "小红", "小强" };
            string[] course = { "语文", "数学", "英语" };
            int[][] achievement = {
                new int[]{98, 85, 90},
                new int[]{91, 95, 93},
                new int[]{88, 89, 97},
            };

            for (int i = 0; i < names.Length; i++)
            {
                string str = "";
                for (int j = 0; j < achievement[i].Length; j++)
                {
                    str += course[j] + " " + achievement[i][j] + "，";
                }
                Console.WriteLine("{0}的成绩为：{1}", names[i], str);
            }

            // Console.ReadLine();
        }
    }
}

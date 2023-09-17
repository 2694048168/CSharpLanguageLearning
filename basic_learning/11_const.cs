/**
 * @file 11_const.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-17
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 11_const.cs /out:const.exe
 *
 * --------------------------------------
 *  1. C# 常量
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
            // const 修饰常量, 类似C++中对常量的理解
            const double PI = 3.1415926;

            double radius;
            System.Console.WriteLine("Please enter a number for radius of circle: ");
            radius = System.Convert.ToDouble(System.Console.ReadLine());

            double area_circle = PI * radius * radius;
            System.Console.WriteLine("The radius: {0}, and the area: {1}", radius, area_circle);

            System.Console.ReadKey();
        }
    }

}

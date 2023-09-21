/**
 * @file 25_attribute.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-21
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 25_attribute.cs /out:a.exe
 *
 * ----------------------------------------------------
 *  C# 特性（Attribute）
 * 特性（Attribute）是一种用于在程序运行时传递各种元素（例如类、方法、结构、枚举等）
 * 行为信息的声明性代码。使用特性可以将元数据（例如编译器指令、注释、描述、方法和类等信息）添加到程序中。
 * .Net Framework 提供了两种类型的特性，分别是预定义特性和自定义特性。
 * 
 * 在 C# 中，特性具有以下属性：
 * 1. 使用特性可以向程序中添加元数据，元数据是指程序中各种元素的相关信息，
 *      所有 .NET 程序中都包含一组指定的元数据；
 * 2. 可以将一个或多个特性应用于整个程序、模块或者较小的程序元素（例如类和属性）中；
 * 3. 特性可以像方法和属性一样接受自变量；
 * 4. 程序可使用反射来检查自己的元数据或其他程序中的元数据。
 * ----------------------------------------------------
 *
 */

// commit the following line if you want to know what happen
#define DEBUG

using System;
using System.Diagnostics;


namespace WeiLi
{
    class ExecuteMain
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("--------------------------------");
            MyPrint.message("Main function");
            function_1();

            // 预定义特性 Obsolete 用来标记不应被使用的程序，
            // 可以使用它来通知编译器放弃某个目标元素, 版本升级引起的 API 变化
            System.Console.WriteLine("--------------------------------");
            OldMethod();

            // System.Console.ReadKey();
        }

        static void function_1()
        {
            MyPrint.message("Function 1");
            function_2();
        }

        static void function_2()
        {
            MyPrint.message("Function 1");
        }

        [Obsolete("OldMethod 已弃用，请改用 NewMethod", false)]
        // [Obsolete("OldMethod 已弃用，请改用 NewMethod", true)]
        static void OldMethod()
        {
            Console.WriteLine("已弃用的函数");
        }
        static void NewMethod()
        {
            Console.WriteLine("新定义的函数");
        }

    }

    public class MyPrint
    {
        [Conditional("DEBUG")]
        public static void message(string msg)
        {
            System.Console.WriteLine(msg);
        }
    }

}

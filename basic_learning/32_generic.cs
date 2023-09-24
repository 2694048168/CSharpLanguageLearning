/**
 * @file 32_generic.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-24
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 32_generic.cs /out:a.exe
 *
 * ----------------------------------------------------
 *  C# 泛型（Generic）, 有点类似C++中模板类和模板函数的功效
 *  在 C# 中，泛型（Generic）是一种规范，它允许我们使用占位符来定义类和方法，
 * 编译器会在编译时将这些占位符替换为指定的类型，
 * 利用泛型的这一特性可以定义通用类（泛型类）或方法（泛型方法）
 * ----------------------------------------------------
 *
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace WeiLi
{
    // 定义泛型类
    class GenericClass<T>
    {
        // 泛型方法
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    class ExecuteMain
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("--------------------------------");
            string msg = "wei li GitHub: https://github.com/2694048168";

            GenericClass<string> str_gen = new GenericClass<string>(msg);
            GenericClass<int> int_gen = new GenericClass<int>(42);
            GenericClass<char> char_gen = new GenericClass<char>('A');

            // 通过类型参数声明泛型方法
            System.Console.WriteLine("--------------------------------");
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            // 在交换之前显示值
            System.Console.WriteLine("调用 swap 之前的 Int 值:");
            System.Console.WriteLine("a = {0}, b = {1}", a, b);
            System.Console.WriteLine("调用 swap 之前的字符值:");
            System.Console.WriteLine("c = {0}, d = {1}", c, d);

            // 调用 swap
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            // 在交换之后显示值
            System.Console.WriteLine("调用 swap 之后的 Int 值:");
            System.Console.WriteLine("a = {0}, b = {1}", a, b);
            System.Console.WriteLine("调用 swap 之后的字符值:");
            System.Console.WriteLine("c = {0}, d = {1}", c, d);

            // 使用类型参数定义泛型委托
            System.Console.WriteLine("--------------------------------");
            // 创建委托实例
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MulNum);
            // 使用委托对象调用方法
            nc1(42);
            System.Console.WriteLine("Num 的值为: {0}", getNum());
            nc2(2);
            System.Console.WriteLine("Num 的值为: {0}", getNum());

            // System.Console.ReadKey();
        }

        delegate T NumberChanger<T>(T n);
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MulNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
    }
}

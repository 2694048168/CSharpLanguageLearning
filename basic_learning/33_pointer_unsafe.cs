/**
 * @file 33_pointer_unsafe.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-24
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 33_pointer_unsafe.cs /unsafe /out:a.exe
 *
 * ----------------------------------------------------
 *  C# 指针变量与 unsafe
 *  为了保持类型的安全性，默认情况下 C# 是不支持指针的，
 * 但是如果使用 unsafe 关键字来修饰类或类中的成员，这样的类或类中成员就会被视为不安全代码，
 * C# 允许在不安全代码中使用指针变量。
 * 在公共语言运行时 (CLR) 中，不安全代码是指无法验证的代码，不安全代码不一定是危险的，
 * 只是 CLR 无法验证该代码的安全性。因此 CLR 仅会执行信任程序集中包含的不安全代码。）
 *
 * 为了编译不安全代码，在编译时必须使用unsafe命令
 * 使用的是 Visual Studio，那么您需要在项目属性中启用不安全代码
 * ----------------------------------------------------
 *
 */

using System;

namespace WeiLi
{
    class ExecuteMain
    {
        static unsafe void Main(string[] args)
        // static void Main(string[] args)
        {
            // C# 中 unsafe 关键字和指针的使用
            System.Console.WriteLine("--------------------------------");
            double f = 3.1415;
            double* p = &f;

            Console.WriteLine("数据的内容是: {0} ", f);
            Console.WriteLine("数据在内存中的地址是: {0}", (int)p);

            System.Console.WriteLine("--------------------------------");
            unsafe
            {
                int var = 123456;
                int* ptr = &var;
                Console.WriteLine("变量 var 的值为: {0} ", var);
                Console.WriteLine("指针 ptr 指向的值为: {0} ", ptr->ToString());
                Console.WriteLine("指针 ptr 的值为: {0} ", (int)ptr);
            }

            // 将指针作为参数传递给函数
            System.Console.WriteLine("--------------------------------");
            ExecuteMain obj = new ExecuteMain();

            int var1 = 10;
            int var2 = 20;
            int* x = &var1;
            int* y = &var2;

            Console.WriteLine("调用 Swap 函数前: var1: {0}, var2: {1}", var1, var2);
            obj.swap(x, y);
            Console.WriteLine("调用 Swap 函数后: var1: {0}, var2: {1}", var1, var2);

            // 使用指针访问数组元素
            System.Console.WriteLine("--------------------------------");
            int[] list = { 10, 100, 200 };

            /* 显示指针中数组地址 */
            fixed (int* ptr = list)
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("list[{0}] 的内存地址为：{1}", i, (int)(ptr + i));
                    Console.WriteLine("list[{0}] 的值为：{1}", i, *(ptr + i));
                }

            // System.Console.ReadKey();
        }

        public unsafe void swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }

    }
}

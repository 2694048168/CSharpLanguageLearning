/**
 * @file 14_parameter_pass.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-17
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 14_parameter_pass.cs /out:a.exe
 *
 * --------------------------------------
 *  C# 值传递、引用传递、输出传递, 参数数组
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
            System.Console.WriteLine("-----------------------");
            int val = 42;

            Console.WriteLine("调用函数之前：{0}", val);
            func_pass_value(val);
            Console.WriteLine("调用函数之后：{0}", val);


            System.Console.WriteLine("-----------------------");
            Console.WriteLine("调用函数之前：{0}", val);
            func_pass_reference(ref val);
            Console.WriteLine("调用函数之后：{0}", val);

            System.Console.WriteLine("-----------------------");
            ExecuteMain obj = new ExecuteMain();

            string name = "jx";
            int age = 66;

            Console.WriteLine("调用函数之前 age 的值：{0}, name: {1}", age, name);
            obj.getInfo(out name, out age);
            Console.WriteLine("调用函数之后 age 的值：{0}, name: {1}", age, name);

            System.Console.WriteLine("-----------------------");
            string str = obj.getSum(1, 2, 3, 4, 5, 6);
            Console.WriteLine(str);

            int[] arr = { 2, 4, 6, 8, 10 };
            string str2 = obj.getSum(arr);
            Console.WriteLine(str2);
        }

        // C# 参数数组, 有点类似 C++ 中可变参数列表的感觉
        public string getSum(params int[] arr)
        {
            int sum = 0;
            string str = "";

            foreach (int elem in arr)
            {
                sum += elem;
                str += "+ " + elem + " ";
            }

            str = str.Trim('+');
            str += "= " + sum;
            return str;
        }

        // 使用 return 可从函数中返回一个值，但是使用输出传递则可以从函数中一次性返回多个值。
        // 输出传递与引用传递相似，不同之处在于输出传递是将数据从函数中传输出来而不是传输到函数中。
        public void getInfo(out string name, out int age)
        {
            int magic_number = 42;
            age = magic_number;

            string filename = "filename";
            name = filename;
        }

        static void func_pass_value(int val)
        {
            val *= val;
            Console.WriteLine("函数内部的值：{0}", val);
        }

        static void func_pass_reference(ref int val)
        {
            val *= val;
            Console.WriteLine("函数内部的值：{0}", val);
        }

    }

}

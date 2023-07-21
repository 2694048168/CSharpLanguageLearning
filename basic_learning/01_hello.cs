/**
 * @file 01_hello.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-07-18
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 01_hello.cs /out:hello.exe
 *
 */

using System; 

namespace ProgramVariable
{
    class Program
    {
        // the main entry of program
        static void Main(string[] args)
        {
            // namespace.class.method(function),
            // .NET core or .NET framework 提供,
            System.Console.WriteLine("Hello, welcome to C-Sharp programming world.");
            // System.Console.WriteLine("Hello, Wei Li, welcome\n");
            Console.WriteLine("Hello, Wei Li, welcome\n");

            // variable in C-Sharp
            // var similar as "auto" in C++, 语法糖?
            var num1 = 24;
            var num2 = 42;
            var sum = 0;
            sum = num1 + num2;
            System.Console.WriteLine("the sum of two integer: {0}", sum);

            int num3 = 2023;
            int num4 = 25;
            int result = num3 + num4;
            // System.Console.WriteLine("the result of two number add: {0}", result);
            string msg = "the result of two number add: ";
            System.Console.WriteLine("{0}{1}", msg, result);

            sum = num1 + num4;
            System.Console.WriteLine("the sum of two integer: {0}", sum);

            System.Console.ReadLine();
            // Console.ReadLine();
        }
    }
}
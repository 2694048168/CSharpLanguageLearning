/**
 * @file 13_function.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-17
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 13_function.cs /out:a.exe
 *
 * --------------------------------------
 *  C# 中 function or method, and static method
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
            string msg = "Wei Li";

            // 非静态方法，首先对类进行实例化
            ExecuteMain obj = new ExecuteMain();
            string str = obj.print(msg);
            System.Console.WriteLine(str);

            // 静态方法不需要实例化即可调用
            display(3);

            // --------- internal
            System.Console.WriteLine("-----------------------");
            Rectangle rect = new Rectangle();
            rect.length = 33.2;
            rect.width = 30.9;
            rect.Display();
        }

        public string print(string msg)
        {
            string str = "Hello, " + msg;

            return str;
        }

        static void display(int repeat)
        {
            for (int i = 0; i < repeat; ++i)
            {
                System.Console.WriteLine("Hello {0} World", i);
            }
        }

        class Rectangle
        {
            // 成员变量, 访问权限控制, internal 同一命名空间
            internal double width, length;

            double GetArea()
            {
                return width * length;
            }

            public void Display()
            {
                Console.WriteLine("长方形的长：{0}", length);
                Console.WriteLine("长方形的宽：{0}", width);
                Console.WriteLine("长方形的面积：{0}", GetArea());
            }
        }

    }

}

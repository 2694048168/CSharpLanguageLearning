/**
 * @file 21_polymorphism.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-18
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 21_polymorphism.cs /out:a.exe
 *
 * --------------------------------------
 *  C# 中面向对象编程的特性, 封装 + 继承 + 多态 
 *  理念上和C++类似，实现上和C++有点差异
 * 
 * 编译时多态：通过 C# 中的方法重载和运算符重载来实现编译时多态，也称为静态绑定或早期绑定；
 * 运行时多态：通过方法重载实现的运行时多态，也称为动态绑定或后期绑定。
 * 
 * C# 提供了两种技术来实现编译时多态，分别是函数重载和运算符重载
 * C# 允许您使用 abstract 关键字(C++ 中 virtual)来创建抽象类，抽象类用于实现部分接口
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
            // 函数重载
            ExecuteMain p = new ExecuteMain();
            p.print(42);
            p.print("Wei Li");
            p.print(3.1415926);

            System.Console.WriteLine("--------------------------------");
            Rectangle r = new Rectangle(12, 15);
            double a = r.area();
            Console.WriteLine("长方形的面积为： {0}", a);

            // System.Console.ReadKey();
        }

        void print(int i)
        {
            Console.WriteLine("打印 int 类型的数据：{0}", i);
        }
        void print(double d)
        {
            Console.WriteLine("打印 double 类型的数据：{0}", d);
        }
        void print(string s)
        {
            Console.WriteLine("打印 string 类型的数据：{0}", s);
        }
    }

    abstract class Shape
    {
        // 通过关键字 abstract 明确复写子类的一定要实现该接口
        public abstract int area();
    }
    class Rectangle : Shape
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        // 通过关键字 override 明确复写抽象基类的虚函数(C# abstract)
        public override int area()
        {
            return (width * height);
        }
    }
}

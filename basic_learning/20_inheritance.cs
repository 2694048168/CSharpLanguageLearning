/**
 * @file 20_inheritance.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-18
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 20_inheritance.cs /out:a.exe
 *
 * --------------------------------------
 *  C# 中面向对象编程的特性, 封装 + 继承 + 多态 
 *  理念上和C++类似，实现上和C++有点差异
 * C# 中只支持单继承，一个派生类只能继承一个基类，但是继承是可以传递的
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
            Rectangle oblong = new Rectangle();
            oblong.setWidth(3);
            oblong.setHeight(4);

            int area = oblong.getArea();
            Console.WriteLine("长方形的面积为：{0}", area);

            // 多重继承则是指一个类可以同时继承多个基类，C# 并不支持多重继承
            // 但是可以借助接口来实现多重继承
            System.Console.WriteLine("--------------------------------");
            RectangleMulti obj = new RectangleMulti();
            obj.setWidth(6);
            obj.setHeight(8);

            area = obj.getArea();
            int girth = obj.getGirth();

            Console.WriteLine("长方形的面积为：{0}", area);
            Console.WriteLine("长方形的周长为：{0}", girth);

            // System.Console.ReadKey();
        }
    }

    // 基类
    class Shape
    {
        protected int width;
        protected int height;
        public void setWidth(int width)
        {
            this.width = width;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
    }
    // 派生类
    class Rectangle : Shape
    {
        public int getArea()
        {
            return width * height;
        }
    }

    // 定义接口
    public interface Perimeter
    {
        int getGirth();
    }
    // 派生类
    class RectangleMulti : Shape, Perimeter
    {
        public int getArea()
        {
            return width * height;
        }
        public int getGirth()
        {
            return (width + height) * 2;
        }
    }

}

/**
 * @file 10_rectangle.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-17
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 10_rectangle.cs /out:rectangle.exe
 *
 * --------------------------------------
 *  1. 创建 Rectangle 对象，用它来表示长方形
 *  2. Rectangle 对象中具有 length（长）和 width（宽）两个属性
 *  3. 如果要计算长方形面积的话，则可以使用一个方法来接收 length 和 width 这两个属性的值
 * --------------------------------------
 *
 */

using System;

namespace WeiLi
{
    class Rectangle
    {
        double length;
        double width;


        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            System.Console.WriteLine("Length: {0}", length);
            System.Console.WriteLine("Width: {0}", width);
            System.Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.AcceptDetails();
            rect.Display();
            System.Console.ReadLine();
        }
    }

}

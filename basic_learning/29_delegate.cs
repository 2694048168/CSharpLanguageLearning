/**
 * @file 29_delegate.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-24
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 29_delegate.cs /out:a.exe
 *
 * ----------------------------------------------------
 *  C# 委托（Delegate）
 * C# 中的委托（Delegate）类似于 C 或 C++ 中的函数指针，是一种引用类型，
 * 表示对具有特定参数列表和返回类型的方法的引用。
 * 委托特别适用于实现事件和回调方法，所有的委托都派生自 System.Delegate 类。
 * ----------------------------------------------------
 *
 */

using System;
using System.IO;

// 定义委托
delegate int NumberChanger(int n);

namespace WeiLi
{
    class ExecuteMain
    {
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

        static void Main(string[] args)
        {
            // 委托的声明、实例化和使用，该委托可用于引用带有一个整型参数的方法，并返回一个整型值
            System.Console.WriteLine("--------------------------------");
            // 创建委托实例
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MulNum);

            // 使用委托对象调用方法
            nc1(25);
            Console.WriteLine("num 的值为: {0}", getNum());

            nc2(5);
            Console.WriteLine("num 的值为: {0}", getNum());

            // 委托对象有一个非常有用的属性，那就是可以通过使用 +运算符 将多个对象分配给一个委托实例，
            // 同时还可以使用 -运算符 从委托中移除已分配的对象，当委托被调用时会依次调用列表中的委托。
            // 委托的这个属性被称为委托的多播，也可称为组播，
            // 利用委托的这个属性，可以创建一个调用委托时要调用的方法列表。
            // 注意：仅可合并类型相同的委托。
            System.Console.WriteLine("--------------------------------");
            // 创建委托实例
            NumberChanger nc;
            nc = nc1;
            nc += nc2;

            // 调用多播
            nc(5);
            Console.WriteLine("num 的值为: {0}", getNum());

            // 定义一个委托 printString，使用这个委托来调用两个方法，
            // 第一个把字符串打印到控制台，第二个把字符串打印到文件
            System.Console.WriteLine("--------------------------------");
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);

            // System.Console.ReadKey();
        }

        static FileStream fs;
        static StreamWriter sw;
        // 委托声明
        public delegate void printString(string s);
        // 该方法打印到控制台
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }
        // 该方法打印到文件
        public static void WriteToFile(string s)
        {
            fs = new FileStream("./message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        // 该方法把委托作为参数，并使用它调用方法
        public static void sendString(printString ps)
        {
            ps("wei li GitHub: https://github.com/2694048168");
        }

    }
}

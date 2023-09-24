/**
 * @file 30_event.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-24
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 30_event.cs /out:a.exe
 *
 * ----------------------------------------------------
 *  C# 事件（Event
 * 在 C# 中，事件（Event）可以看作是用户的一系列操作，
 * 例如点击键盘的某个按键、单击/移动鼠标等，当事件发生时可以针对事件做出一系列的响应，
 * 例如退出程序、记录日志等等。
 * C# 中线程之间的通信就是使用事件机制实现的。
 * 
 * 事件需要在类中声明和触发，并通过委托与事件处理程序关联。
 * ----------------------------------------------------
 *
 */

using System;

namespace WeiLi
{
    class ExecuteMain
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("--------------------------------");
            Publisher e = new Publisher(); /* 实例发布器类*/
            Subscriber v = new Subscriber(); /* 实例订阅器类 */
            e.MyEvent += new Publisher.MyEntrust(v.printf);

            string msg = "wei li GitHub: https://github.com/2694048168";
            e.SetValue(msg);

            // System.Console.ReadKey();
        }
    }

    // 发布器类
    public class Publisher
    {
        private string value;
        public delegate void MyEntrust(string str);
        public event MyEntrust MyEvent;
        public void SetValue(string s)
        {
            value = s;
            MyEvent(value);     // 触发事件
        }
    }
    // 订阅器类
    public class Subscriber
    {
        public void printf(string str)
        {
            Console.WriteLine(str);
        }
    }
}

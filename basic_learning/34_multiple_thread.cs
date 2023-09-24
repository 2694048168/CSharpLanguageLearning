/**
 * @file 34_multiple_thread.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-24
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 34_multiple_thread.cs /out:a.exe
 *
 * ----------------------------------------------------
 *  C# multiple thread
 * 注意观察线程间是异步执行的
 * ----------------------------------------------------
 *
 */

using System;
using System.Threading;

namespace WeiLi
{
    class ExecuteMain
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("执行子线程");
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("--------------------------------");
            Thread th = Thread.CurrentThread;
            th.Name = "主线程";
            Console.WriteLine("这是{0}", th.Name);

            // C# 是通过扩展 Thread 类来创建线程的，
            // 然后使用扩展的 Thread 类调用 Start() 方法开始执行子线程
            System.Console.WriteLine("--------------------------------");
            ThreadStart child = new ThreadStart(CallToChildThread);
            Console.WriteLine("在 Main 函数中创建子线程");
            Thread childThread = new Thread(child);
            childThread.Start();

            // Thread 类提供了各种管理线程的方法，比如可以使用 sleep() 方法使线程在特定时间段内暂停
            System.Console.WriteLine("--------------------------------");
            ThreadStart child_sleep = new ThreadStart(CallChildThread);
            Console.WriteLine("在 Main 函数中创建子线程");
            Thread childThreadSleep = new Thread(child_sleep);
            childThreadSleep.Start();

            // Thread 类中提供了 Abort() 方法用于销毁线程
            // Abort() 方法会抛出一个 threadabortexception 异常来中止线程,这个异常不能被捕获
            System.Console.WriteLine("--------------------------------");
            ThreadStart child_ref = new ThreadStart(ChildThread);
            Console.WriteLine("在 Main 函数中创建子线程");
            Thread childThreadAbort = new Thread(child_ref);
            childThreadAbort.Start();

            // 停止主线程一段时间
            Thread.Sleep(2000);

            // 现在中止子线程
            Console.WriteLine("在 Main 函数中终止子线程");
            childThread.Abort();

            // System.Console.ReadKey();
        }

        public static void CallChildThread()
        {
            System.Console.WriteLine("执行子线程");
            // 线程暂停 5000 毫秒
            int sleep_time = 5000;
            System.Console.WriteLine("子线程暂停 {0} 秒", sleep_time / 1000);
            Thread.Sleep(sleep_time);
            System.Console.WriteLine("继续执行子线程");
        }

        public static void ChildThread()
        {
            try
            {
                Console.WriteLine("执行子线程");
                // 计数到 10
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("子线程执行完成");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("线程终止：{0}", e);
            }
            finally
            {
                Console.WriteLine("无法捕获线程异常");
            }
        }

    }
}

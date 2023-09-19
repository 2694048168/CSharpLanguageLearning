/**
 * @file 23_interface.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-19
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 23_interface.cs /out:a.exe
 *
 * --------------------------------------
 *  C# 中接口 interface
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
            Website web = new Website();
            web.setValue("wei li blog", "https://2694048168.github.io/blog/");
            web.disPlay();

            // 在 C# 中，一个接口可以继承另一个接口
            System.Console.WriteLine("--------------------------------");
            Demo demo = new Demo();
            demo.MethodToImplement();
            demo.ParentInterfaceMethod();

            // System.Console.ReadKey();
        }
    }

    public interface IParentInterface
    {
        void ParentInterfaceMethod();
    }
    public interface IMyInterface : IParentInterface
    {
        void MethodToImplement();
    }
    class Demo : IMyInterface
    {
        public void MethodToImplement()
        {
            Console.WriteLine("实现 IMyInterface 接口中的 MethodToImplement 函数");
        }
        public void ParentInterfaceMethod()
        {
            Console.WriteLine("实现 IParentInterface 接口中的 ParentInterfaceMethod 函数");
        }
    }

    public interface Iwebsite
    {
        void setValue(string str1, string str2);
        void disPlay();
    }
    public class Website : Iwebsite
    {
        public string name;
        public string url;
        public void setValue(string name, string url)
        {
            this.name = name;
            this.url = url;
        }
        public void disPlay()
        {
            Console.WriteLine("{0} {1}", name, url);
        }
    }
}

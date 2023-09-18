/**
 * @file 19_this.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-18
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 19_this.cs /out:a.exe
 *
 * --------------------------------------
 *  C# this关键字; 结构体和类, 
 *  理念上和C++类似，实现上和C++有点差异
 *  使用 this 关键字来表示当前对象，开发中使用 this 关键字来访问类中的成员属性以及函数
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
            Website site = new Website("wei li", "https://github.com/2694048168");
            site.Display();

            // 使用 this 关键字串联构造函数
            System.Console.WriteLine("--------------------------------");
            Test test = new Test("wei li");

            // 使用 this 关键字作为类的索引器
            System.Console.WriteLine("--------------------------------");
            TestIndex arr = new TestIndex();
            Console.WriteLine("Temp0: {0}, Temp1: {1}", arr[0], arr[1]);
            arr[0] = 15;
            arr[1] = 20;
            Console.WriteLine("Temp0: {0}, Temp1: {1}", arr[0], arr[1]);

            // 使用 this 关键字作为原始类型的扩展方法
            System.Console.WriteLine("--------------------------------");
            string str = "Wei Li";
            string extend_str = str.ExpandString();
            Console.WriteLine(extend_str);

            // System.Console.ReadKey();
        }

        public class Website
        {
            private string name;
            private string url;
            public Website(string n, string u)
            {
                this.name = n;
                this.url = u;
            }
            public void Display()
            {
                Console.WriteLine(name + " " + url);
            }
        }

        public class Test
        {
            public Test()
            {
                Console.WriteLine("无参构造函数");
            }
            // 这里的 this()代表无参构造函数 Test()
            // 先执行 Test()，后执行 Test(string text)
            public Test(string text) : this()
            {
                Console.WriteLine("{0} from 实例构造函数", text);
            }
        }
    }
    public class TestIndex
    {
        int Temp0;
        int Temp1;
        public int this[int index]
        {
            get
            {
                return (0 == index) ? Temp0 : Temp1;
            }

            set
            {
                if (0 == index)
                    Temp0 = value;
                else
                    Temp1 = value;
            }
        }
    }

    public static class TestExtend
    {
        public static string ExpandString(this string name)
        {
            return name + " https://github.com/2694048168";
        }
    }
}

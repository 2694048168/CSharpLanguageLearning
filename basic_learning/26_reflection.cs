/**
 * @file 26_reflection.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-21
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 26_reflection.cs /out:a.exe
 *
 * ----------------------------------------------------
 *  C# 特性（Reflection）
 * 反射（Reflection）是指程序可以访问、检测和修改它本身状态或行为的一种能力，
 * 反射中提供了用来描述程序集、模块和类型的对象，可以使用反射动态地创建类型的实例，
 * 并将类型绑定到现有对象，或者从现有对象中获取类型，然后调用其方法或访问其字段和属性。
 * 如果代码中使用了特性，也可以利用反射来访问它们。
 * 
 * C# 中反射具有以下用途：
 * 1. 在运行时查看视图属性信息；
 * 2. 检查装配中的各种类型并实例化这些类型；
 * 3. 在后期绑定到方法和属性；
 * 4. 在运行时创建新类型，然后使用这些类型执行一些任务。
 * ----------------------------------------------------
 *
 */

using System;
using System.Reflection;

namespace WeiLi
{
    // 要分配给类及其成员的自定义属性错误修复程序
    [AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]

    public class DeBugInfo : System.Attribute {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DeBugInfo(int bg, string dev, string d) {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }
        public int BugNo {
            get {
                return bugNo;
            }
        }
        public string Developer {
            get {
                return developer;
            }
        }
        public string LastReview {
            get {
                return lastReview;
            }
        }
        public string Message {
            get {
                return message;
            }
            set {
                message = value;
            }
        }
    }
    [DeBugInfo(45, "Zara Ali", "12/8/2023", Message = "返回值类型不匹配")]
    [DeBugInfo(49, "Nuha Ali", "10/10/2023", Message = "变量未使用")]

    class Rectangle {
        // 成员变量
        protected double length;
        protected double width;

        public Rectangle(double l, double w) {
            length = l;
            width = w;
        }
        [DeBugInfo(55, "Zara Ali", "19/10/2023", Message = "返回值类型不匹配")]
        public double GetArea() {
            return length * width;
        }
        [DeBugInfo(56, "Zara Ali", "19/10/2023")]
        public void Display() {
            Console.WriteLine("长: {0}", length);
            Console.WriteLine("宽: {0}", width);
            Console.WriteLine("面积: {0}", GetArea());
        }
    }

    class Demo
    {
        static void Main(string[] args) 
        {
            Rectangle r = new Rectangle(4.5, 7.5);
            r.Display();
            Type type = typeof(Rectangle);

            // 遍历 Rectangle 类的属性
            foreach (Object attributes in type.GetCustomAttributes(false)) {
                DeBugInfo dbi = (DeBugInfo)attributes;

                if (null != dbi) {
                    Console.WriteLine("Bug 编号: {0}", dbi.BugNo);
                    Console.WriteLine("开发者: {0}", dbi.Developer);
                    Console.WriteLine("上次审核时间: {0}", dbi.LastReview);
                    Console.WriteLine("评论: {0}", dbi.Message);
                }
            }

            // 遍历函数属性
            foreach (MethodInfo m in type.GetMethods()) {
                foreach (Attribute a in m.GetCustomAttributes(true)) {
                    DeBugInfo dbi = (DeBugInfo)a;

                    if (null != dbi) {
                        Console.WriteLine("Bug 编号: {0}, 函数名: {1}", dbi.BugNo, m.Name);
                        Console.WriteLine("开发者: {0}", dbi.Developer);
                        Console.WriteLine("上次审核时间: {0}", dbi.LastReview);
                        Console.WriteLine("评论: {0}", dbi.Message);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

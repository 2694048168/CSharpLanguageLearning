/**
 * @file 27_property.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-21
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 27_property.cs /out:a.exe
 *
 * ----------------------------------------------------
 *  C# Property 属性
 * 属性（Property）是类（class）、结构体（structure）和接口（interface）的成员，
 * 类或结构体中的成员变量称为字段，属性是字段的扩展，使用访问器（accessors）可以读写私有字段的值。
 * 
 * 属性没有确切的内存位置，但具有可读写或计算的访问器。
 * 例如有一个名为 Student 的类，其中包含 age、name 和 code 三个私有字段，
 * 不能在类的范围以外直接访问这些字段，但是可以访问来这些私有字段的属性。
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
            // 创建一个新的 Student 对象
            Student s = new Student();
            // 设置 student 的 code、name 和 age
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;
            Console.WriteLine("学生信息: {0}", s);
            // 增加年龄
            s.Age += 1;
            Console.WriteLine("学生信息: {0}", s);

            // System.Console.ReadKey();
        }
    }

    class Student
    {
        private string code = "N.A";
        private string name = "not known";
        private int age = 0;
        // 声明类型为 string 的 Code 属性
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        // 声明类型为 string 的 Name 属性
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        // 声明类型为 int 的 Age 属性
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "编号 = " + Code + ", 姓名 = " + Name + ", 年龄 = " + Age;
        }
    }

}

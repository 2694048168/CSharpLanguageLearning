/**
 * @file 28_indexer.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-21
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 28_indexer.cs /out:a.exe
 *
 * ----------------------------------------------------
 *  C# 索引器（Indexer）
 * 索引器（英文名：Indexer）是类中的一个特殊成员，
 * 它能够让对象以类似数组的形式来操作，使程序看起来更为直观，更容易编写。
 * 索引器与属性类似，在定义索引器时同样会用到 get 和 set 访问器，
 * 不同的是，访问属性不需要提供参数而访问索引器则需要提供相应的参数。
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
            ExecuteMain names = new ExecuteMain();

            names[0] = "Wei Li";
            names[1] = "https://github.com/2694048168/CSharpLanguageLearning";
            names[2] = "C-Sharp";
            names[3] = "Indexer";

            for (int i = 0; i < ExecuteMain.size; i++)
            {
                Console.WriteLine(names[i]);
            }

            // System.Console.ReadKey();
        }

        static public int size = 10;
        private string[] name_list = new string[size];
        public ExecuteMain()
        {
            for (int i = 0; i < size; i++)
                name_list[i] = "NULL";
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                {
                    tmp = name_list[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    name_list[index] = value;
                }
            }
        }
    }
}

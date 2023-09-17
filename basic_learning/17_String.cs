/**
 * @file 17_String.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-17
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 17_String.cs /out:a.exe
 *
 * --------------------------------------
 *  C# string（或 String）关键字是 System.String 类的别名，
 *    其中提供了定义字符串以及操作字符串的一系列方法
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
            // Step 1. compare two string
            string str1 = "wei li";
            System.String str2 = "weili";
            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " 与 " + str2 + " 相同");
            }
            else
            {
                Console.WriteLine(str1 + " 与 " + str2 + " 不同");
            }

            // Step 2. 判断一个字符串是否包含在另一个字符串中
            string str3 = "wei";
            if (str1.Contains(str3))
            {
                Console.WriteLine(str1 + " 中包含 " + str3);
            }
            else
            {
                Console.WriteLine(str1 + " 中不包含 " + str3);
            }

            // Step 3. 从一个字符串中截取指定长度的字符串
            string str = "cpp reference and C-sharp reference network";
            Console.WriteLine("原字符串：" + str);
            string sub_str = str.Substring(13);
            Console.WriteLine("截取之后的字符串：" + sub_str);

            // Step 4. 将数组中的元素合并为字符串
            string[] str_array = new string[]{
                "I",
                "love",
                "C# or C-Sharp",
                "programming language"
            };

            string str_concat = String.Join(" ", str_array);
            Console.WriteLine(str_concat);

            // Console.ReadLine();
        }

    }
}

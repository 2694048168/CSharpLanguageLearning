/**
 * @file 18_enum.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-18
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 18_enum.cs /out:a.exe
 *
 * --------------------------------------
 *  C# enum：枚举类型
 * --------------------------------------
 *
 */

using System;

namespace WeiLi
{
    class ExecuteMain
    {
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        static void Main(string[] args)
        {
            // Step 1. compare two string
            System.Console.WriteLine("Sun = {0}", (int)Day.Sun);
            System.Console.WriteLine("Mon = {0}", (int)Day.Mon);
            System.Console.WriteLine("Tue = {0}", (int)Day.Tue);
            System.Console.WriteLine("Wed = {0}", (int)Day.Wed);
            System.Console.WriteLine("Thu = {0}", (int)Day.Thu);
            System.Console.WriteLine("Fri = {0}", (int)Day.Fri);
            System.Console.WriteLine("Sat = {0}", (int)Day.Sat);

            // 使用 GetValues()  遍历枚举类型中的所有成员：
            System.Console.WriteLine("--------------------------------");
            foreach (Season i in Enum.GetValues(typeof(Season)))
            {
                Console.WriteLine("{0} = {1}", i, (int)i);
            }

            // 使用 GetNames() 遍历枚举类型中的所有成员
            System.Console.WriteLine("--------------------------------");
            foreach (String s in Enum.GetNames(typeof(Season)))
            {
                Console.WriteLine(s);
            }

            // System.Console.ReadKey();
        }

        enum Season
        {
            winter = 10,
            spring,
            summer = 15,
            autumn
        };

    }
}

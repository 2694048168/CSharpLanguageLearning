/**
 * @file 03_condition.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-07-21
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 03_condition.cs /out:condition.exe
 *
 */

namespace ProgramCondition
{
    public class Program
    {
        static void Main(string[] args)
        {
            // bool condition = true;
            bool condition = false;
            if (condition)
            {
                System.Console.WriteLine("the condition is True,");
                System.Console.WriteLine("and then execute the logic code.");
            }
            else
            {
                System.Console.WriteLine("the condition is False,");
                System.Console.WriteLine("and then execute another logic code.");
            }

            System.Console.WriteLine("please continue...");

            // ----------------------------------------------
            System.Console.WriteLine("please enter your first name and second name: ");
            string name = System.Console.ReadLine();
            // condition = name == "san su";
            // if (condition)
            if (name == "san su")
            {
                System.Console.WriteLine("your enter name is {0}", name);
                name = "fa wai san";
            }
            else if (name == "si li")
            {
                System.Console.WriteLine("your enter name is {0}", name);
                name = "fa wai si";
            }
            else if (name = "wu wang")
            {
                System.Console.WriteLine("your enter name is {0}", name);
                name = "fa wai wu";
            }
            else
            {
                System.Console.WriteLine("your enter name is {0}", name);
                name = "welcome";
            }

            // ----------------------------------------------
            // 如果有 C/C++ 基础，很容易理解 C-Sharp，
            // 逻辑运算， && || !
            // C/C++ 基础学习: https://github.com/2694048168/C-and-C-plus-plus
        }
    }
}
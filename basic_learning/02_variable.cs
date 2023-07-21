/**
 * @file 02_variable.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-07-20
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 02_variable.cs /out:variable.exe
 *
 */

namespace ProgramVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.runoob.com/csharp/csharp-data-types.html
            // 数据的计算, 不同类型数据如何处理?

            System.Console.WriteLine("Please enter an integer: ");
            string user_input = System.Console.ReadLine();
            System.Console.WriteLine("your input is : {0}", user_input);

            // int result = user_input + 42;
            // type convert in C-Sharp
            int result = int.Parse(user_input) + 42;
            
            System.Console.WriteLine("And the result is : {0}", result);

            System.Console.WriteLine("Please enter which year now(such as 2023): ");
            user_input = System.Console.ReadLine();
            string date = user_input + 0720.ToString();
            System.Console.WriteLine("the date is {0} now!", date);

            // the input and output IO in C-Sharp
            // 快捷键，cw，然后按下 TAB，
            System.Console.WriteLine("please enter your first name and second name: ");
            string name = System.Console.ReadLine();
            
            System.Console.WriteLine("please enter your country and hometown: ");
            string hometown = System.Console.ReadLine();
            
            System.Console.WriteLine("please enter your hobby: ");
            string hobby = System.Console.ReadLine();

            System.Console.WriteLine("\n\n{0} is from {1}, and he or she love {2},\n Hello, welcome to C-Sharp programming world", name, hometown, hobby);
        }
    }
}
/**
 * @file 06_exception.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-07-22
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 06_exception.cs /out:exception.exe
 *
 */

namespace ProgramException
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ------------ first-way ------------------
            // System.Console.WriteLine("please enter your age: ");
            // string age_str = System.Console.ReadLine();

            // int age = int.Parse(age_str);

            // ------------ second-way ------------------
            // C-Sharp exception process,
            // System.Console.WriteLine("please enter your age: ");
            // string age_str = System.Console.ReadLine();
            // int age = 0;
            // try
            // {
            //     age = int.Parse(age_str);
            // }
            // catch (System.Exception ex)
            // {
            //     System.Console.WriteLine(ex.Message);
            //     System.Console.WriteLine("please enter an integer number for your age(0-150)");

            //     return;
            // }

            // --------------- third-way ---------------
            // more smart or friend-user program,
            int age = 0;
            bool check_age = true;
            for (; check_age;)
            {
                System.Console.WriteLine("please enter your age: ");
                string age_str = System.Console.ReadLine();

                try
                {
                    age = int.Parse(age_str);
                    check_age = false;
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    System.Console.WriteLine("please enter an integer number for your age(0-150)");

                    check_age = true;
                }
            }
            // ------------------------------
            age += 10;

            System.Console.WriteLine("please enter your name(first-second): ");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("\n-----------------------------------");
            System.Console.WriteLine("your name is " + name + ", welcome");

            // implicit type convert (int ---> string), and string concatenation
            System.Console.WriteLine("your age after ten year is: " + age);
        }
    }
}
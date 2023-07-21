/**
 * @file 04_method.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-07-21
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 04_method.cs /out:method.exe
 *
 */

namespace ProgramCondition
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetUserInfo();

            // debugging 调试,
            System.Console.ReadKey();
        }

        // ----------------------------------------------
        // methods of class and functions
        public static void GetUserInfo()
        {
            System.Console.WriteLine("please enter your first name and second name: ");
            string name = System.Console.ReadLine();

            // pass by value? similar as C++, 
            name = ChangeName(name);

            System.Console.WriteLine("please enter your age(0~150): ");
            string age_str = System.Console.ReadLine();
            int age = int.Parse(age_str);

            System.Console.WriteLine("please enter your address: ");
            string address = System.Console.ReadLine();

            System.Console.WriteLine("please enter your hobby: ");
            string hobby = System.Console.ReadLine();

            System.Console.WriteLine("Welcome {0}, your are {1} years, and come from {2}, your hobby is {3}",
            name, age, address, hobby);
        }

        // 默认访问控制权限为 private,
        // return value and params lists for methods or function.
        static string ChangeName(string name)
        {
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
            else if (name == "wu wang")
            {
                System.Console.WriteLine("your enter name is {0}", name);
                name = "fa wai wu";
            }
            else
            {
                System.Console.WriteLine("your enter name is {0}", name);
                name = "welcome";
            }

            return name;
        }
    }
}
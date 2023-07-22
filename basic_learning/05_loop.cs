/**
 * @file 05_loop.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-07-21
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 05_loop.cs /out:loop.exe
 *
 */

using System.Collections.Generic;

namespace ProgramLoop
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num_repave = 1;
            // loop execute
            for (int i = 0; i < num_repave; i++)
            {
                GetUserInfo();
            }

            // C-Sharp 中的泛型集合,
            // 可以对比 array and vector in C++, list in Python
            List<string> listName = new List<string>();
            listName.Add("wei li");
            listName.Add("li wei");
            listName.Add("wei li");
            listName.Add("wei li");

            List<int> listNum = new List<int>();
            listNum.Add(42);
            listNum.Add(24);
            listNum.Add(42);
            listNum.Add(421);
            listNum.Add(42);

            int name_repave = 0;
            for (int i = 0; i < listName.Count; ++i)
            {
                if (listName[i] == "wei li")
                {
                    ++name_repave;
                }
            }

            int magic_number_repave = 0;
            for (int i = 0; i < listNum.Count; ++i)
            {
                if (listNum[i] == 42)
                {
                    ++magic_number_repave;
                }
            }

            System.Console.WriteLine("the number of repave name : {0}", name_repave);
            System.Console.WriteLine("the number of repave magic random number : {0}", magic_number_repave);

            // debugging 调试,
            // System.Console.ReadKey();
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

            System.Console.WriteLine("please enter your Address: ");
            string Address = System.Console.ReadLine();

            System.Console.WriteLine("please enter your hobby: ");
            string hobby = System.Console.ReadLine();

            System.Console.WriteLine("Welcome {0}, your are {1} years, and come from {2}, your hobby is {3}\n\n",
            name, age, Address, hobby);
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
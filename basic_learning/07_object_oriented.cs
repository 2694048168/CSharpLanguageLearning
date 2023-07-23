/**
 * @file 07_object_oriented.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-07-23
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 07_object_oriented.cs /out:object_oriented.exe
 *
 */

namespace ProgramObject
{
    public class Program
    {
        static void Main(string[] args)
        {
            // object-oriented(OO) and OOP in C-Sharp,
            System.Console.WriteLine("the game is coming......");
            System.Console.WriteLine("enter any key to start game");
            System.Console.ReadKey();

            System.Console.WriteLine("please enter your name(first-second): ");
            string name = System.Console.ReadLine();

            // 实例化对象
            Hero li = new Hero();
            li.m_name = name;
            li.m_age = 24;
            li.m_gender = "male";
            li.m_base_harm = 66;
            li.m_num_blood = 100;
            li.m_skill1 = "tan wu bao lun";
            li.m_skill1_harm = 20;
            li.m_skill2 = "bao lun";
            li.m_skill2_harm = 40;

            // memory function or method,
            li.DisplayInfo();

            // System.Console.WriteLine("\n-----------------------------------");
            // System.Console.WriteLine("{0}, welcome to our game world.", li.m_name);
            // System.Console.WriteLine("your name is {0}", li.m_name);
            // System.Console.WriteLine("your gender is {0}", li.m_gender);
            // System.Console.WriteLine("your age is {0}", li.m_age);
            // System.Console.WriteLine("your basic harm is {0}", li.m_base_harm);
            // System.Console.WriteLine("your number of blood is {0}", li.m_num_blood);
            // System.Console.WriteLine("your skill-first is {0}", li.m_skill1);
            // System.Console.WriteLine("your harm of skill-first is {0}", li.m_skill1_harm);
            // System.Console.WriteLine("your skill-second is {0}", li.m_skill2);
            // System.Console.WriteLine("your harm of skill-second is {0}", li.m_skill2_harm);

            // System.Console.WriteLine("\nenter any key to continue game...");
            // System.Console.ReadKey();
            Hero.Waiting();

            Hero wang = new Hero();
            wang.DisplayInfo();

            // System.Console.WriteLine("\n-----------------------------------");
            // System.Console.WriteLine("{0}, welcome to our game world.", wang.m_name);
            // System.Console.WriteLine("your name is {0}", wang.m_name);
            // System.Console.WriteLine("your gender is {0}", wang.m_gender);
            // System.Console.WriteLine("your age is {0}", wang.m_age);
            // System.Console.WriteLine("your basic harm is {0}", wang.m_base_harm);
            // System.Console.WriteLine("your number of blood is {0}", wang.m_num_blood);
            // System.Console.WriteLine("your skill-first is {0}", wang.m_skill1);
            // System.Console.WriteLine("your harm of skill-first is {0}", wang.m_skill1_harm);
            // System.Console.WriteLine("your skill-second is {0}", wang.m_skill2);
            // System.Console.WriteLine("your harm of skill-second is {0}", wang.m_skill2_harm);

            // System.Console.WriteLine("\nenter any key to continue game...");
            // System.Console.ReadKey();
            // 静态方法,
            Hero.Waiting();
        }
    }

    // create class and instance in C-Sharp,
    class Hero
    {
        // 默认访问控制权限为 private,
        // static string m_name = "wei li";
        public string m_name = "wei li";
        public string m_gender = "female";
        public int m_age = 25;
        public int m_num_blood = 120;
        public int m_base_harm = 110;
        public string m_skill1 = "jx";
        public int m_skill1_harm = 40;
        public string m_skill2 = "yi tan jin";
        public int m_skill2_harm = 66;

        // get and set methods, 静态方法只能使用静态变量,
        // public static void DisplayInfo()
        public void DisplayInfo()
        {
            System.Console.WriteLine("\n-----------------------------------");
            System.Console.WriteLine("{0}, welcome to our game world.", m_name);
            System.Console.WriteLine("your name is {0}", m_name);
            System.Console.WriteLine("your gender is {0}", m_gender);
            System.Console.WriteLine("your age is {0}", m_age);
            System.Console.WriteLine("your basic harm is {0}", m_base_harm);
            System.Console.WriteLine("your number of blood is {0}", m_num_blood);
            System.Console.WriteLine("your skill-first is {0}", m_skill1);
            System.Console.WriteLine("your harm of skill-first is {0}", m_skill1_harm);
            System.Console.WriteLine("your skill-second is {0}", m_skill2);
            System.Console.WriteLine("your harm of skill-second is {0}", m_skill2_harm);
        }

        public static void Waiting()
        {
            System.Console.WriteLine("\nenter any key to continue game...");
            System.Console.ReadKey();
        }
    }
}
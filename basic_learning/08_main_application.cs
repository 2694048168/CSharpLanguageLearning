/**
 * @file 08_main_application.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-07-23
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 08_main_application.cs 08_hero.cs 08_display_info.cs /out:application.exe
 * $ csc 08_*.cs  /out:application.exe
 *
 */

using HeroSpace;
using DisplayInfoSpace;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
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

            Display.DisplayInfo(li);

            Display.Waiting();

            Hero wang = new Hero();
            Display.DisplayInfo(wang);

            Display.Waiting();
        }
    }
}
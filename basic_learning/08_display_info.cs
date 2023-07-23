/**
 * @file 08_display_info.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-07-23
 *
 * @copyright Copyright (c) 2023
 *
 */

using HeroSpace;

namespace DisplayInfoSpace
{
    public class Display
    {
        public static void Waiting()
        {
            System.Console.WriteLine("\nenter any key to continue game...");
            System.Console.ReadKey();
        }

        public static void DisplayInfo(Hero hero)
        {
            System.Console.WriteLine("\n-----------------------------------");
            System.Console.WriteLine("{0}, welcome to our game world.", hero.m_name);
            System.Console.WriteLine("your name is {0}", hero.m_name);
            System.Console.WriteLine("your gender is {0}", hero.m_gender);
            System.Console.WriteLine("your age is {0}", hero.m_age);
            System.Console.WriteLine("your basic harm is {0}", hero.m_base_harm);
            System.Console.WriteLine("your number of blood is {0}", hero.m_num_blood);
            System.Console.WriteLine("your skill-first is {0}", hero.m_skill1);
            System.Console.WriteLine("your harm of skill-first is {0}", hero.m_skill1_harm);
            System.Console.WriteLine("your skill-second is {0}", hero.m_skill2);
            System.Console.WriteLine("your harm of skill-second is {0}", hero.m_skill2_harm);
        }
    }
}
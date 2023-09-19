/**
 * @file 24_regular_expressions.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-09-19
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 24_regular_expressions.cs /out:a.exe
 *
 * --------------------------------------
 *  C# 中正则表达式
 * --------------------------------------
 *
 */

using System;
using System.Text.RegularExpressions;

namespace WeiLi
{
    class ExecuteMain
    {
        static void Main(string[] args)
        {
            // 匹配以“C”开头的词组
            string str = "C# and C++ and C-sharp and CPlusPlus";
            showMatch(str, @"\bC\S*");

            System.Console.WriteLine("--------------------------------");
            // 匹配以“m”开头，以“e”结尾的单词
            string str2 = "make maze and manage to measure it";
            showMatch2(str2, @"\bm\S*e\b");

            // 去除字符串中多余的空格
            System.Console.WriteLine("--------------------------------");
            string input = "C   Plus   Plus   ";
            string pattern = "\\s+";

            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, "");

            Console.WriteLine("原始字符串: {0}", input);
            Console.WriteLine("替换后的字符串: {0}", result);

            // System.Console.ReadKey();
        }

        private static void showMatch2(string text, string expr)
        {
            Console.WriteLine("正则表达式为: " + expr);
            Console.WriteLine("匹配以“m”开头，以“e”结尾的单词: ");
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("正则表达式为: " + expr);
            Console.WriteLine("匹配以“C”开头的字符串: ");
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

    }

}

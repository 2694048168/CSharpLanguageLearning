/**
 * @file 09_file_handle.cs
 * @author Wei Li (weili_yzzcq@163.com)
 * @brief
 * @version 0.1
 * @date 2023-07-23
 *
 * @copyright Copyright (c) 2023
 *
 * the compile command:
 * $ csc 09_file_handle.cs /out:file.exe
 *
 * --------------------------------------
 *  1. 创建文件夹和文件
 *  2. 遍历文件夹, 获取所有文件
 *  3. 删除指定文件
 *  4. 修改指定文件的名称
 *  5. 删除整个文件夹以及对应的所有文件
 * --------------------------------------
 *
 */

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ChangeFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System.Console.ReadKey();

            // 1. 创建文件夹和文件
            string folder_path = "./test";
            if (!System.IO.Directory.Exists(folder_path))
            {
                System.IO.Directory.CreateDirectory(folder_path);
            }

            string file1_name = "123.txt";
            string file1_path = System.IO.Path.Combine(folder_path, file1_name);
            if (!File.Exists(file1_path))
            {
                FileStream fs = File.Create(file1_path);

                byte[] info = new UTF8Encoding(true).GetBytes("wei li\nhttps://github.com/2694048168\nhttps://2694048168.github.io/blog/\n");
                // 向文件中写入一些信息
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
            else
            {
                FileStream fs = File.OpenWrite(file1_path);

                byte[] info = new UTF8Encoding(true).GetBytes("wei li\nhttps://github.com/2694048168\nhttps://2694048168.github.io/blog/\n");
                // 向文件中写入一些信息
                fs.Write(info, 0, info.Length);
                fs.Close();
            }

            int num_file = 6;
            for (int i = 0; i < num_file; ++i)
            {
                string file_name = i + "_file.cs";
                string file_path = Path.Combine(folder_path, file_name);
                if (!File.Exists(file_path))
                {
                    FileStream fs = File.Create(file_path);

                    byte[] info = new UTF8Encoding(true).GetBytes("filename, " + file_name);
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
                else
                {
                    FileStream fs = File.OpenWrite(file_path);

                    byte[] info = new UTF8Encoding(true).GetBytes("filename, " + file_name);
                    fs.Write(info, 0, info.Length);
                    fs.Close();

                    // continue;
                }
            }

            // 2. 遍历文件夹, 获取所有文件
            string[] file_list = Directory.GetFiles(folder_path, "*.*");
            foreach (string file in file_list)
            {
                System.Console.WriteLine(file);
            }

            System.Console.WriteLine();
            DirectoryInfo root = new DirectoryInfo(folder_path);
            FileInfo[] files = root.GetFiles();
            foreach (FileInfo file in files)
            {
                System.Console.WriteLine(file.FullName);
                System.Console.WriteLine(file.Name);
                System.Console.WriteLine(file.Extension);
                System.Console.WriteLine();
            }

            // 3. 删除指定文件
            // string delete_file = "123.txt";
            foreach (FileInfo file in files)
            {
                if (file.Extension.Equals(".txt"))
                {
                    StreamReader sr = File.OpenText(file.FullName);
                    string line_info;
                    while ((line_info = sr.ReadLine()) != null)
                    {
                        System.Console.WriteLine(line_info);
                    }
                    sr.Close();

                    File.Delete(file.FullName);
                }
                else
                {
                    continue;
                }
            }

            // 4. 修改指定文件的名称
            files = root.GetFiles();
            for (int i = 0; i < num_file; ++i)
            {
                if (files[i].Extension.Equals(".cs"))
                {
                    // System.Console.WriteLine(files[i].Directory);
                    // System.Console.WriteLine(files[i].DirectoryName);
                    string dst_file = (i + 1) + "_file.txt";
                    string dst_path = System.IO.Path.Combine(files[i].DirectoryName, dst_file);
                    File.Move(files[i].FullName, dst_path);

                }
                else
                {
                    continue;
                }

            }

            // 5. 删除整个文件夹以及对应的所有文件
            DeleteDirectory(folder_path);
        }

        /// <summary>
        /// 递归方法删除目录及文件
        /// </summary>
        /// <param name="path">路径</param> 
        static void DeleteDirectory(string path)
        {
            // 如果文件夹存在则进入目录下
            if (Directory.Exists(path))
            {
                // 返回所有文件及目录
                foreach (string p in Directory.GetFileSystemEntries(path))
                {
                    if (File.Exists(p))
                    {
                        // 删除文件
                        File.Delete(p);
                    }
                    else
                    {
                        // 删除子目录
                        DeleteDirectory(p);
                    }
                }
                // 删除当前空目录
                Directory.Delete(path, true);
            }

            System.Console.WriteLine("the folder: {0} delete recursively successfully.", path);
        }
    }

}
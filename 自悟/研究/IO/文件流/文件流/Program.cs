using System;
using System.Linq;
using System.Collections;
using System.IO;

namespace 文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            string Exist = @"G:\NCRE";
            DirectoryInfo A = new DirectoryInfo(Exist);
            if (A.Exists)
            {
                Console.WriteLine(1);
            }
            if (Directory.Exists(Exist))
            {
                Console.WriteLine(1);
            }
            Console.WriteLine(A.Parent);//输出空
            Console.WriteLine(A.Root);//输出 G:\
            Console.WriteLine(A.CreationTime);//创建时间
            Console.WriteLine(Directory.CreateDirectory(Exist));//输出文件名
                                                                //  Directory.Delete("G:\\io"); 没有文件会异常
            Console.WriteLine(Directory.GetCreationTime(Exist));//创建时间
            Console.WriteLine(Directory.GetCurrentDirectory());//当前VS文件路径
            Console.WriteLine(Directory.GetDirectories(Exist)[1]);//子文件夹第二
            Console.WriteLine(Directory.GetDirectories(Exist)[0]);//子文件夹第一
            for (int i = 0; i < Directory.GetFiles(Exist).Length; ++i)//输出文件非夹
            {
                Console.WriteLine(Directory.GetFiles(Exist)[i]);
            }
            for (int i = 0; i < Directory.GetFileSystemEntries(Exist).Length; ++i)//所有东西
            {
                Console.WriteLine(Directory.GetFileSystemEntries(Exist)[i]);
            }
            Console.WriteLine(Directory.GetLastAccessTime(Exist));//上次访问时间
            Console.WriteLine(Directory.GetLastWriteTime(Exist));//上次写入时间
            Console.WriteLine(Directory.GetParent(Exist));//输出G:\

            Directory.CreateDirectory("G:\\qw\\t1\\t2");//创建了文件夹
            Directory.Delete("G:\\qw", true);//true 删除整个文件包括里面的 false删除单个
            Console.WriteLine(A.Attributes);
            Console.WriteLine(A.Name);
            Directory.SetCurrentDirectory(Exist);
            Console.WriteLine(Directory.GetCurrentDirectory());

            Console.WriteLine(Environment.CommandLine);//输出命令行
            Console.WriteLine(Path.GetDirectoryName(Exist));//输出G:\
            Console.WriteLine(Path.GetFileName(Exist));//输出NCRE
            Console.WriteLine(Path.GetFullPath(Exist));//输出 G:\NCRE 绝对路径
            Console.WriteLine(Path.GetTempPath());//输出当前临时文件夹的绝对路径

            //Directory.Move("G:\\PHP", "G:\\t1");//其中后面的文件是要移动到的文件夹，并且一定是没有存在过的！

            Console.WriteLine(File.Open("G:\\In.txt", FileMode.Open));
            File.Copy("G:\\PHP", "G:\\t2");
            StreamReader Reader = new StreamReader("D:\\In.txt");
            Console.WriteLine(Reader.ReadToEnd());//一下子 全部读取出来
            Reader = new StreamReader("D:\\In.txt");
            while (Reader.Read() != -1)
            {
                Console.WriteLine(Reader.ReadLine());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace 配置文件的基本操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //最普通的读取方式
            var A = System.Configuration.ConfigurationManager.AppSettings["Mj"];
            Console.WriteLine(A);

            //获取Configuration对象
            Configuration Config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //根据 Key读取<add>元素的Value
            string Name = Config.AppSettings.Settings["Mj"].Value;//注意和上面的读取方式差很多
            Console.WriteLine(Name);

            //写入<add>元素的Value
            Config.AppSettings.Settings["name"].Value = "fx163";
            Config.AppSettings.Settings.Add("url", "http://www.fx163.net");
            
            //删除<add>元素
            Config.AppSettings.Settings.Remove("name");

            //一定要记得保存，写不带参数的 Config.Save() 也可以
            Config.Save(ConfigurationSaveMode.Modified);

            //刷新，否则程序读取的还是之前的值（可能已装入内存）

            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
            
        }
    }
}

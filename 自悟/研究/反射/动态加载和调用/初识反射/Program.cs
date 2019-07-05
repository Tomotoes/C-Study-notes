using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

using ClassLibrary1;//使用ClassLibrary1的命名空间！
using ClassLibrary2;//使用ClassLibrary2的命名空间！
using ClassLibrary3;//使用ClassLibrary3的命名空间！

namespace 初识反射
{
    /// <summary>
    /// 1.反射的介绍和原理
    /// 2.通过反射获取信息，创建对象，调用方法
    /// 3.实现程序的可配置
    /// </summary>
    class Program
    {
        //反射为了动态，比如：动态的去加载DLL，获取信息，设置属性

        //类库建立后，会生成两个文件，一个是 dll后缀，一个是 pdb后缀(做调试用的) 主要是dll
        //dll 是应用程序的扩展，其中有两种语言，一部分是中间语言，叫il，和计算机做交互的，
        //另一部分叫 metedata，它是对 il的描述，中间有什么类啊，命名空间啊，都在其里面
        //而反射就可以读取 metedata
        //pdb是程序调试的文件


        static void Main(string[] args)
        {
            //通过配置文件 找到 对应需要的字符串
            //不用改程序就可以执行不同的行为，只修改配置文件，就管理不同的输出端
            string Config = ConfigurationManager.AppSettings["ClassLibrary1"];
            string[] Ac = Config.Split(',');

            //最普通的调用方法
            ClassLibrary1.Class1 A = new ClassLibrary1.Class1();
            A.Jump();

            Assembly assembly = Assembly.Load(Ac[0]);//反射的入口，动态的加载dll
            //右键assembly 点击 快速监视，便可看到关于"ClassLibrary1"的所有信息

            foreach (Module module in assembly.GetModules())
            {
                Console.WriteLine(module.FullyQualifiedName);
            }

            foreach (Type type in assembly.GetTypes())
            {
                Console.WriteLine(type.FullName);
            }
            //这些原数据，我们平时 是看不见的，只能通过反射 去获取它

            Console.WriteLine(assembly.GetName());

            //找到ClassLibrary1其中的Class1这个类
            //Type Class = assembly.GetType("ClassLibrary1.Class1");
            //基于类的完整名称，找出类型

            //我们要注意 这个时候 使用的是全名称：命名空间.类名 
            //这个时候 你可能有疑问了，为什么上面实例化Class1 不能全名称呢，
            //那是因为 我们引用了 ClassLibrary1命名空间，当然 如果你也可以去掉  
            //ClassLibrary1.Class1 A = new ClassLibrary1.Class1();

            Console.WriteLine();

            /*记住下面的代码，
             * 1.先创建程序集对象 assembly，通过 Assembly.Load(xxx)然后加载 ClassLirary1
             * 2.从程序集对象通过GetType方法 中找到 类类型
             * 3.根据类类型创建对象 通过 Activator类的CreateInstance方法！ 并且用 as强制转换，当然建议最好先 is判断一下
             */

            //Activator 在英语中 是催化剂的意思。

            //Assembly assembly = Assembly.Load("ClassLibrary1");反射入口，动态的加载dll
            Type Class = assembly.GetType(Ac[1]);//基于类的完整名称，找出类类型
            //注意 Ac[1]的构造函数 必须是无参数的才可以！不然会报错！
            Interface3 Instance = Activator.CreateInstance(Class) as Interface3;//创建了 Class1的对象，执行了构造函数
            Instance.Jump();

        }
    }
}

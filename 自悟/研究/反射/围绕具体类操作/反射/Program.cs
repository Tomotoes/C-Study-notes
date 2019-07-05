using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;//别忘了此头文件

namespace 反射
{
    class Student
    {
        public int No;
        public string Name;
        public int Age { get; set; }
        public char Sex { get; set; }
        public void Speak()
        {
            Console.WriteLine("I am Speaking!");
        }
        public void Jump()
        {
            Console.WriteLine("I am Jumping!");
        }
        public void Info(int No, string Name)
        {
            Console.WriteLine("{0}的学号是{1}", Name, No);
        }
        public void Info()
        {
            Console.WriteLine("This isNULL");
        }
        public void Info(int No)
        {
            Console.WriteLine("学号是{0}", No);
        }
        public void Look(int i)
        {
            Console.WriteLine("I am Looking {0}", i);
        }
        private void Love(string Name)//私有方法 ，反射读取不到！
        {
            Console.WriteLine("I Love {0}", Name);
        }
        //public Student(string Name)
        //{

        //}
        private Student()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type StudentType = typeof(Student);//获取Student的类型，怎么感觉很陌生呢。
            Console.WriteLine(StudentType.Name);
            Console.WriteLine();
            //此时 你只需要 敲出 t 然后随之跟着一个点 。。

            //获取方法总数
            foreach (MethodInfo a in StudentType.GetMethods())
            {
                Console.WriteLine(a.ToString());//把自己有拥有的方法 以及 已经继承的方法全部输出
            }
            Console.WriteLine();

            //获取所有成员
            foreach (MemberInfo q in StudentType.GetMembers())
            {
                Console.WriteLine(q.ToString());
            }
            Console.WriteLine();

            FieldInfo[] F = StudentType.GetFields();//获取所有字段
            foreach (FieldInfo f in StudentType.GetFields())
            {
                Console.WriteLine(f.ToString());
            }
            Console.WriteLine("属性读取！");
            Student OPP = Activator.CreateInstance(StudentType,true) as Student;
            foreach (var prop in StudentType.GetProperties())
            {
                if (prop.Name.Equals("Age"))//根据名字进行判断
                {
                    prop.SetValue(OPP, 15);//设置值
                }
                if (prop.Name.Equals("Sex"))
                {
                    prop.SetValue(OPP, '1');
                }
                Console.WriteLine("姓名为：{0}---属性为：{1}",prop.Name,prop.GetValue(OPP));
            }
           

            const string FileName = @"./反射.exe";
            Assembly assembly = Assembly.LoadFrom(FileName);//Assembly 是程序集的意思

            //Assembly assembly = Assembly.Load("程序集名称");

            Type[] Types = assembly.GetTypes();//获取 所有的类，然后以下可以借鉴上面

            foreach (Type type in Types)//获取 程序中的类
            {
                foreach (ConstructorInfo Con in type.GetConstructors())//获取类的所有构造函数
                {
                    Console.WriteLine(Con.Name + "***");
                    ParameterInfo[] ps = Con.GetParameters();//取出每个构造函数的所有参数
                    foreach (ParameterInfo o in ps)
                    {
                        Console.WriteLine(o.Name);
                    }
                }
                foreach (MemberInfo Me in type.Module.GetFields())//什么也没有输出
                {
                    Console.WriteLine(Me.Name + "--");
                }
            }

            //需要注意 Student的构造函数，必须是无参数的才可以！，其中 参数列表中 有 bool nonpublic的属性，这样一来，我们就可以调用私有的构造方法
            //Student stu = Activator.CreateInstance(StudentType) as Student;//Instance 是 实例的意思
            Student stu = Activator.CreateInstance(StudentType, true) as Student;
            //现我的理解就是这条代码 创建一个 type的对象 然后 修改字段 调用方法 需要它
            /*
             * 下面是介绍 Activator类的
             * 包含特定的方法，用以在本地 或从远程创建对象类型，
             * 或获取 对现有远程对象的引用。
             * 此类不能被继承。
             */
            Console.WriteLine(stu.GetType().Name);
            stu.Jump();

            Console.WriteLine("\r\n--- " + StudentType.FullName + " :");
            if (StudentType.Name == "Student")
            {
                Console.WriteLine("如何获取方法");
                MethodInfo Jump = StudentType.GetMethod("Jump");//获取特定的方法
                Jump.Invoke(stu, null);//执行特定的方法，记住是 Invoke方法，
                //第一个参数 是提取的 类类型，第二个参数为空，因为Jump方法无参数
                Console.WriteLine("获取方法已解决");

                Console.WriteLine("如何调用有参数的方法");
                MethodInfo Look = StudentType.GetMethod("Look");
                Look.Invoke(stu, new object[] { 11 });//有参数的调用！是通过使用 new object[]{xxx};
                Console.WriteLine("参数方法已经解决");

                Console.WriteLine("如何设置字段的值");
                FieldInfo No = StudentType.GetField("No");
                No.SetValue(stu, 15);//把stu这个对象的 No字段的值设置成 15
                Console.WriteLine(No.GetValue(stu)); //读取stu对象 字段No的值
                Console.WriteLine("设置字段已经解决");

                Console.WriteLine("如何解决重载");
                //如果查找的方法是具有重载的，必须在后面添加 Type[]参数，里面给出参数信息，不然会报错
                MethodInfo Info1 = StudentType.GetMethod("Info", new Type[] { });
                Info1.Invoke(stu, null);

                MethodInfo Info2 = StudentType.GetMethod("Info", new Type[] { typeof(int) });
                Info2.Invoke(stu, new object[] { 1 });

                MethodInfo Info3 = StudentType.GetMethod("Info", new Type[] { typeof(int), typeof(string) });
                Info3.Invoke(stu, new object[] { 1, "Liulin" });

                Console.WriteLine("重载已经解决");

                Console.WriteLine("怎么调用私有方法！");
//                MethodInfo Love = StudentType.GetMethod("Love", BindingFlags.Instance
//| BindingFlags.Public | BindingFlags.NonPublic);
//                Love.Invoke(StudentType, new object[] { "Mj" });
                Console.WriteLine("调用私有方法已经解决！");

            }

            MemberInfo[] methods = StudentType.GetMethods();//获取每个类的方法
            foreach (MemberInfo method in methods)
            {
                Console.WriteLine(method.ToString());
                if (method.ToString() == "Void Jump()")//判断之后调用
                {
                    //new Student().Jump();
                }
            }

            //私有重载方法的调用，私有 有参数构造函数，未实现，其实都在各个参数属性里面！
            //并且我们要知道 反射是可以破坏 单例模式的！

        }
    }
}

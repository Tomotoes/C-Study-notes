using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class Person
    {
        String Name;
        int Age;
        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Console.WriteLine("In Person(String,int)");
        }
    }
    class Student : Person
    {
        string School;
        public Student() : this(null, 0, null) { }
        public Student(String name, int age, string school)
            : base(name, age)
        {
            this.School = school;
            Console.WriteLine("In Student(String,int,String)");
        }
    }
    class Graduate : Student
    {
        public Graduate()//:base()就算不添加base(),也相当于 后面添加了base()
        {
            Console.WriteLine("In Graduate()");
        }
        //static void Main(string[] args)
        //{
           // Graduate A = new Graduate();
            /*
             * 现在 我来说下 构造方法的调用顺序
             * 1.找到 public Graduate()
             * 2.执行 Graduate 的父类的构造方法
             * 3.找到 public Student() : this(null, 0, null) { }
             * 4.执行 public Student(String name, int age, string school): base(name, age)
             * 5.执行 Student父类的构造方法
             * 6.执行 public Person(string name, int age)
             * 7.执行 public Student(String name, int age, string school): base(name, age)
             * 8.最后 public Graduate()
             */
        //}
    }
}

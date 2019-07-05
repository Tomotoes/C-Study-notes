using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.StaticFactory;

namespace Unity
{
    /// <summary>
    /// 依赖注入有三种方式：构造函数注入，方法注入，属性注入
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Unity's Learn!");
            UnityText.Show();
            Console.ReadKey();
        }
    }
    class UnityText
    {
        public static void Show()
        {
            //左面是面向接口的，而右面并没有，右面写死了
            Console.WriteLine("*****************************");
            {
                IPhone Phone = new AnroidPhone();
                Phone.Call();
            }
            Console.WriteLine("*****************************");
            {
                IPhone Phone = new ApplePhone();
                Phone.Call();
            }
            //Unity本质就是反射
            Console.WriteLine("*****************************");
            {
                //初始化一个容器
                IUnityContainer Container = new UnityContainer();

                //注册一个类型，从IPhone到AnroidPhone，TForm 与 TTo
                Container.RegisterType<IPhone, AnroidPhone>();

                IPhone Phone = Container.Resolve<IPhone>();
                
                Phone.Call();
            }
            //1 代码变麻烦，但是效果没区别
            //2 还是有细节

            Console.WriteLine("*****************************");
            {
                IUnityContainer Container = new UnityContainer();

                Container.RegisterType<IPhone, ApplePhone>();
                
                IPhone Phone = Container.Resolve<IPhone>();
                
                Phone.Call();
            }
        }
    }
    public interface IPhone
    {
        public IMicrophone Microphone { get; set; }
        public IPower Power { get; set; }
        public IHeadphone Headphone { get; set; }

        void Call();
    }
    //怎么获取当前类型？this.GetType().Name

    //怎么 添加项目，先把当前项目 复制到同一文件路径，然后 右键项目添加 现有项，找到csproj文件，然后添加 即可。
    public class AnroidPhone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("{0}打电话",this.GetType().Name);
        }
    }
    public class ApplePhone : IPhone
    {
        public IMicrophone Microphone { get; set; }
        public IPower Power { get; set; }
        public IHeadphone Headphone { get; set; }
        public void Call()
        {
            Console.WriteLine("{0}打电话", this.GetType().Name);
        }
    }
    public interface IMicrophone
    {

    }
    public class Microphone : IMicrophone
    {

    }
    public interface IHeadphone
    {

    }
    public class Headphone : IHeadphone
    {

    }
    public interface IPower
    {

    }
    public class Power : IPower
    {

    }
}

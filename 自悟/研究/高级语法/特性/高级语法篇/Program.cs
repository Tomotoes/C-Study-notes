using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace 高级语法篇
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class Program:Attribute
    {
        //[DebuggerStepThrough]
        /*首先明确 该特性处在 using System.Diagnostics;*/
        /*该特性的主要功能就是跳过调试，主要适用于一些简单的方法*/

        public int A;
        public string S;

        public string S1
        {
          get { return S; }
          set { S = value; }
        }
        public Program(int a)
        {
            A = a;
        }
       
        public void Speak()
        {
            Console.WriteLine("Hello "+S);
        }
    }
    [Program(1000,S="A")]
    public class Text
    {
        
        static void Main(string[] args)
        {
            Type classType = typeof(Program);
            object[] customAttributes = classType.GetCustomAttributes(true);
            foreach (object customAttribute in customAttributes)
            {
                //Program Temp = customAttribute as Program;
                //if(Temp!=null)Console.WriteLine(Temp.A);
                Console.WriteLine(customAttribute);    
            }
        }
    }
}

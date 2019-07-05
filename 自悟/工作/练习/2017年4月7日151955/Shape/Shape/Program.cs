using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class ShapeArea
    {
        public int Area(int a, int b)
        {
            return a * b;
        }
        public int Area(int a, int b, int c)
        {
            return a * b / 2;
        }
        public double Area(int a)
        {
            return System.Math.PI * a * a;
        }
    }
    class Juxing:ShapeArea
    {
        int chang,kuan;
        public int Chang
        {
            set { chang = value; }
            get { return chang; }
        }
        public int Kuan
        {
            set { kuan = value; }
            get { return kuan; }
        }
    }

    class Sanjiaoxing:ShapeArea
    {
        int a, b, c;
        public int A
        {
            set { a = value; }
            get { return a; }
        }
        public int B
        {
            set { b = value; }
            get { return b; }
        }
        public int C
        {
            set { c = value; }
            get { return c; }
        }
    
    }
    class Yuan:ShapeArea
    {
        int r;
        public int R
        {
            set { r = value; }
            get { return r; }
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Juxing V=new Juxing();
            V.Chang = 5;
            V.Kuan = 6;
            Console.WriteLine(V.Area(V.Chang,V.Kuan));
            Sanjiaoxing S = new Sanjiaoxing();
            S.A = 5;
            S.B = 4;
            S.C = 7;
            Console.WriteLine(S.Area(S.A,S.B,S.C));
            Yuan Q = new Yuan();
            Q.R = 2;
            Console.WriteLine("{0:F0}",Q.Area(Q.R));
        }
    }
}

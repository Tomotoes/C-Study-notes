1．  /// ：注释作用，并且 当你下一次输入 东西时，会自动出现注释

2．  布尔型：不再是整数类型，结果为 true 或者 false

3．  结构体不加分号

4. double 类型初始化时，需要加小数点 不然会被当成整数

5. 断点 调试专用 在运行时，会在断点处停止，摁次F11，执行一次操作，并有显示出现

6. string 不能用于 大小于的判断，只能用于 等于 不等于之类的

7. Console.Beep( ) : 声音函数

8. 数学函数：System.Math.PI //π

9. it? A=null; 定义了一个可空类型 其值既可以是整型数字，也可以是NULL

10. ADO：活动数据对象
11. 在C#语言中，符合公共语言规范的数据类型可分为两类：值类型 和 引用类型

 

public人缘好，跟谁都好， 
protect只和熟人好， 
private比较自闭． 
不过他们是三胞胎． 

 class 是他们的爹．

 

静态成员 归 类 所有， 通过类名访问；

动态成员 归 对象所有，通过对象名访问。

Eg：

```c#
namespace Ac

{

​    class StaticClass

​    {

​        public static int A=10;

​        public int B = 20;

​    }

​    class Program

​    {

​        static void Main(string[] args)

​        {

​            StaticClass X = new StaticClass();//创建了两个关于 StaticClass类 的两个对象

​            StaticClass Y = new StaticClass();

​            StaticClass.A += 20;

​            X.B += 10;

​            Y.B += 20;

​            Console.WriteLine("StaticClass.A == {0}",StaticClass.A);//30

​            Console.WriteLine("X.B == {0}", X.B);//30

​            Console.WriteLine("Y.B == {0}", Y.B);//40

​        }

	 }

}
```



作业：位运算 与 书的前三章

 

 

 
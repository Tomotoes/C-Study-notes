using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Threading.Thread;

namespace 调用PLINQ查询的参数
{
    class Program
    {
        static string EmnlateProcessing(string typeName)
        {
            Sleep(250);
            Console.WriteLine($"Name is {typeName} and ThreadId is {CurrentThread.ManagedThreadId}");
            return typeName;
        }
        /// <summary>
        /// 这段写得太牛逼
        /// </summary>
        /// <returns>返回当前程序集中公共类型名字开头带"Web"的，并按名字长度升序返回 一个IEnumerable<string></returns>
        static IEnumerable<string> GetTypes()
        {
            return from assembly in AppDomain.CurrentDomain.GetAssemblies()
                   from type in assembly.GetExportedTypes()
                   where type.Name.StartsWith("Web")
                   orderby type.Name.Length
                   select type.Name;
        }
        static void Main(string[] args)
        {
            var parallelQuery = from t in GetTypes().AsParallel() select EmnlateProcessing(t);

            var cts = new CancellationTokenSource();

            cts.CancelAfter(1000);//一秒后 发送取消信号，这导致查询中 抛出OperationCanceledException异常，并且取消了剩余的工作。

            try
            {
                parallelQuery.WithDegreeOfParallelism(Environment.ProcessorCount)
                    .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                    .WithMergeOptions(ParallelMergeOptions.Default)
                    .WithCancellation(cts.Token)
                    .ForAll(Console.WriteLine);
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation has been canceled!**************************");
            }
            Console.WriteLine("---");

            var unorderedQuery = from i in ParallelEnumerable.Range(1, 30) select i;
            foreach (var item in unorderedQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");

            var orderedQuery = from i in ParallelEnumerable.Range(1, 30).AsOrdered() select i;
            foreach (var item in orderedQuery)
            {
                Console.WriteLine(item);
            }
        }
        /*
        一个有意思的选项是 使用WithExecutionMode 方法来重载查询执行的模式。
        PINQ基础设施 如果认为并行化 某查询只会增加工作量 并且运行更慢，那么将会以顺序模式执行该查询。
        但我们可以强制该查询以并行的方式运行。

        可以使用WithMergeOptions方法调整 对查询结果的处理。默认模式 是PINQ基础设施 在查询返回结果之前一定会缓存一定数量的结果。
        如果查询花费了大量的事件，更合理的方式 是 关闭结果缓存 从而尽可能快地得到结果。

        最后一个是AsOrdered方法。当使用并行执行时，集合中的项有可能不是被顺序处理的。集合中稍后的项可能会比 前面的项先处理。为了防止该情况，我们可以显示的对并行查询调用 AsOrdered方法，来告诉PLINQ基础设施 我们打算按项在集合中的顺序来进行处理。
         */
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Task的终极深入
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建方法并且自动调用方法
            Task<int> task1 = Task.Factory.StartNew(() =>
            {
                //Do Something...
                return 10;
            });
            task1.Wait();
            WriteLine(task1.Result);

            //创建方法
            Task<int> task2 = new Task<int>(() =>
            {
                //Do Something...
                return 10;
            });
            task2.Start();//需要手动调用方法
            WriteLine(task2.Result);

            Task.WaitAll(task1, task2);

            //创建一个在目标 task2完成时异步执行的延续任务，其中里面的参数是 System.Func<Task<int>,string> confixxxxx
            //一个任务完成时 它可以启动另一个任务。
            Task task3 = task2.ContinueWith(t =>
              {
                  int num = t.Result;
                  var sum = num + 100;
                  WriteLine(sum);
                  return sum.ToString();
                  //此方法，不能得到结果，毕竟是延续任务。。
              });
            //task3.Start();将会启发异常，不能对延续动作 用 Start() 方法
            //task3.Wait(); 并且 task3 没有 Result的属性
            WriteLine("获取Task数组！");

            //使用 Task.WhenAll 方法，并且要保证 task1 和 task2 的返回类型一定是一样
            Task<int[]> taskSum = Task.WhenAll(new Task<int>[2] { task1, task2 });

            foreach (int item in taskSum.Result)
            {
                WriteLine(item);
            }

            Task task4 = Task.Run(() => Console.WriteLine("asd"));//自动调用结果

            Task.Factory.StartNew(()=>Run2(),TaskCreationOptions.LongRunning);
            //我们标记该任务为长时间运行，结果该任务将不会使用线程池，而在单独的线程使用
            //然而 根据运行该任务的当前的任务调度程序(task scheduler)，运行方式有可能不同
            //并且 我们还要知道 TaskCreationOptions.LongRunning与其他的TaskCreationOptions可以用 | 来连接！

            Task task5=new Task(()=>Run2());
            task5.RunSynchronously(TaskScheduler.Current);
            //通常 ， 任务在线程池线程上异步执行，并且不会阻止调用线程。通过调用执行的任务RunSynchronously()方法是否与当前 TaskScheduler并在调用线程上运行。

            //Task task6=Task.Factory.FromAsync();

            //TaskScheduler A=new TaskScheduler();
            

            Console.WriteLine("试试 Task的取消之法"); 

            CancellationTokenSource ct = new CancellationTokenSource();

            CancellationToken Canncel = ct.Token;

            Canncel.Register(()=>Console.WriteLine("注册方法"));

            Task T1 = new Task(() => Run1(Canncel), ct.Token , TaskCreationOptions.None);//注意这里 带了 ct.Token,或者 带 Canncel

            Task T2 = new Task(Run2);

            try
            {
                T1.Start();
                T2.Start();

                Thread.Sleep(TimeSpan.FromSeconds(1));

                Console.WriteLine($"{ct.IsCancellationRequested}");//输出False

                ct.Cancel();//此时会触发 CT.ThrowIfCancellationRequested();
                
                Console.WriteLine($"{ct.IsCancellationRequested}");//输出true,因为 在调用Cannel后，会触发IsCancellationRequested

                Thread.Sleep(6000);//在这里等待结果

            }
            catch(AggregateException ex)//并没有引发异常。
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("\nhi,我是OperationCanceledException：{0}\n", e.Message);
                }

                //T1是否取消
                Console.WriteLine("AT1是不是被取消了？ {0}", T1.IsCanceled);
                Console.WriteLine("AT2是不是被取消了？ {0}", T2.IsCanceled);
            }
            
            Console.WriteLine("T1是不是被取消了？ {0}", T1.IsCanceled);//输出true
            Console.WriteLine("T2是不是被取消了？ {0}", T2.IsCanceled);//输出false
            Console.Read();

        }

    
        static void Run1(CancellationToken CT)
        {
            //OperationCanceledException 取消线程 正在执行的操作时 在线程中引发的异常
            //如果已请求取消此标记，则引发OperationCanceledException
            //必须调用Cannel方法，才能触发ThrowIfCancellationRequested
            CT.ThrowIfCancellationRequested();

            Console.WriteLine("我是任务1");

            Thread.Sleep(TimeSpan.FromSeconds(2));//是为了在Cancel的时候Run1没有执行完
            //当上面等到1000ms多的时候实际上已经接收到Cancel的消息了，但是这个时候不会取消task的，只有调用下面这句话的时候才会取消task

            Console.WriteLine("Run1运行终止"+CT.CanBeCanceled);//输出true！
            CT.ThrowIfCancellationRequested();//真正的取消Task，必须接受到Cannel才会触发，也就是说 Run1运行到这里终止了

            Console.WriteLine("我是任务1的第二部分信息");

        }
        static void Run2 ()=>Console.WriteLine("我是任务2");
    }
}

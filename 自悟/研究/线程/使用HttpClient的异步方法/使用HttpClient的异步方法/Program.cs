using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
using System.Threading;
using System.Threading.Tasks;
using System.IO;
 
using System.Net.Http; //要引用这个dll
using System.Diagnostics;
 
namespace async示例
{
    public class Test
    {
        
       int tasks = 10;
        Queue<string> results = new Queue<string>();
        string baseUrl = "http://www.pku.edu.cn";
        public void Start()
        {
            Task[] tasks = new Task[this.tasks];
 
            for (int i = 0; i < this.tasks; ++i)
            {
                tasks[i] = this.Perform(i);
            }
 
            Task.WaitAll(tasks);
 
            results.ToList().ForEach(Console.WriteLine);
        }
        public async Task Perform(int state)
        {
            string url = String.Format("{0}{1}", this.baseUrl, state.ToString().PadLeft(3, '0'));
            var client = new HttpClient();
            Stopwatch timer = new Stopwatch();
 
            timer.Start();
            string result = await client.GetStringAsync(url);
            timer.Stop();
 
            this.results.Enqueue(String.Format("{0,4}\t{1,5}\t{2}", url, timer.ElapsedMilliseconds, result));
        }
    }
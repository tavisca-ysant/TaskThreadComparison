using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using System.Threading;
using System.Threading.Tasks;

namespace TaskThreadComparison
{
    [MemoryDiagnoser]
    public class Comparison
    {
        [Params(3)]
        public int limit;
        public void SaveData(int limit)
        {
            for(int i = 0; i < limit; i++)
            {

            }
        }

        public void PrintData(int limit)
        {
            for (int i = 0; i < limit; i++)
            {

            }
        }

        [Benchmark]
        public void Threads()
        {
            Thread thread1 = new Thread(() => SaveData(limit));
            Thread thread2 = new Thread(() => PrintData(limit));
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }

        [Benchmark]
        public void Tasks()
        {
            Task.Run(async () =>
            {
                var task1 = SaveData();
                var task2 = PrintData();
                await Task.WhenAll(task1, task2);
            }).GetAwaiter().GetResult();
             
        }

        public async Task SaveData()
        {
            await Task.Delay(2000);
        }

        public async Task PrintData()
        {
            await Task.Delay(3000);
        }

    }
}

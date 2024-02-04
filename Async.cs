using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS___Async_Await
{
    internal class Async
    {
        public void Main()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var task1 = StartExecution();
            var task2 = MidExecution();
            var task3 = EndExecution();
            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine("Total Execution Time " + watch.ElapsedMilliseconds);
        }

        public async Task StartExecution()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("StartExecution");
            });
        }

        public async Task MidExecution()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("MidExecution");
            });
        }

        public async Task EndExecution()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(6000);
                Console.WriteLine("EndExecution");
            });
        }
    }
}

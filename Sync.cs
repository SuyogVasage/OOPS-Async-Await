using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS___Async_Await
{
    internal class Sync
    {
        public void Main()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            StartExecution();
            MidExecution();
            EndExecution();
            watch.Stop();
            Console.WriteLine("Total Execution Time " + watch.ElapsedMilliseconds);
        }

        public void StartExecution()
        {
            Thread.Sleep(8000);
            Console.WriteLine("StartExecution");
        }

        public void MidExecution()
        {
            Thread.Sleep(4000);
            Console.WriteLine("MidExecution");
        }

        public void EndExecution()
        {
            Thread.Sleep(6000);
            Console.WriteLine("EndExecution");
        }
    }
}

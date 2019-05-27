using System;
using System.Threading;

namespace ConsoleAsyncExperiments
{
    internal class Printer
    {
        public event EventHandler<PrintArgs> OnPrint = delegate { };

        public void Print(int count)
        {
            for (var i = 1; i <= count; i++)
            {
                var delay = new Random().Next(500, 2000);
                var text = $"{DateTime.Now.ToString("hh:MM:ss.fff")} [{Thread.CurrentThread.ManagedThreadId}]: {i} of {count} taking {delay} milliseconds";
                OnPrint(this, new PrintArgs(text));
                Thread.Sleep(delay);
            }
        }

        public Thread PrintAsync(int count)
        {
            var t = new Thread(() => Print(count));
            t.Start();
            return t;
        }
    }
}
using System;
using System.Threading;

namespace ConsoleAsyncExperiments
{
    class ConsolePrinter
    {
        public void PrintHandler(object sender, PrintArgs args)
        {
            Console.WriteLine(args.Text);
        }
    }
}

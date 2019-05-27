using System;
using System.IO;
using System.Threading;

namespace ConsoleAsyncExperiments
{
    class FilePrinter
    {
        private readonly string file;

        public FilePrinter(string file)
        {
            this.file = file;
        }

        public void PrintHandler(object sender, PrintArgs args)
        {
            using (StreamWriter sw = File.AppendText(this.file))
                sw.WriteLine(args.Text);

            Thread.Sleep(new Random().Next(1000, 3000));
        }
    }
}

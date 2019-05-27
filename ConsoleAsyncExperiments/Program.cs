using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAsyncExperiments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Print("File01.txt", 10);
            Print("File02.txt", 15);

            //Console.ReadKey();
        }

        private static void Print(string file, int count)
        {
            var p = new Printer();
            p.OnPrint += new ConsolePrinter().PrintHandler;
            p.OnPrint += new FilePrinter(file).PrintHandler;
            
            p.PrintAsync(count);
        }
    }
}

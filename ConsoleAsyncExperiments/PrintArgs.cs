using System;

namespace ConsoleAsyncExperiments
{
    internal class PrintArgs : EventArgs
    {
        public PrintArgs(string text)
        {
            this.Text = text;
        }

        public string Text { get; set; }
    }
}
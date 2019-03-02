using System;
using System.Threading;
using System.Windows;
using WpfAppAsyncExperiments.Presenters;

namespace WpfAppAsyncExperiments
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Print("Still responsive");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new SynchronousPresenter(this).LongRunningCalc();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new AsyncAwaitReturnPresenter(this).LongRunningCalc();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            new AsyncAwaitCallbackPresenter(this).LongRunningCalc();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            new TaskCallbackPresenter(this).LongRunningCalc();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }

        public void Print(string value)
        {
            textBox.Text += $"[{Thread.CurrentThread.ManagedThreadId}] {value + Environment.NewLine}";
        }

        public void PrintSpecial(string value)
        {
            Dispatcher.Invoke(() => Print(value));
        }
    }
}

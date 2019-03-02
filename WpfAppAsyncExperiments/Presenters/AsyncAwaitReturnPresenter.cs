using System.Threading.Tasks;

namespace WpfAppAsyncExperiments.Presenters
{
    class AsyncAwaitReturnPresenter : Presenter
    {
        public AsyncAwaitReturnPresenter(IView view) : base(view)
        {
        }

        public async override void LongRunningCalc()
        {
            var l = await Task.Run(() => BusinessRules.Calculate());
            Print(l);
        }

        private void Print(long l) => View.Print(MessageFor("async await return", l));
    }
}

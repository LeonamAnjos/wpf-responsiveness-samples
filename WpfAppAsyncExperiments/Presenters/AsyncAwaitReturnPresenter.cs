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
            long l = await CalculateAsync();
            Print(l);
        }

        private static async Task<long> CalculateAsync()
        {
            return await Task.Run(() => BusinessRules.Calculate());
        }

        private void Print(long l) => View.Print(MessageFor("async await return", l));
    }
}

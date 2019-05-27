using System;
using System.Threading.Tasks;

namespace WpfAppAsyncExperiments.Presenters
{
    class AsyncAwaitCallbackPresenter : Presenter
    {
        public AsyncAwaitCallbackPresenter(IView view) : base(view)
        {
        }

        public override void LongRunningCalc()
        {
            LongRunningCalcAsync(Print);
        }

        private void Print(long l) => View.Print(MessageFor("async await callback", l));

        private async Task LongRunningCalcAsync(Action<long> callback)
        {
            var l = await Task.Run(() => BusinessRules.Calculate());
            callback(l);
        }
    }
}

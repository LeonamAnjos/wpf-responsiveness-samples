using System.Threading.Tasks;
using System.Windows.Threading;

namespace WpfAppAsyncExperiments.Presenters
{
    class TaskCallbackPresenter : Presenter
    {
        public TaskCallbackPresenter(IView view) : base(view)
        {
        }

        public override void LongRunningCalc() => Task.Run(() => Print(BusinessRules.Calculate()));

        private void Print(long l) => View.DispatchPrint(MessageFor("task callback", l));
    }
}

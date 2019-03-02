namespace WpfAppAsyncExperiments.Presenters
{
    abstract class Presenter : IPresenter
    {
        protected IView View { get; }

        public Presenter(IView view)
        {
            View = view;
        }

        public abstract void LongRunningCalc();

        protected string MessageFor(string id, long l) => $"[{l.ToString()}] {id}";
    }
}
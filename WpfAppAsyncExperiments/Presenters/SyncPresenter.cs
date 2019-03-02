namespace WpfAppAsyncExperiments.Presenters
{
    class SynchronousPresenter : Presenter
    {
        public SynchronousPresenter(IView view) : base(view)
        {
        }

        public override void LongRunningCalc()
        {
            var l = BusinessRules.Calculate();
            View.Print(MessageFor("synchronously", l));
        }
    }
}

namespace WpfAppAsyncExperiments
{
    public interface IView
    {
        void Print(string value);
        void DispatchPrint(string value); // when asynchronous without async/await
    }
}
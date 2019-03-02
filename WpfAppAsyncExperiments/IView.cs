namespace WpfAppAsyncExperiments
{
    public interface IView
    {
        void Print(string value);
        void PrintSpecial(string value); // when asynchronous without async/await
    }
}
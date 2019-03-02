using System.Threading;
using System.Threading.Tasks;

namespace WpfAppAsyncExperiments
{
    class BusinessRules
    {
        public static long Calculate()
        {
            Task.Delay(5000).Wait();
            return Thread.CurrentThread.ManagedThreadId;
        }
    }
}

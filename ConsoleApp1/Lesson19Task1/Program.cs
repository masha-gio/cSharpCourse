namespace Lesson19Task1
{
    internal class Program
    {
        static async Task Main()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken cancellationToken = cts.Token;

            var asyncExecutor = new AsyncExecutor();

            Action action = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            };

            var task = asyncExecutor.ExecuteAsync(action, cancellationToken);

            await Task.Delay(1000);
            cts.Cancel();

            await task;

        }
    }
}
namespace AsyncUsingTryOut
{
    public class MyIoService : IAsyncDisposable, IDisposable
    {
        public void DoIoTask()
        {
            try
            {
                Console.WriteLine("Performing IO task.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Shit is loos yo!");
            }
        }

        public ValueTask DisposeAsync()
        {
            Console.WriteLine($"{nameof(MyIoService)} disposed Async.");

            return ValueTask.CompletedTask;
        }

        public void Dispose()
        {
            Console.WriteLine($"{nameof(MyIoService)} disposed.");
        }
    }
}

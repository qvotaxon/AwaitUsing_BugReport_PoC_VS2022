using Microsoft.WindowsAzure.Storage;

namespace AsyncUsingTryOut
{
    public class NonsenseException : Exception { }

    public class Main
    {
        public async Task<dynamic> StartAsync()
        {
            await using var stream = new MemoryStream();

            try
            {
                await DoSomethingAsync();
                //throw new NonsenseException();
                return new
                {
                    FileName = "blaat",
                    FileContent = stream.ToArray()
                };
            }
            catch (NonsenseException x1)
            {
                Console.WriteLine("Ik ben hier");
                throw new Exception("regel25");
            }
            catch (Exception x2)
            {
                Console.WriteLine("Ik ben hier");
                throw new Exception("regel30");
            }

            //await DoSomethingAsync();
            //Console.WriteLine($"{nameof(MyIoService)} should be disposed now.");
        }

        //public void Start()
        //{
        //    DoSomething();
        //}

        private static async Task DoSomethingAsync()
        {
            await using var myIoService = new MyIoService();
            myIoService.DoIoTask();

            Console.WriteLine("Doing something.");
        }

        //private static void DoSomething()
        //{
        //    using var myIoService = new MyIoService();
        //    myIoService.DoIoTask();

        //    Console.WriteLine("Doing something.");
        //}
    }
}

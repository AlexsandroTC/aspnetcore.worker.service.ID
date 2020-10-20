using System;

namespace WorkerServiceDependencyInjector
{
    public class MyDependency : IMyDependency
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"My dependency write to message: { message }");
        }
    }
}
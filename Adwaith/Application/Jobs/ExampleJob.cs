using Coravel.Invocable;

namespace Adwaith.Application.Jobs
{
    public class ExampleJob : IInvocable
    {

        public ExampleJob()
        {
        }

        public Task Invoke()
        {
            Console.WriteLine("Do something in the background.");
            return Task.CompletedTask;
        }
    }
}

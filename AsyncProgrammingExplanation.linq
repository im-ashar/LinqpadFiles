<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>


async Task Main()
{
	await PerformAsyncOperation();
}

public async Task PerformAsyncOperation()
{
    Console.WriteLine("Starting async operation on thread: " + Thread.CurrentThread.ManagedThreadId);
    var result = await DoSomethingAsync();
    Console.WriteLine("Async operation completed on thread: " + Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine("Result: " + result);
}

public async Task<string> DoSomethingAsync()
{
	Console.WriteLine("1. Async operation running on thread: " + Thread.CurrentThread.ManagedThreadId);
	await Task.Delay(2000);
	Console.WriteLine("2. Async operation running on thread: " + Thread.CurrentThread.ManagedThreadId);
    return "Operation Completed";
}

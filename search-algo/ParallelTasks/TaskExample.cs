using System.Diagnostics;

namespace search_algo.ParallelTasks;
public class TaskExample
{

    public static void Executor()
    {
        DoSomething().Wait();
        Console.WriteLine("end Print");
    }
    public static async Task<int> AddSampling(int i)
    {
        await Task.Delay(1_000);
        Console.WriteLine($"Do some task {i}");
        return 1;
    }

    public static async Task DoSomething()
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        var promise = new List<Task>();
        await Task.Run(() =>
        {
            for (var i = 0; i < 10; i++)
            {
                promise.Add(AddSampling(i));
            }
        });
        await Task.WhenAll(promise);
        stopwatch.Stop();
        Console.WriteLine($"Time taken to execute : {stopwatch.Elapsed}");
    }
}
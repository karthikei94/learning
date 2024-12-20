using System.Diagnostics;

namespace search_algo.DesignPatterns.ParallelTasks;
public class TaskExample
{

    public static void Executor()
    {
        DoSomething().Wait();
        System.Console.WriteLine("end Print");
    }
    public static async Task<int> AddSampling(int i)
    {
        await Task.Delay(1_000);
        System.Console.WriteLine($"Do some task {i}");
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
        System.Console.WriteLine($"Time taken to execute : {stopwatch.Elapsed}");
    }
}
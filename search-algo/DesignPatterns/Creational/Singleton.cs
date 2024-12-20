namespace search_algo.DesignPatterns.Creational;

public class SingletonExectuor
{
    public static void Execute()
    {
        System.Console.WriteLine("Singleton instance test:");
        Singleton s1 = Singleton.GetInstance();
        var s2 = Singleton.GetInstance();
        System.Console.WriteLine("Completed");
    }
}

public sealed class Singleton
{
    private static int Counter = 0;
    private Singleton()
    {
        Counter++;
    }
    private static Singleton Instance = null;
    private static readonly object _lock = new object();

    public static Singleton GetInstance()
    {
        if (Instance == null)
        {
            lock (_lock)
            {
                Instance ??= new Singleton();
            }
        }
        System.Console.WriteLine(Counter);
        return Instance;
    }
}

public sealed class LazySingleton
{

    private static readonly Lazy<LazySingleton> Instance = new Lazy<LazySingleton>(() => new LazySingleton());
    
    private LazySingleton(){
    }
    public static LazySingleton GetInstance(){
        return Instance.Value;
    }

}
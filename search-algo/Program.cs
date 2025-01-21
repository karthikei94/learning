// See https://aka.ms/new-console-template for more information

using search_algo.DesignPatterns.Delegate;
using search_algo.LinkedList;

namespace search_algo;
public partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // JumpSearchOperation();
        // ExponenetialSearchOperation();
        // TernarySearchOperation();
        // SingleLinkedListImplemntation.Execute();
        // DoubleLinkedListImplemntation.Execute();
        // DesignPatterns.Structural.FacadePatternExection.Execute();
        // DesignPatterns.Structural.BridgePatternExampleExecutor.Execute();
        // DesignPatterns.Structural.CompositePatternExecutor.Execute();
        DesignPatterns.Behavioral.MementoPatternExecutor.Execute();
        // DesignPatterns.Creational.FactoryMethodExecution.Execute();
        // DesignPatterns.Creational.AbstractFactoryExecutor.Execute();
        // DesignPatterns.Creational.SingletonExectuor.Execute();
        // QuickSearchOperation.Execute();
        // SelectionSortExecutioner.Execute();
        // MergeSortExecutor.Execute();
        
        // DelegateExecutor.Execute();
        // DelegateRealWorldExector.Execute();
        // DelegateUsingLambdaRealWorldExector.Execute();
        
        // TPL
        // DesignPatterns.ParallelTasks.TaskExample.Executor();
        // DesignPatterns.ParallelTasks.SemaphoreSlimExample.Executor();
        // DesignPatterns.ParallelTasks.CancellationTokenExample.Executor();
        
        Console.ReadLine();
    }

}

using System.Runtime.CompilerServices;

namespace search_algo.Delegate;

using System;
using System.Threading;


public delegate void WorkPerformedHandler(int hours, string workType);
public delegate void WorkCompletedHandler(string workTyp);

public class Worker
{
    public void DoWork(int hours, string workType, WorkPerformedHandler del1, WorkCompletedHandler del2)
    {
        // del1 = null; //Allowing to set null
        // del2 = null; //Allowing to set null

        //Do Work here and notify the consumer that work has been performed
        for (int i = 0; i < hours; i++)
        {
            //Do Some Processing
            Thread.Sleep(1000);
            //Notfiy how much works have been done
            del1(i + 1, workType);
        }

        //Notfiy the consumer that work has been completed
        del2(workType);
    }
}


public class DelegateExecutor
{
    public static void Execute()
    {
        WorkPerformedHandler del1 = new WorkPerformedHandler(Worker_WorkPerformed);
        WorkCompletedHandler del2 = new WorkCompletedHandler(Worker_WorkCompleted);

        Worker worker = new Worker();
        worker.DoWork(5, "Generate Report", del1, del2);
    }

    private static void Worker_WorkCompleted(string workType)
    {
        Console.WriteLine($"{workType} work completed ");
    }

    private static void Worker_WorkPerformed(int hours, string workType)
    {
        Console.WriteLine($"{hours} Hours completed for {workType}");
    }
}

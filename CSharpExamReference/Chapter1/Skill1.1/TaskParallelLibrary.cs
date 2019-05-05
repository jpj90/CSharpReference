using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExamReference.Chapter1.Skill1._1
{
  public static class TaskParallelLibrary
  {
    public static void SubMain()
    {
      FirstExercise();
      Console.Read();
    }

    static void FirstExercise()
    {
      /*
       * Parallel.Invoke accepts actions and creates a Task for each one. 
       * Once every Task has finished executing, the Invoke method returns.
       * The Invoke() method can start many methods simultaneously, but you
       * have no control over which one is started when. 
       */
      Parallel.Invoke(() => Task1(), () => Task2(), () => Task3());
      Console.WriteLine("Finished processing tasks.");
    }

    static void Task1()
    {
      Console.WriteLine("Starting task 1");
      Thread.Sleep(3000);
      Console.WriteLine("Task 1 is ending");
    }

    static void Task2()
    {
      Console.WriteLine("Starting task 2");
      Thread.Sleep(2000);
      Console.WriteLine("Task 2 is ending");
    }

    static void Task3()
    {
      Console.WriteLine("Starting task 3");
      Thread.Sleep(1000);
      Console.WriteLine("Task 3 is ending");
    }
  }
}

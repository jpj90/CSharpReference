using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExamReference.Chapter1.Skill1._1
{
  public static class TaskParallelLibrary
  {
    public static void SubMain()
    {
      //FirstExercise();
      //SecondExcercise();
      ThirdExercise();
      Console.Read();
    }
    #region exercise 1

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
    #endregion

    #region exercise 2 and 3

    static void SecondExcercise()
    {
      var items = Enumerable.Range(0, 100);
      /*
       * The ForEach method accepts two parameters: the first
       * is an IEnumerable collection and the second a delegate
       * to be performed on each one of them. Note that this 
       * method has a lot more options that the simple Invoke 
       * method. Notice that the tasks are not completed in 
       * the order that they were started!
       */
      Parallel.ForEach(items, item => WorkOnItem(item));
    }

    static void ThirdExercise()
    {
      var items = Enumerable.Range(0, 10).ToArray();
      /*
       * The Parallel.For method is passed a counter starting at
       * an arbitrary position and running until the second parameter
       * is reached. The third argument is a delegate that is passed
       * a variable representing the iterator, starting at the value
       * of the first argument and running until the value of the second
       * argument. After executing all its cycles, the Parallel.For 
       * method returns. 
       */
      Parallel.For(3, items.Length, i =>
      {
        WorkOnItem(items[i]);
      });

      Console.WriteLine("Finished processsing Parallel.For()");
    }

    static void WorkOnItem(object item)
    {
      Console.WriteLine("Started working on: " + item);
      Thread.Sleep(300);
      Console.WriteLine("Finished working on: " + item);
    }
    #endregion
  }
}

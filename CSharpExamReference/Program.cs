using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpExamReference
{
  class Program
  {
    static void Main(string[] args)
    {
      Parallel.Invoke(() => Task1(), () => Task2());
      Console.WriteLine("Finished processing tasks.");
      Console.Read();
    }

    static void Task1()
    {
      Console.WriteLine("Starting task 1");
      Thread.Sleep(2000);
      Console.WriteLine("Task 1 is ending");
    }

    static void Task2()
    {
      Console.WriteLine("Starting task 2");
      Thread.Sleep(1000);
      Console.WriteLine("Task 2 is ending");
    }

  }
}

using System;

namespace MyProgram
{
  static class Program
  {
    static string NoDuplicates(string fras)
    {
      string[] ord = fras.Split();

      for (int i = 0; i < ord.Length; i++)
      {
        for (int j = i + 1; j < ord.Length; j++)
        {
          if (ord[i] == ord[j])
          {
            // Om två ord matchar, returnera "no"
            return "no, it's not unique";
          }
        }
      }

      // Om inga ord matchar, returnera "yes"
      return "yes, this phrase is unique";
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Enter a phrase:");
      string fras = Console.ReadLine().Trim();
      string result = NoDuplicates(fras);
      Console.WriteLine("result: " + result);
    }
  }
}

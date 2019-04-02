using System;

namespace underPressure
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      System.Console.WriteLine(Challenges.Challenges.DoubleInteger(7));
      System.Console.WriteLine(Challenges.Challenges.IsNumberEven(4));
      System.Console.WriteLine(Challenges.Challenges.GetFileExtension("test.txt"));
      System.Console.WriteLine(Challenges.Challenges.LongestString(new string[] { "test", "this is cool", "this works, now" }));
      System.Console.WriteLine(Challenges.Challenges.ArraySum(new int[] { 1, 2, 3, 4, 512, 34, 15 }));
      //   int DoubleInteger(int num)
      //   {
      //     System.Console.WriteLine("Give me a number to double..");
      //     string numString = Console.ReadLine();
      //     if (!Int32.TryParse(numString, out num))
      //     {
      //       System.Console.WriteLine("Provide a valid number");
      //     }
      //     int dubNum = num * 2;
      //     return dubNum;
      //   }

      //   bool IsNumberEven(int num)
      //   {
      //       System.Console.WriteLine("Give me a number, I'll tell you if it's even..");
      //     string numString = Console.ReadLine();
      //     if (!Int32.TryParse(numString, out num))
      //     {
      //       System.Console.WriteLine("Provide a valid number");
      //     } else if(num % 2=0)
      //     {
      //       return true;
      //     }
      //   }
    }
  }
}

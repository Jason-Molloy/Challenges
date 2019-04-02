namespace Challenges
{

  static class Challenges
  {
    public static int DoubleInteger(int num)
    {
      return num * 2;
    }
    public static bool IsNumberEven(int num)
    {
      return num % 2 == 0;
    }
    public static string GetFileExtension(string str)
    {
      int cutIndex = str.LastIndexOf('.');
      if (cutIndex > -1)
      {
        return str.Substring(cutIndex + 1);
      }
      return null;
    }

    public static string LongestString(string[] strArr)
    {
      string Longest = "";
      foreach (var str in strArr)
      {
        if (str.Length > Longest.Length)
        {
          Longest = str;
        }
      }
      return Longest;
    }
    public static int ArraySum(int[] nums)
    {
      int sum = 0;
      foreach (int num in nums)
      {
        sum += num;
      }
      return sum;
    }
  }

}
using System.Threading;
class Program
{
  static void Main()
  {
    string? strInput = "";
    int intSeconds;

    try
    {
      while (true)
      {
        Console.Write("秒数(整数)を入力してください：");
        strInput = Console.ReadLine();

        if(int.TryParse(strInput, out intSeconds))
        {
          break;
        }
      }

      for (int intCount = intSeconds; intCount > 0; intCount--)
      {
        Console.WriteLine("カウントダウン：" + intCount);
        Thread.Sleep(1000);
      }

      Console.WriteLine("0");
      Console.WriteLine("終了");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"予期しないエラーが発生しました: {ex.Message}");
    }
  }
}
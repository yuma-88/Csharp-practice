using System.Runtime.CompilerServices;

class Program
{
  static void Main()
  {
    int intPlayerHand, intCpuHand;
    try
    {
      Random rnd = new Random();
      
      Console.WriteLine("=== じゃんけんコンソールアプリ ===");

      while (true)
      {
        Console.WriteLine("1:グー / 2:チョキ / 3:パー");
        while (true)
        {
          Console.Write("あなたの出す手を選択してください（1~3の整数を入力）:");

          if (int.TryParse(Console.ReadLine(), out intPlayerHand))
          {
            if (intPlayerHand > 0 && intPlayerHand < 4)
            {
              break;
            }
          }

          Console.WriteLine("正しい値を入力してください。（1~3の整数）");
        }

        intCpuHand = rnd.Next(1, 4);
        Console.WriteLine($"あなた: {HandToString(intPlayerHand)} vs CPU: {HandToString(intCpuHand)}");

        if (intPlayerHand == intCpuHand)
        {
          Console.WriteLine("あいこです！");
        }
        else if ((intPlayerHand == 1 && intCpuHand == 2) ||
                  (intPlayerHand == 2 && intCpuHand == 3) ||
                  (intPlayerHand == 3 && intCpuHand == 1))
        {
          Console.WriteLine("あなたの勝ちです！");
        }
        else
        {
          Console.WriteLine("あなたの負けです！");
        }

        while (true)
        {
          Console.WriteLine("続けますか？y/n");
          string? strAnswer = Console.ReadLine();

          if (strAnswer == "y" || strAnswer == "Y")
          {
            Console.WriteLine();
            break;
          }
          else if (strAnswer == "n" || strAnswer == "N")
          {
            return;
          }
          else
          {
            Console.WriteLine("y か n で入力してください。");
          }
        }
      }
    }
    catch(Exception ex)
    {
      Console.WriteLine($"予期しないエラーが発生しました: {ex.Message}");
    }
  }

  static string HandToString(int hand)
      {
        switch (hand)
        {
          case 1:
          {
            return "グー";
          }
          case 2:
          {
            return "チョキ";
          }
          default:
          {
            return "パー";
          }
        }
      }
}
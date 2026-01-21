using System.Runtime.CompilerServices;

class Program
{
  static void Main()
  {
    Console.WriteLine("=== 四則計算コンソールアプリ ===");

    double first = ReadDouble("一つ目の値を入力してください:");
    double second = ReadDouble("二つ目の値を入力してください:");

    Calculator calc = new Calculator(first, second);

    while (true)
    {
      Console.WriteLine();
      Console.WriteLine("1:+  2:-  3:*  4:/");
      Console.Write("選択番号:");

      string? select = Console.ReadLine();

      double result;

      switch (select)
      {
        case "1":
        {
          result = calc.Sum();
          break;
        }
        case "2":
        {
          result = calc.Difference();
          break;
        }
        case "3":
        {
          result = calc.Product();
          break;
        }
        case "4":
        {
          result = calc.Quotient();
          break;
        }
        default:
        {
          Console.WriteLine("選択肢から選んでください。");
          continue;
        }
      }

      Console.WriteLine($"計算結果: {result}");
      return;
    }
  }

  private static double ReadDouble(string message)
  {
    while (true)
    {
      Console.Write(message);
      string? input = Console.ReadLine();

      if (double.TryParse(input, out double value))
      {
        return value;
      }

      Console.WriteLine("正しい数値を入力してください。");
    }
  }
}
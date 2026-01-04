using System;
using System.IO.Pipelines;

class Program
{
  static void Main()
  {
    try
    {
      double dblresult; // 計算結果
      double dblFirstNum; // 一つ目の値
      double dblSecondNum; // 二つ目の値

      // タイトルの表示
      Console.WriteLine("=== 四則計算コンソールアプリ ===");

      // 一つ目の値の処理
      while (true)
      {
        Console.Write("１つ目の数字：");
        string? strFirstInput = Console.ReadLine();

        if (double.TryParse(strFirstInput, out dblFirstNum))
        {
          break;
        }
        Console.WriteLine("数値を入力してください。");
      }

      // 二つ目の値の処理
      while (true)
      {
        Console.Write("２つ目の数字：");
        string? strSecondInput = Console.ReadLine();

        if (double.TryParse(strSecondInput, out dblSecondNum))
        {
          break;
        }
        Console.WriteLine("数値を入力してください。");
      }

      // 演算子の選択
      string? strOperator;
      while (true)
      {
          Console.Write("演算子を入力（+ - * /）：");
          strOperator = Console.ReadLine();

          if (strOperator is "+" or "-" or "*" or "/")
          {
              break;
          }

          Console.WriteLine("正しい演算子を入力してください。");
      }

      // 演算子選択結果による処理
      switch (strOperator)
      {
        case "+": // 「+」の場合
        {
          dblresult = dblFirstNum + dblSecondNum;
          break;
        }
        case "-": // 「-」の場合
        {
          dblresult = dblFirstNum - dblSecondNum;
          break;
        }
        case "*": // 「*」の場合
        {
          dblresult = dblFirstNum * dblSecondNum;
          break;
        }
        case "/": // 「/」の場合
        {
          if (dblSecondNum == 0)
          {
            Console.WriteLine("0で割ることはできません。");
            return;
          }
          dblresult = dblFirstNum / dblSecondNum;
          break;
        }
        default:
        {
          return;
        }
      }
      Console.WriteLine($"結果: {dblresult}");
    }
    catch(Exception ex)
    {
      Console.WriteLine($"予期しないエラーが発生しました: {ex.Message}");
    }
  }
}
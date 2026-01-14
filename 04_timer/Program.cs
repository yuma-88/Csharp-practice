using System;
using System.Threading;

class Program
{
  #region メイン処理
  /// <summary>
  /// メイン処理
  /// </summary>
  static void Main()
  {
    Console.WriteLine("=== タイマーコンソールアプリ ===");
    Console.WriteLine("P: 一時停止 / 再開, Q: 終了");

    int seconds = ReadSeconds(); // 入力チェック

    Timer timer = new Timer(seconds);

    Thread inputThread = new Thread(() => ListenKey(timer)); // スレッド作成
    inputThread.Start();

    timer.Start(); // タイマースタート

    Console.WriteLine("終了しました。");
  }
  #endregion

  #region 入力チェック
  /// <summary>
  /// 入力チェック
  /// </summary>
  /// <returns></returns>
  private static int ReadSeconds()
  {
    while (true)
    {
      Console.Write("秒数を入力してください:");
      if (int.TryParse(Console.ReadLine(), out int seconds) && seconds > 0)
      {
        return seconds;
      }
      Console.WriteLine("1秒以上の秒数を入力してください。");
    }
  }
  #endregion

  #region キー入力処理
  /// <summary>
  /// キー入力処理
  /// </summary>
  /// <param name="timer"></param>
  private static void ListenKey(Timer timer)
  {
    // 動いてる間ループ
    while (!timer.IsFinished)
    {
      if (Console.KeyAvailable)
      {
        var key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.P)
        {
          timer.TogglePause();
        }
        else if (key == ConsoleKey.Q)
        {
          timer.Finish();
        }
      }

      Thread.Sleep(50);
    }
  }
  #endregion
}
using System;
using System.Threading;

class Timer
{
  #region 変数
  private int _counts;
  private bool _isPaused;
  private bool _isFinished;
  #endregion

  #region コンストラクタ
  /// <summary>
  /// タイマーコンストラクタ
  /// </summary>
  /// <param name="seconds"></param>
  public Timer(int seconds)
  {
    _counts = seconds;
  }
  #endregion

  #region 終了フラグ
  /// <summary>
  /// 終了フラグ
  /// </summary>
  public bool IsFinished
  {
    get { return _isFinished; }
  }
  #endregion

  #region 停止切り替え処理
  /// <summary>
  /// 停止切り替え処理
  /// </summary>
  public void TogglePause()
  {
    _isPaused = !_isPaused;
    Console.WriteLine(_isPaused ? "⏸ 一時停止" : "▶ 再開");
  }
  #endregion

  #region 終了処理
  /// <summary>
  /// 終了処理
  /// </summary>
  public void Finish()
  {
    _isFinished = true;
  }
  #endregion

  #region カウントダウン処理
  /// <summary>
  /// カウントダウン処理
  /// </summary>
  public void Start()
  {
    while (_counts > 0 && !_isFinished)
    {
      // スレッドを短く停止しキー入力を受け入れ
      if (_isPaused)
      {
        Thread.Sleep(100);
        continue;
      }

      Console.WriteLine($"残り{_counts}秒");

      // 応答速度を上げるためスレッドを短停止
      for (int i = 0; i < 10; i++)
      {
        if (_isPaused || _isFinished) break;
        Thread.Sleep(100);
      }

      // 動いている場合カウントダウン
      if (!_isPaused)
      {
        _counts--;
      }
    }

    _isFinished = true;
  }
  #endregion
}
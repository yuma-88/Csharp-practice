class Calculator
{
  private readonly double _first;
  private readonly double _second;

  public Calculator(double first, double second)
  {
    _first = first;
    _second = second;
  }

  public double Sum()
  {
    return _first + _second;
  }

  public double Difference()
  {
    return _first - _second;
  }

  public double Product()
  {
    return _first * _second;
  }

  public double Quotient()
  {
    if (_second == 0)
    {
      Console.WriteLine("0では割れません。");
      return 0;
    }

    return _first/_second;
  }
}
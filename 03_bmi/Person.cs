class Person
{
    public double Height { get; }
    public double Weight { get; }

    public Person(double height, double weight)
    {
        if (height <= 0)
            throw new ArgumentException("身長は0より大きい必要があります。");

        if (weight <= 0)
            throw new ArgumentException("体重は0より大きい必要があります。");

        Height = height;
        Weight = weight;
    }
}

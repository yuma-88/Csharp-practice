class BmiCalculator
{
    public double Calculate(Person person)
    {
        return person.Weight / (person.Height * person.Height);
    }

    public string GetCategory(double bmi)
    {
        if (bmi < 18.5)
            return "痩せ気味です。";

        if (bmi < 25.0)
            return "普通体重です。";

        return "肥満です。";
    }
}

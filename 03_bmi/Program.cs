class Program
{
    static void Main()
    {
        Console.WriteLine("=== BMI計算コンソールアプリ ===");

        try
        {
            double weight = ReadDouble("体重を入力してください（Kg）: ");
            double height = ReadDouble("身長を入力してください（m）: ");

            var person = new Person(height, weight);
            var calculator = new BmiCalculator();

            double bmi = calculator.Calculate(person);
            double roundedBmi = Math.Round(bmi, 1);
            string category = calculator.GetCategory(roundedBmi);

            Console.WriteLine($"あなたのBMIは {roundedBmi} です。");
            Console.WriteLine(category);
            Console.WriteLine("（BMI正常値は18.5以上25.0未満です。）");
        }
        catch (ArgumentException ex)
        {
            // Person で投げられた「意味的におかしい値」をここで受け取る
            Console.WriteLine($"入力エラー: {ex.Message}");
        }
    }

    static double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out double value))
            {
                return value;
            }
            Console.WriteLine("数値を入力してください。");
        }
    }
}

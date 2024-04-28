class ArithmeticProgression
{
    private double a0;
    private double d;
    private int n;

    public void InputData()
    {
        Console.Write("Введіть перший член прогресії (a0): ");
        a0 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть різницю прогресії (d): ");
        d = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість членів прогресії (n): ");
        n = Convert.ToInt32(Console.ReadLine());
    }

    public double CalculateSum()
    {
        return n * (2 * a0 + (n - 1) * d) / 2;
    }
}

class Program
{
    static void Main()
    {
        ArithmeticProgression progression = new ArithmeticProgression();
        progression.InputData();
        double sum = progression.CalculateSum();

        Console.WriteLine($"Сума: {sum}");
    }
}
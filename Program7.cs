using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов последовательности: ");
        var n = double.Parse(Console.ReadLine());
        double a;
        double sr = 0;
        for (int i = 0;i < n;i++)
        {
         Console.Write("Введите число: ");
         a = double.Parse(Console.ReadLine());
         sr = sr + a;
        }
        sr = sr/n;
        Console.WriteLine("Среднее арифметическое: {0}",sr);
        Console.ReadKey();
    }
}

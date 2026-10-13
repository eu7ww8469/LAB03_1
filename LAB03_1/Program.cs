namespace LAB03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine()!);

            int sum = a + b;
            int diff = a - b;
            int prod = a * b;
            double avg = (a + b) / 2.0;

            Console.WriteLine();
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разность: {diff}");
            Console.WriteLine($"Произведение: {prod}");
            Console.WriteLine($"Среднее арифметическое: {avg}");
        }
    }
}
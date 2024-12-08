class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите число B: ");
        int b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            Console.WriteLine("Числа в порядке возрастания:");
            for (int i = a; i <= b; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            Console.WriteLine("Числа в порядке убывания:");
            for (int i = a; i >= b; i--)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}

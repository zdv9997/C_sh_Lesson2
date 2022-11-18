while (true)
{
    Console.Write("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 99 && num < 1000)
    {
        int n1 = (num % 100) / 10;
        Console.Write($"Вторая цифра числа равняется: {n1}");
        break;
    }
}

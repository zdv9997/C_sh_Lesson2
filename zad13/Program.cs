Console.Clear();
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = -1;
if (num < 100)
{
    Console.WriteLine($"Число {num} не имеет третьей цифры");
}
else
{
    if (num > 999)
    {
        result = (num % 1000) / 100;
        Console.WriteLine($"Третья цифра числа {num} является {result}");
    }
    else
    {
        result = num / 100;
        Console.WriteLine($"Третья цифра числа {num} является {result}");
    }
}



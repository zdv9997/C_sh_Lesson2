Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7) Console.WriteLine("это выходной день");
else Console.WriteLine("Это рабочий день");

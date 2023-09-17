int p = 1;
while (p == 1)
{
    Console.WriteLine(
        "выберите действие: " +
"\r\n1. Сложить 2 числа" +
"\r\n2. Вычесть первое из второго" +
"\r\n3. Перемножить два числа" +
"\r\n4. Разделить первое на второе" +
"\r\n5. Возвести в степень N первое число" +
"\r\n6. Найти квадратный корень из числа" +
"\r\n7. Найти 1 процент от числа" +
"\r\n8. Найти факториал из числа" +
"\r\n9. Выйти из программы");
    string o = Console.ReadLine();
    int x = Convert.ToInt32(o);
    if (x == 1)
    {
        Console.WriteLine("введите первое слогаемое.");
        string z = Console.ReadLine();
        int a = Convert.ToInt32(z);
        Console.WriteLine("введите второе слогаемое.");
        string c = Console.ReadLine();
        int s = Convert.ToInt32(c);
        int d = a + s;
        Console.WriteLine("ответ: " + d);
    }
    if (x == 2)
    {
        Console.WriteLine("введите уменьшаемое");
        string z = Console.ReadLine();
        int a = Convert.ToInt32(z);
        Console.WriteLine("введите вычитаемое");
        string c = Console.ReadLine();
        int s = Convert.ToInt32(c);
        int d = a - s;
        Console.WriteLine("ответ: " + d);
    }
    if (x == 3)
    {
        Console.WriteLine("введите первый множитель");
        string z = Console.ReadLine();
        int a = Convert.ToInt32(z);
        Console.WriteLine("введите второй множитель.");
        string c = Console.ReadLine();
        int s = Convert.ToInt32(c);
        int d = a * s;
        Console.WriteLine("ответ: " + d);
    }
    if (x == 4)
    {
        Console.WriteLine("введите делимое");
        string z = Console.ReadLine();
        double a = Convert.ToDouble(z);
        Console.WriteLine("введите делитель");
        string c = Console.ReadLine();
        double s = Convert.ToDouble(c);
        double d = a /s;
        Console.WriteLine("ответ: " + d);
    }
    if (x == 5)
    {
        Console.WriteLine("введите число");
        string z = Console.ReadLine();
        double a = Convert.ToDouble(z);
        Console.WriteLine("введите степень");
        string c = Console.ReadLine();
        double s = Convert.ToDouble(c);
        double d = Math.Pow(a, s);
        Console.WriteLine("ответ: " + d);
    }
    if (x == 6)
    {
        Console.WriteLine("введите число");
        string z = Console.ReadLine();
        double a = Convert.ToDouble(z);
        double d = Math.Sqrt(a);
        Console.WriteLine("ответ: " + d);
    }
    if (x == 7)
    {
        Console.WriteLine("введите число");
        string z = Console.ReadLine();
        double a = Convert.ToDouble(z);
        double d = a / 100;
        Console.WriteLine("ответ: " + d);
    }
    if (x == 8)
    {
        Console.WriteLine("введите число");
        string z = Console.ReadLine();
        int a = Convert.ToInt32(z);
        int g = a - 1;
        for (int i = g; i> 1;i--)
        {
            a = a * i;
        }
        Console.WriteLine("Ответ: " + a);
    }
    if (x == 9)
    {
        break;
    }
}
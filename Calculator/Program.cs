Console.WriteLine("Меню:\r\n" +
    "1. Сложить 2 числа\r\n" +
    "2. Вычесть первое из второго\r\n" +
    "3. Перемножить два числа\r\n" +
    "4. Разделить первое на второе\r\n" +
    "5. Возвести в степень N первое число\r\n" +
    "6. Найти квадратный корень из числа\r\n" +
    "7. Найти 1 процент от числа\r\n" +
    "8. Найти факториал из числа\r\n" +
    "9. Выйти из программы");
do
{

    Console.WriteLine("Введите операцию, которую хотите выполнить:");
    int menureader = Convert.ToInt32(Console.ReadLine());


    while (menureader > 9)
    {
        Console.WriteLine("Введите число из списка");
        menureader = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = menureader; i == 1; i--)
    {
        Console.WriteLine("Введите первое число");
        int firstnumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int secondnumber = Convert.ToInt32(Console.ReadLine());
        int summ = firstnumber + secondnumber;
        Console.WriteLine("Сумма двух чисел:" + summ);
    }

    for (int i = menureader; i == 2; i--)
    {
        Console.WriteLine("Введите первое число");
        int subtraction1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int subtraction2 = Convert.ToInt32(Console.ReadLine());
        int subtractionresult = subtraction1 - subtraction2;
        Console.WriteLine("Разность двух чисел равна:" + subtractionresult);
    }

    for (int i = menureader; i == 3; i--)
    {
        Console.WriteLine("Введите первое число");
        int multiplication1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int multiplication2 = Convert.ToInt32(Console.ReadLine());
        int multiplicationresult = multiplication1 * multiplication2;
        Console.WriteLine("Произведение двух чисел равно:" + multiplicationresult);
    }

    for (int i = menureader; i == 4; i--)
    {
        Console.WriteLine("Введите первое число");
        double division1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double division2 = Convert.ToDouble(Console.ReadLine());
        double divisionresult = (double)division1 / (double)division2;
        Console.WriteLine("Результат деления:" + divisionresult);
    }

    for (int i = menureader; i == 5; i--)
    {
        Console.WriteLine("Введите число, которое возведется в степень");
        int degree1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень числа");
        int degree2 = Convert.ToInt32(Console.ReadLine());
        double degreeresult = Math.Pow(degree1, degree2);
        Console.WriteLine("Результат возведения в степень:" + degreeresult);
    }

    for (int i = menureader; i == 6; i--)
    {
        Console.WriteLine("Введите число, из которого извлечется корень");
        int root = Convert.ToInt32(Console.ReadLine());
        double rootresult = Math.Sqrt(root);
        Console.WriteLine("Корень числа:" + rootresult);
    }

    for (int i = menureader; i == 7; i--)
    {
        Console.WriteLine("Введите число");
        int procent = Convert.ToInt32(Console.ReadLine());
        double procentresult = ((double)procent / 100) * 1;
        Console.WriteLine("1 процент от числа:" + procentresult);
    }

    for (int i = menureader; i == 8; i--)
    {

        Console.Write("Введите число : ");
        int num = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int a = 1; a <= num; a++)
        {
            factorial *= a;
        }
        Console.WriteLine(factorial);
       
    }

    for (int i = menureader; i == 9; i--)
    {

        return 0;

    }
}

while (true);


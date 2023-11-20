// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// Функция запрашивает ввод double-числа и проверят его на корректность.
double CheckInputDouble(string message)
{
    bool check = false;
    Console.Write($"{message} ");
    check = double.TryParse(Console.ReadLine().Trim().Replace('.', ','), out double number);
    while (check == false)
    {
        Console.Write($"Неверные данные. {message} ");
        check = double.TryParse(Console.ReadLine().Trim().Replace('.', ','), out number);
    }
    return number;
}

// Функция вычисляет точку пересечения графиков уравнений.
double[] GetIntersecPoint(double k1, double b1, double k2, double b2)
{
    double[] intersecPoint = new double[2];
    intersecPoint[0] = (b2 - b1) / (k1 - k2);
    intersecPoint[1] = k1 * intersecPoint[0] + b1;
    return intersecPoint;
}

double[] coeffArray = new double[4];
Console.Clear();
Console.WriteLine("Введите коэффициенты для функции  Y = K1 * X + B1");
Console.WriteLine("---------------------------------------------------");
coeffArray[0] = CheckInputDouble("Введите коэффициент K1:");
coeffArray[1] = CheckInputDouble("Введите коэффициент B1:");
Console.WriteLine();
Console.WriteLine("Введите коэффициенты для уравнения  Y = K2 * X + B2");
Console.WriteLine("---------------------------------------------------");
coeffArray[2] = CheckInputDouble("Введите коэффициент K2:");
coeffArray[3] = CheckInputDouble("Введите коэффициент B2:");
Console.WriteLine();
if (coeffArray[0] == coeffArray[2])
{
    Console.WriteLine("Графики функций не пересекаются");
}
else
{
    double[] intersecPoint = GetIntersecPoint(coeffArray[0], coeffArray[1], coeffArray[2], coeffArray[3]);
    Console.WriteLine($"Координаты точки пересечения графиков функций: {intersecPoint[0]:f3} {intersecPoint[1]:f3}");
}
Console.WriteLine();
// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Функция находит колличество положительных элементов double-массива.
int CountPosNumbersInArray(double[] array)
{
    int result = 0;
    foreach (double item in array)
    {
        if (item > 0) result++;
    }
    return result;
}

// Функция запрашивает ввод строки с числами, разделенными пробелами, и преобразует ее в double-массив.
double[] InputDoubleArrayFromKeyboard(string message)
{
    Console.WriteLine(message);
    string[] numbersString = Console.ReadLine().Trim().Replace('.', ',').Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
    double[] numbers = new double[numbersString.Length];
    bool check = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        check = double.TryParse(numbersString[i], out numbers[i]);
        if (check == false)
        {
            break;
        }
    }
    while (check == false)
    {
        Console.WriteLine($"НЕВЕРНЫЕ ДАННЫЕ. {message}");
        numbersString = Console.ReadLine().Trim().Replace('.', ',').Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        numbers = new double[numbersString.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            check = double.TryParse(numbersString[i], out numbers[i]);
            if (check == false)
            {
                break;
            }
        }
    }
    return numbers;
}

Console.Clear();
double[] userArray = InputDoubleArrayFromKeyboard("Введите числа, разделяя их пробелом");
Console.Clear();
Console.WriteLine($"Ваш массив: [{String.Join(", ", userArray)}]");
int posNumbersCount = CountPosNumbersInArray(userArray);
Console.WriteLine($"Количество положительных чисел: {posNumbersCount}");
// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] Input(string abc, int lenght) // Записываем массив из строки по заданной длине
{
    int[] numbers = new int[lenght];
    Console.Write($"{abc} ");
    string[] input = Console.ReadLine()!.Split(',');
    for (int i = 0; i < numbers.Length; ++i)
        numbers[i] = int.Parse(input[i]);

    return numbers;
}

int GetNum(string message) //Функция запроса числа у пользователя
{
    Console.Write($"{message} ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FindNumber(int[] array, int b)
{
    bool flag = false;
    foreach (int i in array)
    {
        if (i == b)
        {
            flag = true;
            break;
        }
    }

    if (flag) Console.WriteLine($"Число {b} является элементов массива");
    else Console.WriteLine($"Число {b} не является элементов массива");
}

int a = GetNum("Введите длину массива:");
int[] array = Input("Введите массив через запятую:", a);
int b = GetNum("Введите искомое число: ");
FindNumber(array, b);

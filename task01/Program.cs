// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue) //Генерируем новый массив
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
        result[i] = new Random().Next(minValue, maxValue+1);
    return result;
}

int GetNum(string message) //Функция запроса числа у пользователя
{
    Console.Write($"{message} ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] Reverse(int[] array)
{
for(int i=0; i < array.Length;i++)
{
    array[i]=array[i]*-1;
}
return array;
}

void PrintArray(string abc, int[] arr) //Распечатать массив
{
    Console.WriteLine(abc);
    for (int i = 0; i < arr.Length; i++)
        if (i == arr.Length - 1)
            Console.Write(arr[i]);
        else
            Console.Write($"{arr[i]}, ");
}

int arrSize = GetNum("Задайте длину массива");
int arrMin = GetNum("Задайте минимальное значение массива:");
int arrMax = GetNum("Задайте максимальное значение массива:");

int[] array = GetArray(arrSize, arrMin, arrMax);
PrintArray("Массив на входе:", array);


PrintArray("\n Массив на выходе:", Reverse(array));
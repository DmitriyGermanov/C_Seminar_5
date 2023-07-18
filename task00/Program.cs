﻿// Задача 31: Задайте массив из 12 
// элементов, заполненный случайными числами
//  из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.

int GetNum(string message) //Функция запроса числа у пользователя
{
    Console.Write($"{message} ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] GetArray(int size, int minValue, int maxValue) //Генерируем новый массив
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
        result[i] = new Random().Next(minValue, maxValue);
    return result;
}

void PrintArray(int[] arr) //Распечатать массив
{
    for (int i = 0; i < arr.Length; i++)
        if (i == arr.Length - 1)
            Console.Write(arr[i]);
        else
            Console.Write($"{arr[i]}, ");
}



int sizeArray = GetNum("Введите длину массива:");
int min = GetNum("Введите минимальное значение диапазона для элементов массива:");
int max = GetNum("Введите минимальное значение диапазона для элементов массива:");
int[] array = GetArray(sizeArray, min, max);

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)
{
    if (el > 0)
    positiveSum += el;
    else
    negativeSum += el;
}
Console.WriteLine($"Сумма положительных элементов массива = {positiveSum}\nСумма отрицательных элементов массива = {negativeSum}");
PrintArray(array);


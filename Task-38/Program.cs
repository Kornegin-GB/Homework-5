// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

using System;
using static System.Console;
Clear();

Write("Введите размер массива: ");
int size = Convert.ToInt32(ReadLine());

double[] Mass = new double[size];

GetFillArray(Mass);
double minNumber = MinNumberArray(Mass);
double maxNumber = MaxNumberArray(Mass);
Write($"[{String.Join(", ", Mass)}] -> {maxNumber - minNumber}");

void GetFillArray(double[] array) // Заполняем массив случайными числами
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().NextDouble() * 10;
   }
}

double MinNumberArray(double[] array) // Находим минимальное число массива
{
   double minNum = array[0];
   for (int i = 1; i < array.Length; i++)
   {
      if (array[i] < minNum) minNum = array[i];
   }
   return minNum;
}

double MaxNumberArray(double[] array) // Находим максимальное число массива
{
   double maxNum = array[0];
   for (int i = 1; i < array.Length; i++)
   {
      if (array[i] > maxNum) maxNum = array[i];
   }
   return maxNum;
}
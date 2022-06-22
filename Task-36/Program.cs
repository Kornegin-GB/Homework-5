// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
using static System.Console;
Clear();

Write("Введите размер массива: ");
int size = Convert.ToInt32(ReadLine());
int min = -100;
int max = 100;

int[] Mass = new int[size];

GetFillArray(Mass, min, max);
Write($"[{String.Join(", ", Mass)}] -> {SumNumberArray(Mass)}");

void GetFillArray(int[] array, int randomMin, int randomMax) // Заполняем массив случайными числами
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(randomMin, randomMax + 1);
   }
}

int SumNumberArray(int[] array) // Находим сумму чисел на нечетных позициях
{
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (i % 2 != 0) sum += array[i];
   }
   return sum;
}
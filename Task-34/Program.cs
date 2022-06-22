// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using System;
using static System.Console;
Clear();

Write("Введите размер массива: ");
int size = Convert.ToInt32(ReadLine());
int min = 100;
int max = 999;

int[] numberMass = new int[size];

GetFillArray(numberMass, min, max);
Write($"В массиве [{String.Join(", ", numberMass)}]");
WriteLine($" четных чисел содержится {EvenNumbers(numberMass)}");

void GetFillArray(int[] array, int randomMin, int randomMax)
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(randomMin, randomMax + 1);
   }
}

int EvenNumbers(int[] array)
{
   int n = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] % 2 == 0) n++;
   }
   return n;
}
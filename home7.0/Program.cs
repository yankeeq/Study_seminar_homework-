﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.Write("Введите кол-во строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
}
}
}

void PrintArray(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} \t");
}
Console.WriteLine("");
}
}
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание, что такого 
//  элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];
Console.Write("Введите позицию строки: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(0,10);
Console.Write($"{randomArray[i,j]} ");
}
Console.WriteLine();
}
}
mas(m,n);
if (m2<1 || n2<1)
Console.Write("Позиции строк не могут быть отрицательными");
else if (m2 <= m+1 && n2 <= n+1)
Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]} ");
else Console.Write("Такого элемента нет в массиве");
*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
Console.Write("Введите размерность m массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int m = Convert.ToInt32(Console.ReadLine());

void FillArrayRandomNumbers(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(0, 10);
}
}
}
int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
double avarage = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
avarage = (avarage + numbers[i, j]);
}
avarage = avarage / n;
Console.Write(avarage + "; ");
}
Console.WriteLine("");
PrintArray(numbers);
void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
        
Console.WriteLine("");
}
}
*/

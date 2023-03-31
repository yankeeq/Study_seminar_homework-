// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int[,] FillMatrixWithRandom(int row, int column)
{
int[,] matrix = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(0, 10);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}

void Uporyad(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int k = 0; k < matrix.GetLength(1) - 1; k++)
{
if (matrix[i, k] < matrix[i, k + 1])
{
int temp = matrix[i, k + 1];
matrix[i, k + 1] = matrix[i, k];
matrix[i, k] = temp;
}
}
}
}
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine();
Uporyad(matrix);
PrintMatrix(matrix);
*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт 
//номер строки с наименьшей суммой элементов: 1 строка
/*

int[,] FillMatrixWithRandom(int row, int column)

{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} \t");
}
Console.WriteLine();
}
}
Console.WriteLine("Задайте прямоугольный двумерный массив");
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);

PrintMatrix(matrix);

int SumLine(int[,] array, int i)

{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sum += array[i,j];
}
return sum;
}

int minSum = 1;
int sum = SumLine(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
if (sum > SumLine(matrix, i))
{
sum = SumLine(matrix, i);
minSum = i+1;
}
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");
System.Console.WriteLine();
*/




// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[,,] CreateMatrix (int row, int col, int dep, int min, int max) 
{
int[,,] matrix = new int[row, col, dep];
Random rnd = new Random();   
for (int i = 0; i < matrix.GetLength(0); i++) 
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int k = 0; k < matrix.GetLength(2); k++)
{
matrix[i,j,k] = rnd.Next(min, max + 1);
}
}
}
return matrix;
} 
 
void PrintMatrix(int[,,] matrix)
{
for (int i = 0; i <  matrix.GetLength(0); i++)
{
        
for (int j = 0; j < matrix.GetLength(1); j++) 
{
for (int k = 0; k < matrix.GetLength(2); k++)
{
Console.WriteLine($"{matrix[i, j, k],1}({i},{j},{k})");            
}
}
Console.WriteLine();        
}        
}
 
int[,,] array3D = CreateMatrix(2, 2, 2, 10, 99);
PrintMatrix(array3D);
*/
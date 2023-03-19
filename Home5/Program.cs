// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(100,1000);

}

}

int kol(int[] randomArray)
{
int kol = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
kol = kol + 1;
}
return kol;
}

mas(a);
System.Console.WriteLine($"[{string.Join(", ", randomArray)}]");
Console.Write($"\nКоличество чётных чисел в массиве: {kol(randomArray)}");
*/



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];
DateTime dt = DateTime.Now;  ///время работы

void mas(int a)
{
   
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(1,10);
}
}
int kol(int[] randomArray)
{
int sum = 0;
int i = 0;
while (i < randomArray.Length)
{
sum = sum + randomArray[i];
i = i + 2;
}
return sum;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); ///время работы
mas(a);
System.Console.WriteLine($"[{string.Join(", ", randomArray)}]");
Console.Write($"\nКоличество нечётных чисел в массиве: {kol(randomArray)}");
*/



// Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

// double[] array = new double[n];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// array[i] = rand.Next(1, 100) + rand.NextDouble();

/*
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
{
randomArray[i] = rand.NextDouble();
Console.Write($"{randomArray[i]:F2} ");
}

}

double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

mas(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raz(randomArray):F2}");
*/
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
int num,r,sum=0,t;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<100000)
{
for(t=num;num!=0;num=num/10)
{
r=num % 10;
sum=sum*10+r;
}
if(t==sum)
Console.Write($"{t} является палиндромом.");
else
Console.Write($"{t} не является палиндромом.");
} else
Console.Write("Введите пятизначное число! ");
*/



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Distance2D(double x1, double y1, double z1, double x2, double y2, double z2)
{
double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
return Math.Round(res, 2);
}

Console.Write("Введите координаты по Х для первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z для второй точки ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Х для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z для второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());


double distance = Distance2D(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Расстояние между точками = {distance}");
*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
Console.WriteLine("напишите число");
int number = Convert.ToInt32(Console.ReadLine());

for(int i=1; i <=number; i++)
{
   
    Console.Write(" ");
    System.Console.Write($"{Math.Pow(i,3)}");
    System.Console.Write($"[{string.Join(", ", i, number )}]");
}
*/

// Task2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
/*
{
 
int num1, num2; 
Console.WriteLine("Введите два числа : ");
num1 = Convert.ToInt32(Console.ReadLine()); 
num2 = Convert.ToInt32(Console.ReadLine());
 
if (num1 > num2)
 
{
    Console.WriteLine("{0} max", num1);
}
else
{ 
    Console.WriteLine("{0} max ", num2); 
}

if (num1 > num2)
 
{
    Console.WriteLine("{0} min", num2); 
}
 
else
 
{ 
    Console.WriteLine("{0} min ", num1); 
}
 
Console.ReadLine();
}
*/    

// Task4: Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих чисел.
/*
{
int num1, num2, num3;  
Console.WriteLine("Введите три числа : ");
num1 = Convert.ToInt32(Console.ReadLine()); 
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
        
Console.Write("max = ");
Console.WriteLine(max);
Console.ReadLine();
}
*/

// Task6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

/*
{

Console.Write(" Напишите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
 
 

if (number1 % 2 == 0)

 
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("не четное");
}
 Console.ReadLine();
}        
*/

// Tesk 8: Напишите программу, которая на вход принимает 
//число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.WriteLine("Напишите число ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
System.Console.Write(i + ", ");
}
*/
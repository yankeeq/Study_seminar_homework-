// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
    if (number >=100 && number <1000)
    arr[i] = rnd.Next(-9, 10);
}
return arr;
}

int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
int search = Convert.ToInt32(Console.ReadLine());

string result = "No";

for(int i=0; i<array.Length; i++){
if(array[i] == search){
result = "yes";
break;
}
}
System.Console.WriteLine(result);
// int Prompt(string ones1)
// {

// System.Console.WriteLine($"{ones1}");
// return Convert.ToInt32(Console.ReadLine());
// }
//     int number = Prompt("Введите трехзначное число");
//     if (number >=100 && number <1000)
// {
//     int ones1 = (number / 10)%10;
    
// System.Console.WriteLine($"Вторая цифра числа {number} является {ones1}");
// }
//     else
// System.Console.WriteLine("Это число не трехзначное");

// int n = Convert.ToInt32(Console.ReadLine());
// for(int i=1;i<=n;i++)
// {
// if (i % 2 == 0)
// System.Console.Write(i + ", ");
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



// Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

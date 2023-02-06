// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:1 строка\
Console.Write("Введите длину массива = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
int sum = 0;
int[] nums2 = new int[m];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        sum = sum + num[i, j];

    }
    nums2[i] = sum;
    sum = 0;

}
int max_index = 0;
int max_line = nums2[0];

for (int i = 0; i < nums2.Length; i++)
{
    if (max_line < nums2[i])
    {
        
        max_line = nums2[i];
        max_index=i;
        
    }
    
}

Console.Write($"Номер наибольшей суммы строки = {max_index+1}");

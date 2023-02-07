﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Write("Введите длину массива = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива = ");
int u = Convert.ToInt32(Console.ReadLine());
int count = 0;
int negative = 0;

int[,,] array = new int [n,m,u];


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = new Random().Next(10, 100);
            array[i,j,k] = array[i,j,k] + count;
            count +=1;
            if (array[i,j,k]>= 99)
            {
                array[i,j,k] = new Random().Next(10, 100);
                
            }
            Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
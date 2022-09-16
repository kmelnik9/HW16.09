//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

System.Console.WriteLine("Задача 47");
double[,] GetArrayDouble(int m, int n)
{
    double[,] result = new double[m,n];
    Random rand = new Random();
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            result[i,j] = Math.Round(rand.NextDouble(), 1);
        }
    }
    return result;
}

void PrintArrayDouble(double[,] arr)
{
for (int i=0; i<arr.GetLength(0); i++)
{
    for (int j = 0; j<arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

double[,] arr1 = GetArrayDouble(3, 4);
PrintArrayDouble(arr1);

System.Console.WriteLine();

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

System.Console.WriteLine("Задача 50");

int[,] GetArrayInt(int m, int n)
{
    int[,] result = new int[m,n];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(10);
        }
    }
    return result;
}

void ArraySearch (int rows, int columns, int[,] Array)
{
    if (rows>Array.GetLength(0) || columns>Array.GetLength(1))
    {
        System.Console.WriteLine("Позиции не существует");
    }
    else
    {
        System.Console.WriteLine(Array[rows-1,columns-1]);
    }
}

void PrintArrayInt(int[,] arr)
{
for (int i=0; i<arr.GetLength(0); i++)
{
    for (int j = 0; j<arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] arr2 = GetArrayInt(3, 4);
PrintArrayInt(arr2);
ArraySearch (1,1,arr2);

System.Console.WriteLine();

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


System.Console.WriteLine("Задача 52");
double[] ColumnAverage (int [,] Array)
{
    double [] result = new double[Array.GetLength(1)];
    double sum = 0;
    for (int j=0; j<Array.GetLength(1); j++)
    {
        for (int i=0; i<Array.GetLength(0); i++)
        {
            sum += Array[i,j];
        }
        result[j]=sum/(Array.GetLength(0));
        sum=0;
    }
    return result;
}

int[,] arr3 = GetArrayInt(2, 4);
PrintArrayInt(arr3);
System.Console.WriteLine($"[{string.Join(", ", ColumnAverage(arr3))}]");
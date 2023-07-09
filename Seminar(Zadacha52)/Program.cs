using System;
using static System.Console;

int InputNum(string message)
{
    Write(message);
    return Convert.ToInt32(ReadLine());
}

int[,] SetArray2DInt(int line, int column)
{
    int[,] numArr2D = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D[i, j] = new Random().Next(0, 10); 
        }
    }
    return numArr2D;
}

void PrintArray2DInt(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Write(array2D[i, j] + " ");
        }
        WriteLine();
    }
}

double[] FindAvrArr(int[,] array2D)
{
    double[] avrArr = new double[array2D.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(1); i++)
    {
        for (int j = 0; j < array2D.GetLength(0); j++)
        {
            avrArr[i] += array2D[j, i];
        }
        avrArr[i] = avrArr[i] / array2D.GetLength(0);
    }
    return avrArr;
};

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(array[i], 1);
       Write(array[i] + " ");
    }
    WriteLine();
}

int m = InputNum("Задайте кол-во строк: ");
int n = InputNum("Задайте кол-во столбцов: ");

int[,] array2D = SetArray2DInt(m, n);

WriteLine($"Ваш массив {m}x{n}:");
PrintArray2DInt(array2D);

double[] arrayAvr = FindAvrArr(array2D);

WriteLine($"Среднее арифметическое элементов столбцов:");
PrintArray(arrayAvr);
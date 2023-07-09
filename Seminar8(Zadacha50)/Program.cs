using System;
using static System.Console;
Clear();

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
            numArr2D[i, j] = new Random().Next(0, 100); 
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

int[] FindInx(int number)
{
    int[] idxArr = new int[2];
    idxArr[0] = number / 10;
    idxArr[1] = number % 10;
    return idxArr;
}

void PrintUnitArr(int[,] array2D, int[] array)
{
    if (array[0] > array2D.GetLength(0) || array[1] > array2D.GetLength(1))
    {
        WriteLine($"Такого элемента нет в массиве, строка {array[0]} столбец {array[1]}");
    }
    else
    {
        WriteLine($"Ваш элемент: {array2D[array[0] - 1, array[1] - 1]}");
    }
}

int m = InputNum("Задайте кол-во строк: ");
int n = InputNum("Задайте кол-во столбцов: ");

int[,] array = SetArray2DInt(m, n);

WriteLine($"Ваш массив {m}x{n}:");
PrintArray2DInt(array);

int num = InputNum("Введите двухзначный индекс ячейки: ");
int[] index = FindInx(num);

PrintUnitArr(array, index);
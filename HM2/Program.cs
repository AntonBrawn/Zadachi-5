//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


using System;
using static System.Console;
Clear();
{
WriteLine("Введите размера массива:");
int arrSize = Convert.ToInt32(ReadLine());
WriteLine("Введите минимальное значение массива:");
int myArrMinVal = Convert.ToInt32(ReadLine());
WriteLine("Введите максимальное значение массива:");
int myArrMaxVall = Convert.ToInt32(ReadLine());

int[] myArray = GetArray(arrSize, myArrMinVal, myArrMaxVall);
WriteLine($"[{String.Join(", ", myArray)}]");
WriteLine($"Сумма нечетных чисел: {SumElementsOnOdd(myArray)}");


int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue+1);
    }
    return result;
}

int SumElementsOnOdd(int[] arraySE)
{
    int sum = 0;
    for (int k = 1; k < arraySE.Length; k+=2)
    {
        sum += arraySE[k];
    }
    return sum;
}

}
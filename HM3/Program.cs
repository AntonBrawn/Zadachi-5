//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


using System;
using static System.Console;
Clear();
{
WriteLine("Введите размер массива:");
int arrSize = Convert.ToInt32(ReadLine());
WriteLine("Введите минимальное значение массива :");
int myArrMinVal = Convert.ToInt32(ReadLine());
WriteLine("Введите максимальное значение массива:");
int myArrMaxVall = Convert.ToInt32(ReadLine());

double[] myArray = GetArray(arrSize, myArrMinVal, myArrMaxVall);
WriteLine($"[{String.Join("; ", myArray)}]");
WriteLine($"{FindDiff(myArray).ToString("F2")}");

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] result = new double [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return result;
}

double FindDiff (double [] array)

{
    double diff =0;
    double min = 0;
    double max = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if(array[k]<min) {min = array[k];}
        if(array[k]>max) {max = array[k];}
    }
    diff = max - min;
    return diff;
}

}
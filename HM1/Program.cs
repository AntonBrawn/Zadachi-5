// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using System;
using static System.Console;
Clear();
{
WriteLine("Введите размер массива");
int arrSize = Convert.ToInt32(ReadLine());
int[] myArray = GetArray(arrSize);
WriteLine($"[{String.Join(", ", myArray)}]");
//WriteLine();
WriteLine($"Количество четных чисел в данном массиве: {evenNumbers(myArray)}");


int[] GetArray(int size)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int evenNumbers (int[] arrEven)
{
    int number =0;
    for (int k = 0; k < arrEven.Length; k++)
    {
        if(arrEven[k]%2 == 0){number++;}
    }
    return number;
}

}

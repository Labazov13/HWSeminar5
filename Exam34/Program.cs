/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] GetAndPrintArray()
{
    System.Console.Write("Введите количество элементова массива: ");
    int ArraySize = int.Parse(Console.ReadLine()!);
    int[] array = new int[ArraySize];
    for (int i = 0; i < ArraySize; i++)
    {
        array[i] = new Random().Next(100, 1000);
        System.Console.Write(" " + array[i] + " ");
    }
    return array;
}

void SearchEven(int[] array)
{   int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;   
        }
    }
    System.Console.WriteLine("Четных чисел в данном массиве: "+count);
}

int[] array = GetAndPrintArray();
System.Console.WriteLine();
SearchEven(array);

/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GetAndPrintArray()
{
    System.Console.Write("Введите количество элементова массива: ");
    int ArraySize = int.Parse(Console.ReadLine()!);
    int[] array = new int[ArraySize];
    for (int i = 0; i < ArraySize; i++)
    {
        array[i] = new Random().Next(-100, 100);
        System.Console.Write(" " + array[i] + " ");
    }
    return array;
}

void SumElementsEvenPosition(int[] array)
{
    int sumElements = 0;
    int size = array.Length;
    for (int i = 1; i < size; i++)
    {
        if (i % 2 != 0)
        {
            sumElements += array[i];
        }
    }
    System.Console.WriteLine("Сумма элементов массива, стоящих на нечетных позициях: " + sumElements);
}
int[] array = GetAndPrintArray();
SumElementsEvenPosition(array);

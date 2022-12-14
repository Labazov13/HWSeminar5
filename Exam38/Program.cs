/*Задайте массив вещественных чисел. Найдите разницу между
 максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] GetAndPrintArray()
{
    System.Console.Write("Введите количество элементова массива: ");
    int ArraySize = int.Parse(Console.ReadLine()!);
    double[] array = new double[ArraySize];
    for (int i = 0; i < ArraySize; i++)
    {
        array[i] = new Random().NextDouble() * 6;
        System.Console.Write(" " + Math.Round(array[i], 2) + " ");
    }
    return array;
}

void minMax(double[] array)
{
    double min = Math.Round(array.Min(), 2);
    double max = Math.Round(array.Max(), 2);
    Console.WriteLine("Минимальное число в массиве: " + min);
    Console.WriteLine("Максимальное число в массиве:  " + max);
    double diff = max - min;
    System.Console.WriteLine("Разница между минимальным и максимальным элементом массива: " + Math.Round(diff, 2));

}
double[] array = GetAndPrintArray();
System.Console.WriteLine();
minMax(array);

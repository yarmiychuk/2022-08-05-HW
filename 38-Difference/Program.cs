/*
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементами массива.
*/

double[] CreateRandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        array[i] = rnd.Next(min, max + 1) + rnd.NextDouble();

    return array;
}

void ShowArray(double[] array)
{
    Console.Write("Массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}

double GetDifference(double[] array)
{
    return array[GetMaxIndex(array)] - array[GetMinIndex(array)];
}

int GetMaxIndex(double[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > array[max]) max = i;

    return max;
}

int GetMinIndex(double[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < array[min]) min = i;

    return min;
}

double[] array = CreateRandomArray(new Random().Next(10, 20), 0, 99);
ShowArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {GetDifference(array)}");
/*
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
*/

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);

    return array;
}

void ShowArray(int[] array)
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

int GetSumOfOdd(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    
    return sum;
}

int[] array = CreateRandomArray(new Random().Next(10, 20), 0, 999);
ShowArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {GetSumOfOdd(array)}");
/*  Задача 36:
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0   */

Console.Clear();
Console.WriteLine("\n Задача 36");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    return array;
}

int[] array = GetArray(6, 0, 99);

int SumUpOddOnes(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
Console.Write($" -> {SumUpOddOnes(array)}");
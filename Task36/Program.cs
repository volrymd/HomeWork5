// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next (-99,100);
}

int Summa (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum +=array[i];
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine ($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Cумма элементов с нечетными индексами: {Summa(array)}");
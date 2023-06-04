// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100,1000);
}
int Search (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) count+=1;
    }
return count;
}

Console.Clear();
Console.WriteLine("Введите количество чисел в массиве: ");
int n = int.Parse (Console.ReadLine()!);
int [] array = new int [n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join (", ", array)}]");
Console.WriteLine($"Количество четных чисел: {Search(array)}");

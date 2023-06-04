// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void InputArray (double[] array)
{
    int end = 100;
    int begin = 1;
    for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
}

double Search (double[] array)
{
    double max = array[0];
    double min = array[0];
    double dif = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]> max) max = array[i];
        else if (array[i]<min) min = array[i];
    }
    dif = Math.Round(max - min, 2);
    return dif; 
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double [] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив вещественных чисел: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным числом: {Search(array)}");

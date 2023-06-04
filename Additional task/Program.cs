// Входные данные
// В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов целочисленного массива (1 ≤ N ≤ 100). 
// Вторая строка содержит N чисел, представляющих заданный массив. 
// Каждый элемент массива – натуральное число от 1 до 31. Все элементы массива разделены пробелом.

void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next (1,32);
}

string FindCount(int[] array)
{
    int count1 = 0;
    int count2 = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]%2 == 1) count1+=1;
        else count2+=1; 
    }
    if (count1 > count2) return "no";
    else return "yes";
}


void Massive (int[] array)
{
    int count1 = 0;
    int count2 = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]%2 == 1) count1+=1;
        else count2+=1; 
    }

    int [] massive2 = new int [count1];
    int index = 0;
    for (int i = 0; i < array.Length; i++) 
        {
             if (array[i] % 2 == 1)
            {
                massive2[index] = array[i];
                index++;
            }
        } 
        Console.WriteLine($"Второй массив: [{string.Join(" ", massive2)}]"); 
}                                                                                                                                                                      

Console.Clear();
Console.WriteLine("Введите количество оценок: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int [n];
InputArray(array);
Console.WriteLine ($"Исходный массив: [{string.Join(" ", array)}]");
Massive (array);
Console.WriteLine (FindCount(array));



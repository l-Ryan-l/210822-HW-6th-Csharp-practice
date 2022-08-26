/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 
*/

void NewArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        int x = Convert.ToInt32(Console.ReadLine());
        array[i] = x;
    }
}

int FindPositive (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    return count;
}

Console.Write("Укажите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine($"Количество элементов больше нуля: {FindPositive(array)}");

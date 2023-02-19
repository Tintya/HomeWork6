/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] GetMassive(string message)
{
   System.Console.Write(message);
    int elementsCount = int.Parse(Console.ReadLine());
    int[] array = new int[elementsCount];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите {i + 1}-й элемент массива:");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int CountPos(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] massiv = GetMassive("Введите количество элементов массива: ");
int count = CountPos(massiv);
System.Console.WriteLine($"Вы ввели {count} чисел > 0");
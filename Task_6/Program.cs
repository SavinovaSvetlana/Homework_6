// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3 

Console.WriteLine("Введите любое числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
PosNam(array);

void PosNam(int[] array)
{
    int positiveNam = 0;
    foreach (int el in array)
    {
        if (el > 0) positiveNam++;
    }
    Console.WriteLine($"{positiveNam} = количество введенных положительных чисел");
}
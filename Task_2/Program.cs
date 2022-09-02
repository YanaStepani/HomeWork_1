// напишите программу, которая принимает на входe 3 числа и выдает максимальное число

// получение данных от пользователя
Console.Write("Введите число 1: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int number_2 = int.Parse(Console.ReadLine());

Console.Write("Введите число 3: ");
int number_3 = int.Parse(Console.ReadLine());

// добавление переменной max
int max = number_1;

// алгоритм поиска максимального числа
if(max < number_2)
{
    max = number_2;
}
else if(max < number_3)
    {
        max = number_3;
    }

// введение ответа пользователю
Console.WriteLine($"Максимальное число = {max}");

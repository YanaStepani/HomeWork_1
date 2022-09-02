// Написать программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

// получение данных от пользователя
Console.Write("Введите число 1: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int number_2 = int.Parse(Console.ReadLine());

// присвоение переменных max и min
int max = number_1;
int min = number_2;

// поиск максимального и минимального значения
if(max < number_2)
{
    max = number_2;
    min = number_1;
}

// вывод ответа пользователю
Console.WriteLine($"Максимальное число = {max}, минимальное число = {min}.);

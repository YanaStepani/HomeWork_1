// анпишите программу, уоторая на входе принимает число и выдает, является ли число четным

// получение числа от пользователя
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// введение переменной result
string result = "четное";
// проверка условия
if(number%2 == 0)
{
    result = "четное";
}
else
{
    result = "нечетное";
}

// выведение ответа пользователю
Console.WriteLine($"Число {number} {result}");
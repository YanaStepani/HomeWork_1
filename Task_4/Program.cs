// напишите программу, которая на входе принимает число (N), а на выходе показывает все четные числа от 1 до N

// получение числа от пользвателя
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// введение переменых
int index = 0;
int result = 0;

//проверка условия (четности числа)
while(index < number)
{
    if(number%2 == 0)
    {
        result = number;
        Console.WriteLine(result);
    }
    index++; 
}

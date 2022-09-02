// напишите программу, которая на входе принимает число (N), а на выходе показывает все четные числа от 1 до N

// получение числа от пользвателя
Console.Write("Введите число: ");
int number_1 = int.Parse(Console.ReadLine());

// введение переменых
int number_2 = 1;

//проверка условия (четности числа)
while(number_2 <= number_1)
{
    if(number_2 % 2 == 0)
    {
        Console.WriteLine(number_2);
    }
 number_2++; 
}

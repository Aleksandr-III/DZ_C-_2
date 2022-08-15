// 3 Задача 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine($"{day} Выходной");
    }
    else
    {
        Console.WriteLine($"{day} Будни");
    }
}
else
{
    Console.WriteLine($"{day} Не день недели");
}
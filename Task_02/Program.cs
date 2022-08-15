// 2 Задача 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();
if (numberS.Length > 2)
{
    Console.WriteLine($"третья цифра {numberS[2]}");
}
else
{
    Console.WriteLine($"{number} третьей цифры нет");
}
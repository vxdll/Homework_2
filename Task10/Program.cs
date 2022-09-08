//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
string secondNum = Convert.ToString(number);
Console.WriteLine("Вторая цифра числа: " + secondNum[1]);

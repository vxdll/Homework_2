//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string thirdNum = Convert.ToString(number);
if(thirdNum.Length > 2)
{
    Console.WriteLine("Третья цифра числа " + thirdNum + ": " + thirdNum[2]);
}
else
{
    Console.WriteLine(thirdNum + " -> Третьей цифры нет");
}

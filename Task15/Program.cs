//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели:");
int number = Convert.ToInt32(Console.ReadLine());
if( number == 6 || number == 7)
{
    Console.WriteLine(number + " -> да это выходной день");
}
else if (number >= 1 & number < 6 )
{
    Console.WriteLine(number + " -> нет это рабочий день");
} 
else
{
    Console.WriteLine("Это не день недели");
} 


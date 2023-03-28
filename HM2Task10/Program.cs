// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Ввод числа
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()??"0");

int firstNum = (int)(num/100);          
int secondNum = (int)(num/10 - firstNum*10);                



Console.WriteLine(secondNum);

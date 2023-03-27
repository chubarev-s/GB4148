/* Задача №11
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. */

System.Random newRandom = new System.Random();

int num = newRandom.Next(100,1000);                //Последнее число не входит, поэтому 100, а не 99
Console.WriteLine(num);

//создаём 2 переменных
int firstNum = (int)(num/100);                 
//int secondNum = (int)(rndNum/10);                
int thirdNum = (int)(num%10);               

int newNum = firstNum*10+thirdNum;
Console.WriteLine(newNum);
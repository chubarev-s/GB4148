// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//   * Сделать вариант для числа длиной до 10 цифр не используя char или string


//Ввод числа
Console.Write("Введите любое число до 10 цифр: ");
long num = long.Parse(Console.ReadLine()??"0");
long i_ten = 10; 
int length_num = 1;
if(num/10000000000 == 0)
{
  while(num/i_ten != 0) 
    {
      i_ten = i_ten*10;
      length_num++;
    }
    if(length_num<3)
      Console.Write("Третьей цифры нет!");
  else
  {
    long firstNum = (long)(num/(Math.Pow(10, length_num-1))); 
    long secondNum = (long)(num/(Math.Pow(10, length_num-2)) - firstNum*10);  
    long thirdNum = (long)(num/(Math.Pow(10, length_num-3)) - secondNum*10 - firstNum*100);  
  //  Console.WriteLine(firstNum);
  //  Console.WriteLine(secondNum);
    Console.WriteLine(thirdNum);
  }
}
else
{
    Console.WriteLine("Вы ввели число 11(или более) значное число ");
}



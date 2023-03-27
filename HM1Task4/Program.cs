/*Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22        */

//Просим ввести три числа
Console.Write("Введите первое число: ");
string? inLine1 = Console.ReadLine();        //Считываем данные с консоли
Console.Write("Введите второе число: ");
string? inLine2 = Console.ReadLine();
Console.Write("Введите третье число: ");
string? inLine3 = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(inLine1!=null)
{
    int inNumber1 = int.Parse(inLine1); //преобразуем в целочисленное значение
    
    if(inLine2!=null)
    {
        int inNumber2 = int.Parse(inLine2); //преобразуем в целочисленное значение
        
         if(inLine3!=null)
         {
            int inNumber3 = int.Parse(inLine3); //преобразуем в целочисленное значение

            int max = inNumber1;
            if(max<inNumber2)
            {
                max = inNumber2;
            }
            if(max<inNumber3)
            {
                max = inNumber3;
            }
                      
            
            Console.Write("Наибольшее число: ");
            Console.WriteLine(max);
            
         }
    }


}
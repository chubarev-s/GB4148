//Выводим запрос на ввод числа
Console.WriteLine("Введите первое число: ");
//Считываем данные с консоли
string? inLine1 = Console.ReadLine(); //операционная система общается строками, поэтому int сразу не пишем

//Выводим запрос на ввод числа
Console.WriteLine("Введите второе число: ");
string? inLine2 = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(inLine1!=null)
{
    int inNumber1 = int.Parse(inLine1); //преобразуем в целочисленное значение
    
    if(inLine2!=null)
    {
        int inNumber2 = int.Parse(inLine2); //преобразуем в целочисленное значение
        int outStrtPow = (int)Math.Pow(inNumber2, 2); //возводим в квадрат через стандартные библиотеки
        if(outStrtPow==inNumber1)
        {
            Console.WriteLine("Второе число является квадратом первого");
         
        }
        else
        {
            Console.WriteLine("Второе число не является квадратом первого");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели 0, пожалуйста введите число больше 0");
    }

}
else 
{
    Console.WriteLine("Вы не ввели число");
}
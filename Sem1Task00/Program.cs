//Выводим запрос на ввод числа
Console.WriteLine("Введите число");
//Считываем данные с консоли
string? inLine = Console.ReadLine(); //операционная система общается строками, поэтому int сразу не пишем

//Проверяем, чтобы данные были не пустые
if(inLine!=null)
{
    int inNumber = int.Parse(inLine); //преобразуем в целочисленное значение
    
    int outNumber = inNumber*inNumber; //находим квадрат числа
    int outStrtPow = (int)Math.Pow(inNumber, 2); //возводим в квадрат через стандартные библиотеки

    Console.WriteLine(outNumber); //Выводим квадрат числа
    Console.WriteLine(outStrtPow); //Выводим квадрат числа из стандартных библиотек
}

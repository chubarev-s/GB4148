// Задача №18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

//Разрабатываем метод для решения задачи, который будет читать данные от пользоателя
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res; //Т.к. метод не войд, то необходимо сделать возврат в метод, это делаем ретёрном 
}

//пишем не возвращающий, пустой, метод определения четверти
void PrintAnsver(int num)
{
    if (num == 1) Console.WriteLine("x > 0, y > 0");
    if (num == 2) Console.WriteLine("x < 0, y < 0");
    if (num == 3) Console.WriteLine("x < 0, y < 0");
    if (num == 4) Console.WriteLine("x > 0, y < 0");
}

//"Кладём" из метода введённые данные в переменные координат
int numAnsver = ReadData("Введите четверть: ");
if (numAnsver > 0 && numAnsver < 5)
    PrintAnsver(numAnsver);
else
    Console.WriteLine("Данной четверти не существует!");

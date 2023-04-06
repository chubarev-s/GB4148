// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
//  в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

//Вариант 1:
//метод ввода числа
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }
// //Присваиваем переменной А введённое число
// int A = ReadData("Введите число А: ");
// //Присваиваем переменной В введённое число
// int B = ReadData("Введите число В: ");
// //Выводим А в степени В:
// Console.WriteLine("А в степене В = "+(Math.Pow(A, B)));

//Вариант 2:
//метод ввода числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Прописываем метод для расчёта
double calculator(double a, double b, char znak)
{
    double res=0;
    switch(znak)  //проверяем написанный знак
    {
        case '+':
        {
            res = a + b; 
            break;
        }
        case '*':
        {
            res = a * b; 
            break;
        }
        case '/':
        {
            res = a / b; 
            break;
        }
        case ':':
        {
            res = a / b; 
            break;
        }
        case '^':
        {
            res = Math.Pow(a,b); 
            break;
        }
    }

    return res;
}
//Присваиваем переменной А введённое число
double A = ReadData("Введите первое число: ");
//Ввод оператора
Console.Write("Введите оператор:");
char znak = Convert.ToChar(Console.ReadLine()??"0");
//Присваиваем переменной В введённое число
double B = ReadData("Введите второе число: ");
double otvet = calculator(A, B, znak);
//Выводим ответ:
Console.Write(A + " ");
Console.Write(znak + " ");
Console.Write(B);
Console.Write(" = " + otvet);


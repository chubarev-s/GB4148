// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//метод ввода координат
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res; 
}

//метод для рассчёта расстояния
double CalcLen(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
}
//заносим введённые значения в переменные
int x1 = ReadData("Введите координату Х точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int z1 = ReadData("Введите координату Z точки А: ");
int x2 = ReadData("Введите координату Х точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");
int z2 = ReadData("Введите координату Z точки B: ");

//Выводим метод:
Console.WriteLine("Расстояние между точками А и B: " + CalcLen(x1,y1,z1,x2,y2,z2));


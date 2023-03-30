// Задача №20
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

//метод ввода координат
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res; 
}

//метод для рассчёта расстояния
double CalcLen(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
}

int x1 = ReadData("Введите координату Х точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int x2 = ReadData("Введите координату Х точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");

Console.WriteLine("Расстояние между точками А и B: " + CalcLen(x1,y1,x2,y2));

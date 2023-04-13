// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых



//метод ввода коэффициентов
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод печати одномерного массива
void Print1Darray(double[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//поиск координат Х и У
double[] FindCoords(int k1, int b1, int k2, int b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] res = new double[2];
    res[0] = x;
    res[1] = y;
    return res;
}

//проверка на пересечение линий
bool LineIntersection(int k1, int b1, int k2, int b2)
{
    if(k1 == k2)
    { 
        if(b1 == b2)
        {
            Console.WriteLine("Прямые совпадают!");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны!");
            return false;
        }
    }
    return true;
}

//метод для рассчёта расстояния между двумя точками
double CalcLen(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
}

//Метод нахождения площади треугольника
void AreaOf​ATriangle(double a, double b, double c)
{
    double p = 0, s = 0;
    p = (a + b + c) / 2;
    s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    if(s!=0)
    {
        Console.WriteLine("Площадь треугольника, образованная при пересечении заданных прямых равна: " + s);
    }
    else
    {
        Console.WriteLine("Линии пересекаются в одной точке!");
    }
}

int k1 = ReadData("Введите k1: ");
int b1 = ReadData("Введите b1: ");
int k2 = ReadData("Введите k2: ");
int b2 = ReadData("Введите b2: ");
int k3 = ReadData("Введите k3: ");
int b3 = ReadData("Введите b3: ");

//Проверка на пересечение прямых 
bool Check1 = LineIntersection(k1, b1, k2, b2);
bool Check2 = LineIntersection(k3, b3, k2, b2);
bool Check3 = LineIntersection(k1, b1, k3, b3);
//Проверка на существование треугольника, каждые 2 линии должны пересекаться
if((Check1 == true)&&(Check2 == true)&&(Check3 == true))
{
    double[] arr1 = FindCoords(k1, b1, k2, b2);
    Console.Write("Точка пересечения прямых a и b: ");
    Print1Darray(arr1);
    double[] arr2 = FindCoords(k2, b2, k3, b3);
    Console.Write("Точка пересечения прямых b и c: ");
    Print1Darray(arr2);
    double[] arr3 = FindCoords(k1, b1, k3, b3);
    Console.Write("Точка пересечения прямых a и c: ");
    Print1Darray(arr3);
    //найдём сами линии:
    double a = CalcLen(arr1[0], arr1[1], arr2[0], arr2[1]);
    double b = CalcLen(arr2[0], arr2[1], arr3[0], arr3[1]);
    double c = CalcLen(arr1[0], arr1[1], arr3[0], arr3[1]);
    AreaOf​ATriangle(a, b, c);
}
















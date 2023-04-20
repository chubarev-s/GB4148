// Задача №61
// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного
// треугольника
//       1
//      1 1
//     1 2 1
//    1 3 3 1
//   1 4 6 4 1
// 1 5 10 10 5 1

//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод поиска факториала
long Factor(int n)
{
    long res = 1;
    for (int i = 1; i <= n; i++)
    {
        res *= i;
    }
    return res;
}

//метод печати треугольника
void PrintPascalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        for (int k = 0; k < nRow - i; k++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factor(i) / (Factor(j) * Factor(i - j)));
        }
        Console.WriteLine();
    }
}


int countRow = ReadData("Введите кол-во строк треугольника Паскаля: ");
PrintPascalTriangle(countRow);
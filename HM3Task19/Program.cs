// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

//Вариант 1:
// //метод ввода числа
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// //метод для получения палиндрома
// bool PalTest(int num) //выводит только "Да(True)" или "Нет(False)"
// {
//     bool res = false;
//     int d1 = num/10000;
//     int d5 = num%10;
//     int d2 = (num/1000)%10;
//     int d4 = (num/10)%10;
//     if(d1==d5&& d2==d4)
//     {
//         res=true;
//     }
//     return res;
// }
// int numN = ReadData("Введите пятизначное число: ");
// if(numN<100000)
// {
//     Console.WriteLine(PalTest(numN));
// }
// else
// Console.WriteLine("Вы ввели большое число!");
//------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------
//Вариант 2:
//Создаём словарь
Dictionary<int, string> Palindromes = new Dictionary<int, string>();
//Заполняем словарь
//Для 1
Palindromes.Add(1001, "True");
Palindromes.Add(1111, "True");
Palindromes.Add(1221, "True");
Palindromes.Add(1331, "True");
Palindromes.Add(1441, "True");
Palindromes.Add(1551, "True");
Palindromes.Add(1661, "True");
Palindromes.Add(1771, "True");
Palindromes.Add(1881, "True");
Palindromes.Add(1991, "True");
//для 2
Palindromes.Add(2002, "True");
Palindromes.Add(2112, "True");
Palindromes.Add(2222, "True");
Palindromes.Add(2332, "True");
Palindromes.Add(2442, "True");
Palindromes.Add(2552, "True");
Palindromes.Add(2662, "True");
Palindromes.Add(2772, "True");
Palindromes.Add(2882, "True");
Palindromes.Add(2992, "True");
//для 3
Palindromes.Add(3003, "True");
Palindromes.Add(3113, "True");
Palindromes.Add(3223, "True");
Palindromes.Add(3333, "True");
Palindromes.Add(3443, "True");
Palindromes.Add(3553, "True");
Palindromes.Add(3663, "True");
Palindromes.Add(3773, "True");
Palindromes.Add(3883, "True");
Palindromes.Add(3993, "True");
//для 4
Palindromes.Add(4004, "True");
Palindromes.Add(4114, "True");
Palindromes.Add(4224, "True");
Palindromes.Add(4334, "True");
Palindromes.Add(4444, "True");
Palindromes.Add(4554, "True");
Palindromes.Add(4664, "True");
Palindromes.Add(4774, "True");
Palindromes.Add(4884, "True");
Palindromes.Add(4994, "True");
//для 5
Palindromes.Add(5005, "True");
Palindromes.Add(5115, "True");
Palindromes.Add(5225, "True");
Palindromes.Add(5335, "True");
Palindromes.Add(5445, "True");
Palindromes.Add(5555, "True");
Palindromes.Add(5665, "True");
Palindromes.Add(5775, "True");
Palindromes.Add(5885, "True");
Palindromes.Add(5995, "True");
//для 6
Palindromes.Add(6006, "True");
Palindromes.Add(6116, "True");
Palindromes.Add(6226, "True");
Palindromes.Add(6336, "True");
Palindromes.Add(6446, "True");
Palindromes.Add(6556, "True");
Palindromes.Add(6666, "True");
Palindromes.Add(6776, "True");
Palindromes.Add(6886, "True");
Palindromes.Add(6996, "True");
//для 7
Palindromes.Add(7007, "True");
Palindromes.Add(7117, "True");
Palindromes.Add(7227, "True");
Palindromes.Add(7337, "True");
Palindromes.Add(7447, "True");
Palindromes.Add(7557, "True");
Palindromes.Add(7667, "True");
Palindromes.Add(7777, "True");
Palindromes.Add(7887, "True");
Palindromes.Add(7997, "True");
//для 8
Palindromes.Add(8008, "True");
Palindromes.Add(8118, "True");
Palindromes.Add(8228, "True");
Palindromes.Add(8338, "True");
Palindromes.Add(8448, "True");
Palindromes.Add(8558, "True");
Palindromes.Add(8668, "True");
Palindromes.Add(8778, "True");
Palindromes.Add(8888, "True");
Palindromes.Add(8998, "True");
//для 9
Palindromes.Add(9009, "True");
Palindromes.Add(9119, "True");
Palindromes.Add(9229, "True");
Palindromes.Add(9339, "True");
Palindromes.Add(9449, "True");
Palindromes.Add(9559, "True");
Palindromes.Add(9669, "True");
Palindromes.Add(9779, "True");
Palindromes.Add(9889, "True");
Palindromes.Add(9999, "True");

//метод для ввода числа
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Занесём введённое число в переменную
int numN = ReadData("Введите пятизначное число: ");

//проверка введённого числа
if (numN < 100000)
{
    if (numN > 9999)
    {
        //преобразуем 5 значное число в 4х значное
        int fourNum = (numN / 10000) * 1000 + ((numN / 1000) % 10) * 100 + ((numN / 10) % 10) * 10 + numN % 10;
        //Console.WriteLine(fourNum);
        //Используем ключ
        if (Palindromes.ContainsKey(fourNum))
        {
            Console.WriteLine(Palindromes[fourNum]);
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    else Console.WriteLine("Вы ввели маленькое число!");
}
else Console.WriteLine("Вы ввели большое число!");
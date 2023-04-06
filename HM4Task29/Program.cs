// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// *Дополнительно: Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора
// случайного имени метод Random.Next(1,<длина массива имен>+1).


//Вариант 1:
//Ввод числа
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Метод печати одномерного массива
// void Print1Darray(int []arr)
// {
//     Console.Write("[");
//     for(int i = 0; i<arr.Length-1; i++)
//     {
//         Console.Write(arr[i]+",");
//     }
//     Console.WriteLine(arr[arr.Length-1] + "]");
// }

// //Заполнение массива
// int[] Gen1DArray(int len)
// {
//     int[] res=new int[len];
//     for(int i=0; i<len; i++)
//     {
//         res[i]= new Random().Next(-999, 1000);
//     }
//     return res;
// }

// int lenArr = ReadData("Введите длину массива: ");
// int[] arr = Gen1DArray(lenArr);
// Print1Darray(arr);

//Вариант 2:
//Метод ввода количества участников
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Метод составления списка участников
// void Print1Darray(string []arr)
// {
//     Console.Write("Список участников: ");
//     for(int i = 0; i<arr.Length-1; i++)
//     {
//         Console.Write(arr[i]+", ");
//     }
//     Console.WriteLine(arr[arr.Length-1]);
// }

// //Метод заполнения имён участников 
// string[] Gen1DArray(int len)
// {
//     string[] res=new string[len];
//     for(int i=0; i<len; i++)
//     {
//         Console.Write("Введите имя: ");
//         string name = (string)(Console.ReadLine() ?? "0");
//         res[i] = name;
//     }
//     return res;
// }

// //Вводим кол-во участников
// int lenArr = ReadData("Введите количество участников: ");
// //Составляем список участников
// string[] arr = Gen1DArray(lenArr);
// Print1Darray(arr);
// //ищем случайный номер участника и выводим его имя, соответсвующее номеру.
// int NumName = new Random().Next(1, lenArr+1);
// Console.WriteLine("Бежит в магазин - "+arr[NumName]);

//Вариант 3(рекомендация преподавателя по поиску эл-та массива):
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора
// случайного имени метод Random.Next(1,<длина массива имен>+1).

//Вводим имена через запятую
Console.Write("Введите имена участников через запятую: ");
string name = (string)(Console.ReadLine() ?? "0");
//Разбиваем строку имён по запятой
string[] gameParticipants = name.Split(',');
//Находим случайное число массива(номер участника)
int NumName = new Random().Next(1, (gameParticipants.Length) + 1);
//Выводим имя "Счастливчика"
Console.WriteLine("Бежит в магазин - "+gameParticipants[NumName]);


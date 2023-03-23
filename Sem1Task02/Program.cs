﻿//Задача №3
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

//Выводим запрос на ввод дня недели
Console.Write("Введите день недели: ");
//Считываем данные с консоли
string? dayLine = Console.ReadLine(); //операционная система общается строками, поэтому int сразу не пишем

if(dayLine!=null)
{
    int day = int.Parse(dayLine);
    
    //заполняем массив днями недели
    string[] dayweek = new string[7];
    dayweek[0] = "понедельник";
    dayweek[1] = "вторник";
    dayweek[2] = "среда";
    dayweek[3] = "четверг";
    dayweek[4] = "пятница";
    dayweek[5] = "суббота";
    dayweek[6] = "воскресенье"; 

    //выводим день недели согласно массиву
    Console.WriteLine(dayweek[day-1]);

}


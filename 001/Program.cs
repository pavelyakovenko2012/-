﻿// Пример про Машу

// Начало
// Ввод данных
// Условие
// Вывод данных
// Конец

System.Console.Write("Введите ваше имя:");
string username = Console.ReadLine()!;
if (username.ToLower() == "маша")
{
    System.Console.WriteLine("Я так ждала тебя, Маша");
}
else
{
    System.Console.Write("Привет");
    System.Console.WriteLine(username);
}
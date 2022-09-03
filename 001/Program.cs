// Пример про Машу

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

// Описание
// 1 Начало
// 2 Просим пользователя ввести имя
// 3 Если имя в приведенном вниз регистром совпадает с "маша",
// выполняем инструкцию из блока "if".
// 4 В противном случае выполняем инструкции из блока "else"
// 5 Выводим данные
// 6 Завершение программы

// Задача
// string[] M;
// Console.WriteLine("Введите массив строк через пробел");
// string stroka = Console.ReadLine();
// M = stroka.Split(' ');
// var result = new string[M .Length];
// var realSize = 0;
// foreach (var value in M )
// {
//     if (value.Length <= 3)
//     {
//         result[realSize] = value;
//         realSize++;
//     }
// }
// Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
// Console.ReadKey(true);
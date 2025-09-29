using Tyuiu.BazilevichAV.Sprint1.Task5.V7.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #1                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert              *");
Console.WriteLine("* Задание #5                                              *");
Console.WriteLine("* Вариант #7                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, которая решает следующую задачу:    *");
Console.WriteLine("* Определить h – полное количество часов прошедших от     *");
Console.WriteLine("* начала суток до того момента (в первой половине дня),   *");
Console.WriteLine("* когда часовая стрелка повернулась на f градусов         *");
Console.WriteLine("* (0<f<360, f – вещественное число).                      *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* h = f / 30                                              *");
Console.WriteLine("***********************************************************");

double f;

Console.WriteLine("Введите значение f: ");
f = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine(" Полное количество часов прошедших от начала суток = " + ds.AngleToHoursMinutes(f));
Console.ReadLine();
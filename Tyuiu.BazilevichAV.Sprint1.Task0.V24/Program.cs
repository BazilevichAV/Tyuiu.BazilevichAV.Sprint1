using Tyuiu.BazilevichAV.Sprint1.Task0.V24.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("*********************************************************");
Console.WriteLine("* Спринт #1                                             *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                      *");
Console.WriteLine("* Задание #0                                            *");
Console.WriteLine("* Вариант #24                                            *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1  *");
Console.WriteLine("*********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                              *");
Console.WriteLine("* Написать программу, которая вычисляет выражение       *");
Console.WriteLine("* 2 * 4 / 4 / 2 + 1 и печатает результат на экране      *");
Console.WriteLine("*********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                      *");
Console.WriteLine("*********************************************************");
Console.WriteLine("* 2 * 4 / 4  2 + 1                                      *");
Console.WriteLine("*********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                            *");
Console.WriteLine("*********************************************************");

Console.WriteLine(ds.Calculate());
Console.ReadLine();
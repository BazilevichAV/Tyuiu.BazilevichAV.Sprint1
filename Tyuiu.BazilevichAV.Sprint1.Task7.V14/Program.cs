using Tyuiu.BazilevichAV.Sprint1.Task7.V14.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #1                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту *");
Console.WriteLine("* Задание #7                                              *");
Console.WriteLine("* Вариант #14                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое    *");
Console.WriteLine("* выражение по исходным значениям данных, вводимых        *");
Console.WriteLine("* пользователем.Ответ округлите до 3 знаков после запятой.*");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* z = 2^-x + 5x^2/3x^3 - cos(x)^2 + sin(2xy)              *");
Console.WriteLine("***********************************************************");

double x, y;

Console.WriteLine("Введите значение x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine(" z =  " + ds.Calculate(x, y));
Console.ReadLine();
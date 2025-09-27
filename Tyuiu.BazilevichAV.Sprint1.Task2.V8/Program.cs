using Tyuiu.BazilevichAV.Sprint1.Task2.V8.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("**********************************************************");
Console.WriteLine("* Спринт #1                                              *");
Console.WriteLine("* Тема: Арифметические операторы в С#                    *");
Console.WriteLine("* Задание #2                                             *");
Console.WriteLine("* Вариант #8                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1   *");
Console.WriteLine("**********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                               *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя *");
Console.WriteLine("* исходные данные, выполняет указанные расчёты           *");
Console.WriteLine("* и печатает его на экране.                              *");
Console.WriteLine("**********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                       *");
Console.WriteLine("**********************************************************");

int x, y;

Console.WriteLine("Введите значение X: ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y: ");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("**********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                             *");
Console.WriteLine("**********************************************************");

Console.WriteLine("Периметр прямоугольника = " + ds.CalculatePerimetr(x, y));
Console.ReadLine();
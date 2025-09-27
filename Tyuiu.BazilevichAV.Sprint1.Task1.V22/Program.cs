using Tyuiu.BazilevichAV.Sprint1.Task1.V22.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("**********************************************************");
Console.WriteLine("* Спринт #1                                              *");
Console.WriteLine("* Тема: Организация ввода,вывода в консольных приложениях*");
Console.WriteLine("* Задание #1                                             *");
Console.WriteLine("* Вариант #22                                            *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1   *");
Console.WriteLine("**********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                               *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя *");
Console.WriteLine("* исходные данные, вычисляет результат по формуле        *");
Console.WriteLine("* ( 5 + x ) / ( y * x ) и печатает его на экране.        *");
Console.WriteLine("**********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                       *");
Console.WriteLine("**********************************************************");

double x, y;

Console.WriteLine("Введите значение X: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("**********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                             *");
Console.WriteLine("**********************************************************");

Console.WriteLine(ds.Calculate(x, y));
Console.ReadLine();
using Tyuiu.BazilevichAV.Sprint1.Task3.V0.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("********************************************************?**");
Console.WriteLine("* Спринт #1                                               *");
Console.WriteLine("* Тема: Операторы составного присваивания                 *");
Console.WriteLine("* Задание #3                                              *");
Console.WriteLine("* Вариант #1                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("*******************************************************?***");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Объявите необходимые переменные и напишите программу    *");
Console.WriteLine("* вычисления объема цилиндра, предполагающий ввод исходных*");
Console.WriteLine("* данных. Ответ округлите до 3 знаков после запятой.      *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* V = Math.PI * r * 2 * h                                 *");
Console.WriteLine("***********************************************************");

double r, h;

Console.WriteLine("Введите значение r: ");
r = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение h: ");
h = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Объем цилиндра = " + Math.Round(ds.CylinderVolume(r, h), 3));
Console.ReadLine();
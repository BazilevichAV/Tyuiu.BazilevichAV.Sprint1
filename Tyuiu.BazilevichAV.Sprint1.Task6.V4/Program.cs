using Tyuiu.BazilevichAV.Sprint1.Task6.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #1                                               *");
Console.WriteLine("* Тема: Работа со строками класс String                   *");
Console.WriteLine("* Задание #6                                              *");
Console.WriteLine("* Вариант #4                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст.          *");
Console.WriteLine("* Напечатать все слова, содержащие удвоенное н или нн.    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Введите строку: ");
string value = Console.ReadLine();

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine(" Cлова, содержащие удвоенное н (нн) = " + ds.CheckDoubleN(value));
Console.ReadLine();
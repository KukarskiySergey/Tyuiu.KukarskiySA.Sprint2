using Tyuiu.KukarskiySA.Sprint2.Task3.V10.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #2 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #3                                                           *");
Console.WriteLine("* Вариант #10                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая вычисляет значение функции Y             *");
Console.WriteLine("* с использованием вложенных операторов if-else,                       *");
Console.WriteLine("* округлить значение до трех знаков после запятой                      *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");

Console.WriteLine("Введите значение X:");
if (double.TryParse(Console.ReadLine(), out double x))
{
    double result = dataService.Calculate(x);
    Console.WriteLine($"Результат вычисления функции для X = {x}: Y = {result}");
}
else
{
    Console.WriteLine("Ошибка ввода. Введите корректное числовое значение.");
}

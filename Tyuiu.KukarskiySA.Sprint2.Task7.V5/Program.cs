using Tyuiu.KukarskiySA.Sprint2.Task7.V5.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #2 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #5                                                           *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные        *");
Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка              *");
Console.WriteLine("* с координатами X,Y в заштрихованной области.                         *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* График                                                               *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");

Console.WriteLine("Введите координату X:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
// Проверка, находится ли точка в заштрихованной области
bool isInShadedArea = dataService.CheckDotInShadedArea(x, y);
if (isInShadedArea)
{
    Console.WriteLine($"Точка с координатами ({x}, {y}) находится в заштрихованной области.");
}
else
{
    Console.WriteLine($"Точка с координатами ({x}, {y}) НЕ находится в заштрихованной области.");
}
Console.WriteLine("************************************************************************");

using Tyuiu.KukarskiySA.Sprint2.Task2.V10.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #2 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #2                                                           *");
Console.WriteLine("* Вариант #10                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры  *");
Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной  *");
Console.WriteLine("* области.                                                             *");
Console.WriteLine("************************************************************************");

// Ввод координат
Console.WriteLine("Введите координаты X (от 1 до 15): ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y (от 1 до 15): ");
int y = int.Parse(Console.ReadLine());

// Проверка нахождения точки в заштрихованной области
bool isInShadedArea = dataService.CheckDotInShadedArea(x, y);

// Вывод результата
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
if (isInShadedArea)
{
    Console.WriteLine($"Точка с координатами ({x}, {y}) находится в заштрихованной области.");
}
else
{
    Console.WriteLine($"Точка с координатами ({x}, {y}) НЕ находится в заштрихованной области.");
}
Console.WriteLine("************************************************************************");

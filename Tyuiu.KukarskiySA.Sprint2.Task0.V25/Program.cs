using Tyuiu.KukarskiySA.Sprint2.Task0.V25.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #2 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #25                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,      *");
Console.WriteLine("* последовательность операций не должна нарушаться)                    *");
Console.WriteLine("* и арифметических выражений, которая вернет логическую                *");
Console.WriteLine("* последовательность(массив): (True, True, True, False, False, False)  *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* x = 205, y = 159 *");

int x = 205;
int y = 159;

bool[] results = dataService.GetCompareOperations(x, y);

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(string.Join(", ", results));
using Tyuiu.KukarskiySA.Sprint2.Task1.V16.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #2 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #1                                                           *");
Console.WriteLine("* Вариант #16                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,      *");
Console.WriteLine("* последовательность можно чередовать, но использовать один раз        *");
Console.WriteLine("* в выражении) и логических операций (|, &, ||, &&, !, ^,              *");
Console.WriteLine("* последовательность операций не должна нарушаться), а также           *");
Console.WriteLine("* арифметических выражений, которая вернет логическую                  *");
Console.WriteLine("* последовательность(массив): (True, True, True, False, True, False)   *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* a = 145, b = 716, c = 144, d = 137 *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");
bool[] results = dataService.GetLogicOperations(145, 716, 144, 137);
Console.WriteLine($"Результаты: {string.Join(", ", results)}");
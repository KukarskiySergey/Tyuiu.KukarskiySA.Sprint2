using Tyuiu.KukarskiySA.Sprint2.Task4.V6.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #2 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #6                                                           *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с           *");
Console.WriteLine("* использованием тернарного оператора, где пользователь вводит         *");
Console.WriteLine("* значение переменных x,y с клавиатуры.                                *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* если x+20>y*2, то z=x((y+1)/(x+2))в степени x иначе (y*y)+2x+(6/x)   *");
Console.WriteLine("*                                                                      *");

Console.Write("Введите значение x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y: ");
double y = Convert.ToDouble(Console.ReadLine());

double z = dataService.Calculate(x, y);

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine($"Результат z: {z}");
Console.WriteLine("************************************************************************");


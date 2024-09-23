using Tyuiu.KukarskiySA.Sprint2.Task6.V14.Lib;


DataService dataService = new DataService();

Console.Title = "Спринт #2 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #6                                                           *");
Console.WriteLine("* Вариант #14                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая использует оператор switch               *");
Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                 *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели    *");
Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем)             *");
Console.WriteLine("* является k-й день не високосного года, в котором                     *");
Console.WriteLine("* 1 января d-й день недели (если 1 января — понедельник,               *");
Console.WriteLine("* то d = 1 , если вторник — d = 2 , …, если воскресенье — d = 7).      *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");

Console.Write("Введите номер дня в году (1 <= k <= 365): ");
int k = int.Parse(Console.ReadLine());

Console.Write("Введите номер дня недели, с которого начинается год (1 = понедельник, ..., 7 = воскресенье): ");
int d = int.Parse(Console.ReadLine());

string dayOfWeek = dataService.FindDayName(k, d);

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine($"День недели для {k}-го дня: {dayOfWeek}");
Console.WriteLine("************************************************************************");

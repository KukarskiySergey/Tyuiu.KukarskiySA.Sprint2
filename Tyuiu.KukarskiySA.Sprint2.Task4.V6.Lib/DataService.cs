using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KukarskiySA.Sprint2.Task4.V6.Lib
{
    public class DataService : ISprint2Task4V6
    {
        public double Calculate(double x, double y)
        {
            // Вычисление z с использованием тернарного оператора
            double result = (x + 20 > y * 2)
                ? Math.Pow(x * ((y + 1) / (x + 2)), x)
                : Math.Pow(y, 2) + 2 * x + (6 / x);

            return Math.Round(result, 3); // Округление до 3 знаков после запятой
        }
    }
}
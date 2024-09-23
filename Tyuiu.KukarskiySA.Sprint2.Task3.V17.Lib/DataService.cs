using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KukarskiySA.Sprint2.Task3.V10.Lib
{
    public class DataService : ISprint2Task3V17
    {
        public double Calculate(double x)
        {
            double y;
            if (x > 1)
            {
                // x^2 + ((x + 1) / (x - 1))^8
                y = Math.Pow(x, 2) + Math.Pow((x + 1) / (x - 1), 8);
            }
            else if (x == 0)
            {
                // (x - 7) / (2 + x^3 - 3x)
                y = (x - 7) / (2 + Math.Pow(x, 3) - 3 * x);
            }
            else if (x > -21 && x < 2)
            {
                // (1 + 1 / x^2)^4
                y = Math.Pow(1 + (1 / Math.Pow(x, 2)), 4);
            }
            else if (x <= -21)
            {
                // x + 10 * x - (1 / x)
                y = x + 10 * x - (1 / x);
            }
            else
            {
                y = 0; // На случай, если x не попадает в указанные диапазоны
            }

            return Math.Round(y, 3); // Округляем результат до трех знаков после запятой
        }
    }
}

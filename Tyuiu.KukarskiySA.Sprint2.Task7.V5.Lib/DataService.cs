using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KukarskiySA.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверяем, находится ли x в пределах области от -1 до 1
            if (x < -1 || x > 1)
            {
                return false;
            }

            // Вычисляем значения функций для данной точки x
            double upperBound = Math.Exp(-Math.Abs(x)); // Верхняя граница: y = e^(-|x|)
            double lowerBound = x * x; // Нижняя граница: y = x^2

            // Проверяем, находится ли y между нижней и верхней границами
            if (y >= lowerBound && y <= upperBound)
            {
                return true;
            }

            return false;
        }

    }
}

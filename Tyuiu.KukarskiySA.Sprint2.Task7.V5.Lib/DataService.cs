using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KukarskiySA.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        /// <summary>
        /// Метод проверяет, находится ли точка с координатами (x, y) в заштрихованной области.
        /// </summary>
        /// <param name="x">Координата X точки</param>
        /// <param name="y">Координата Y точки</param>
        /// <returns>Возвращает true, если точка находится в заштрихованной области, иначе false</returns>
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Верхняя граница заштрихованной области: y = e^(-|x|)
            double upperBound = Math.Exp(-Math.Abs(x));

            // Определяем нижнюю границу в зависимости от значения x
            double lowerBound;
            if (x >= -1 && x <= 0)
            {
                lowerBound = Math.Exp(x); // y = e^x
            }
            else if (x > 0 && x <= 1)
            {
                lowerBound = x * x; // y = x^2
            }
            else
            {
                // Если x вне диапазона [-1, 1], точка не может быть в заштрихованной области
                return false;
            }

            // Проверяем, попадает ли y в диапазон между нижней и верхней границами
            return y >= lowerBound && y <= upperBound;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KukarskiySA.Sprint2.Task0.V25.Lib
{
    public class DataService : ISprint2Task0V25
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

            results[0] = (x == 205);
            results[1] = (y != x);
            results[2] = (y < x);
            results[3] = (y > x);
            results[4] = (x <= y);
            results[5] = (y >= x);

            return results;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KukarskiySA.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            

            bool[] results = new bool[6];

            results[0] = (a == 145);
            results[1] = b != 144;
            results[2] = (a > c);
            results[3] = (b <= 145);
            results[4] = (c >= 144);
            results[5] = (a < d);

            return results;
        }
    }
}

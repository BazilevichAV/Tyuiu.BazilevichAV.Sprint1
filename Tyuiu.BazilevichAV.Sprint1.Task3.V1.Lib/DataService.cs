using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BazilevichAV.Sprint1.Task3.V0.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            return Math.Round(Math.PI * r * r * h, 3);
        }
    }
}

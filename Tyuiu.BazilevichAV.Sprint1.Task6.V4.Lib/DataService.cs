using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.BazilevichAV.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            return string.Join(" ",
                    value.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Where(w => w.IndexOf("нн", StringComparison.OrdinalIgnoreCase) >= 0));
        }
    }
}
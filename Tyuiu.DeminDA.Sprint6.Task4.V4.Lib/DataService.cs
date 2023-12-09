using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DeminDA.Sprint6.Task4.V4.Lib
{
    public class DataService : ISprint6Task4V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; //обЪявляем пустой массив
            int len = (stopValue - startValue) + 1; // вычисляем длину массива
            valueArray = new double[len]; //создаём массив с указанной длиной
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;
                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((2*x + 6) / (Math.Cos(x) + x)-3, 2);
                }
                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}

using System;

namespace Bibliotekaa
{
    public class Class1
    {
        public static double Summ()
        {
            //Размерность массива n x m = 6*6
            int n = 6;
            int m = 6;

            //Объявление двумерного массива
            double[,] arr = new double[n, m];

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(i + j == n - 1) //Условие побочной диагонали матрицы
                    {
                        arr[i, j] = Math.Pow((Math.Log(i)* Math.Log(i)) / (3.5 - 0.5*j), 2) + (-Math.Exp(i+j));
                    }
                }
            }

            //Вычисление максимального и минимального элемента побочной диагонали
            double min = double.MaxValue;
            double max = double.MinValue;

            for (int d = 0; d < n; d++)
            {
                for (int s = 0; s < m; s++)
                {
                    if (arr[d, s] > max) max = arr[d, s];
                    if (arr[d, s] < min) min = arr[d, s];
                }
            }
            
            //Вычисление суммы максимального и минимального элемента
            double sum = max + min;

            return sum;
        }
    }
}

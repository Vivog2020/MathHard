using System;
using System.Collections.Generic;

namespace MathHard
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Для x в промежутке [-2; 2] с шагом 0,1 вычислить значение y по формуле
            /// значения в столбик с разделителем-табуляцией (\t):
            /// x - 5 знакомест, 1 знак после запятой
            /// табуляция \t
            /// y - 9 знакомест, 5 знаков после запятой.
            List<double> x = new List<double>();
            for (double i = -2.0; i <= 2.1; i += 0.1)
            {
                x.Add(i);

            }
            List<double> y = new List<double>();
            for (int i = 0; i < x.Count; i++)
            {
                double xy = ((Math.Pow(x[i], 2) * Math.Sin(x[i])) / Math.Sqrt((Math.Abs(Math.Cos(x[i])))));
                y.Add(xy);
            }
            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine(string.Format("{0,5:f1}\t{1,9:f5}", x[i], y[i]));
                /// 5:f1, где 5 это значит 5 знакомест до запятой
                ///           f1 это значит 1 знакомест после запятой
                /// т.е. если у нас число 123456.123456
                /// то на консоль будет выведено 123456.1
                /// т.е. округлиться только дробная часть
                /// если же число 123,123
                /// то выведено будет только 123.1, но перед 123 будет 2 пробела
            }

            /// Тоже самое решение только с помощью обычного цикла
            for (double x1 = -2.0; x1 <= 2.1; x1 += 0.1)
            {
                double y1 = ((Math.Pow(x1, 2) * Math.Sin(x1)) / Math.Sqrt((Math.Abs(Math.Cos(x1)))));
                Console.WriteLine(string.Format("{0,5:f1}\t{1,9:f5}", x1, y1));
            }         

        }
    }
}

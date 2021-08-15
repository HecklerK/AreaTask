using System;

namespace AreaTask
{
    public class Area
    {
        /// <summary>
        /// Метод для вычесления площади круга по радиусу.
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <returns></returns>
        public static double AreaCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2.0);
        }

        /// <summary>
        /// Метод для вычесления площади круга по радиусу.
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <returns></returns>
        public static double AreaCircle(int radius)
        {
            return Math.PI * Math.Pow(radius, 2.0);
        }

        /// <summary>
        /// Метод для вычесления площади круга по радиусу.
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <returns></returns>
        public static double AreaCircle(float radius)
        {
            return Math.PI * Math.Pow(radius, 2.0);
        }

        /// <summary>
        /// Метод для вычесления площади треугольника по трём сторонам.
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <returns></returns>
        public static double AreaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Метод для вычесления площади треугольника по трём сторонам.
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <returns></returns>
        public static double AreaTriangle(float a, float b, float c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}

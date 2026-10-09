using System;

namespace WebApp
{
    /// <summary>
    /// Трикутник, заданий довжинами трьох сторін.
    /// </summary>
    public class Triangle
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c)
        {
            if (!CanExist(a, b, c))
                throw new ArgumentException("Трикутник з такими сторонами не існує.");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Перевірка нерівності трикутника: кожна сторона менша за суму двох інших.
        /// </summary>
        public static bool CanExist(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0
                && a + b > c
                && a + c > b
                && b + c > a;
        }

        public double Perimeter
        {
            get { return a + b + c; }
        }

        /// <summary>
        /// Площа за формулою Герона: S = sqrt(p(p - a)(p - b)(p - c)),
        /// де p = (a + b + c) / 2 — півпериметр.
        /// </summary>
        public double Area()
        {
            double p = Perimeter / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}

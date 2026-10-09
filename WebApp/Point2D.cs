using System;

namespace WebApp
{
    /// <summary>
    /// Точка на координатній площині XOY.
    /// </summary>
    public class Point2D
    {
        private readonly double x;
        private readonly double y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        /// <summary>
        /// true, якщо точка лежить на осі OX (y = 0) або на осі OY (x = 0).
        /// </summary>
        public bool IsOnAxis
        {
            get { return x == 0 || y == 0; }
        }

        /// <summary>
        /// Повертає номер координатної чверті (1, 2, 3 або 4).
        /// </summary>
        public int GetQuadrant()
        {
            if (IsOnAxis)
                throw new InvalidOperationException(
                    "Точка лежить на координатній осі і не належить жодній чверті.");

            if (x > 0)
                return y > 0 ? 1 : 4;
            else
                return y > 0 ? 2 : 3;
        }

        /// <summary>
        /// Римський номер чверті: I, II, III, IV.
        /// </summary>
        public static string ToRoman(int quadrant)
        {
            switch (quadrant)
            {
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                case 4: return "IV";
                default: throw new ArgumentOutOfRangeException("quadrant");
            }
        }
    }
}

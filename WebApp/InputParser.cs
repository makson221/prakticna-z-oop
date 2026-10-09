using System.Globalization;

namespace WebApp
{
    /// <summary>
    /// Розбір чисел, введених користувачем у текстові поля.
    /// Приймає як кому, так і крапку як десятковий роздільник ("2,5" і "2.5").
    /// </summary>
    public static class InputParser
    {
        public static bool TryParseNumber(string text, out double value)
        {
            value = 0;
            if (string.IsNullOrWhiteSpace(text))
                return false;

            string normalized = text.Trim().Replace(',', '.');
            return double.TryParse(normalized, NumberStyles.Float,
                       CultureInfo.InvariantCulture, out value)
                && !double.IsInfinity(value);
        }
    }
}

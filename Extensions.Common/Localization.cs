using System;
using System.Globalization;
using System.Threading;

namespace Ichosoft.Extensions.Common
{
    public static class Localization
    {
        #region Nullable ToString extension methods
        private static readonly string defafultString = null;

        public static string ToString(this DateTime? @dateTime, IFormatProvider provider)
        {
            return dateTime?.ToString(provider) ?? defafultString;
        }

        public static string ToString(this DateTime? @dateTime, string format)
        {
            return @dateTime?.ToString(format) ?? defafultString;
        }

        public static string ToString(this decimal? @decimal, IFormatProvider provider)
        {
            return @decimal?.ToString(provider) ?? defafultString;
        }

        public static string ToString(this decimal? @decimal, string format)
        {
            return @decimal?.ToString(format) ?? defafultString;
        }

        public static string ToString(this int? @int, IFormatProvider provider)
        {
            return @int?.ToString(provider) ?? defafultString;
        }

        public static string ToString(this int? @int, string format)
        {
            return @int?.ToString(format) ?? defafultString;
        }

        public static string ToString(this double? @double, IFormatProvider provider)
        {
            return @double?.ToString(provider) ?? defafultString;
        }

        public static string ToString(this double? @double, string format)
        {
            return @double?.ToString(format) ?? defafultString;
        }

        public static string ToString(this float? @float, IFormatProvider provider)
        {
            return @float?.ToString(provider) ?? defafultString;
        }

        public static string ToString(this float? @float, string format)
        {
            return @float?.ToString(format) ?? defafultString;
        }

        #endregion

        #region String converter extension methods
        public static string[] CustomShortDatePatterns { get; set; }

        /// <summary>
        /// Parses the given string into a <see cref="DateTime?"/> value, using culture-specific
        /// date formats./>.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>A <see cref="DateTime"/> if converted successfully, else null.</returns>
        public static DateTime? ConvertToDateTime(this string s)
        {
            try
            {
                // Try to convert using CultureInfo
                return Convert.ToDateTime(s);
            }
            catch (FormatException)
            {
            }
            try
            {
                // Check each format and break the loop when the first result is found.
                foreach (var pattern in CustomShortDatePatterns)
                {
                    if (DateTime.TryParseExact(
                        s: s,
                        format: pattern,
                        provider: CultureInfo.InvariantCulture,
                        style: DateTimeStyles.None,
                        out DateTime result))

                        return result;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Text formatter extension methods
        /// <summary>
        /// Converts this string to title case using the provider <see cref="CultureInfo.CurrentUICulture"/>.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>The <see cref="string"/>, converted to title case.</returns>
        public static string ToTitleCase(this string str)
        {
            return str?.ToTitleCase(Thread.CurrentThread.CurrentUICulture);
        }

        /// <summary>
        /// Converts this string to title case using the provider <see cref="CultureInfo.CurrentUICulture"/>.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to use as a formatting provider.</param>
        /// <returns>The <see cref="string"/>, converted to title case.</returns>
        private static string ToTitleCase(this string str, CultureInfo cultureInfo)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            else
            {
                return cultureInfo.TextInfo.ToTitleCase(str);
            }
        }

        #endregion
    }
}

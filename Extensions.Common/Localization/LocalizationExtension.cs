using System;
using System.Globalization;

namespace Ichosys.Extensions.Common.Localization
{
    /// <summary>
    /// Extensions methods for supporting localization.
    /// </summary>
    public static class LocalizationExtension
    {

#nullable enable

        /// <summary>
        /// Converts this string into a <see cref="DateTime"/> value, using culture-specific
        /// date formats.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>A <see cref="DateTime"/> if converted successfully, else null.</returns>
        public static DateTime? ConvertToDateTime(this string s)
        {
            return s.ConvertToDateTime(Array.Empty<string>());
        }

        /// <summary>
        /// Converts this string into a date-time value, using a matching 
        /// culture date time format, or a matching custom pattern.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="customPatterns">An array of additional allowed patterns.</param>
        /// <returns>A <see cref="DateTime"/> if converted successfully, else null.</returns>
        public static DateTime? ConvertToDateTime(this string s, params string[] customPatterns)
        {
            if (string.IsNullOrEmpty(s))
                return null;
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
                if (customPatterns is null || customPatterns.Length == 0)
                    return null;

                // Check each format and break the loop when the first result is found.
                foreach (var pattern in customPatterns)
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
        
        /// <summary>
        /// Converts this string to title case using the current culture.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>The <see cref="string"/>, converted to title case.</returns>
        public static string? ToTitleCase(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;
            else
                return CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(s);
        }

#nullable disable

    }
}

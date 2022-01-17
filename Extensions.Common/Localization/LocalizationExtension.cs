using System;
using System.Globalization;
using System.Threading;

namespace Ichosoft.Extensions.Common.Localization
{
    public static class LocalizationExtension
    {
#nullable enable
        #region Nullable ToString extension methods
        public static string? DefaultString { get; } = null;

        /// <summary>
        /// Converts the <see cref="DateTime"/> to a localized string representation.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>
        /// A string representation of value of the current <see cref="DateTime"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this DateTime? dateTime)
        {
            if (dateTime is null)
                return DefaultString;
            DateTime value = dateTime ?? default;

            return value.ToString();
        }

        /// <summary>
        /// Converts the <see cref="DateTime"/> to a localized string representation.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="DateTime"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this DateTime? @dateTime, IFormatProvider provider)
        {
            if (@dateTime is null)
                return DefaultString;
            DateTime value = @dateTime ?? default;

            return value.ToString(provider);
        }

        /// <summary>
        /// Converts the <see cref="DateTime"/> to a localized string representation.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format">A standard or custom date and time format string.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="DateTime"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this DateTime? @dateTime, string format)
        {
            if (@dateTime is null)
                return DefaultString;
            DateTime value = @dateTime ?? default;

            return value.ToString(format);
        }

        /// <summary>
        /// Converts the <see cref="decimal"/> to a localized string representation.
        /// </summary>
        /// <param name="decimal"></param>
        /// <returns>
        /// A string representation of value of the current <see cref="decimal"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this decimal? @decimal)
        {
            if (@decimal is null)
                return DefaultString;
            decimal value = @decimal ?? default;

            return value.ToString();
        }

        /// <summary>
        /// Converts the <see cref="decimal"/> to a localized string representation.
        /// </summary>
        /// <param name="decimal"></param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="decimal"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this decimal? @decimal, IFormatProvider provider)
        {
            if (@decimal is null)
                return DefaultString;
            decimal value = @decimal ?? default;

            return value.ToString(provider);
        }

        /// <summary>
        /// Converts the <see cref="decimal"/> to a localized string representation.
        /// </summary>
        /// <param name="decimal"></param>
        /// <param name="format">A standard or custom numeric format string.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="decimal"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this decimal? @decimal, string format)
        {
            if (@decimal is null)
                return DefaultString;
            decimal value = @decimal ?? default;

            return value.ToString(format);
        }

        /// <summary>
        /// Converts the <see cref="short"/> to a localized string representation.
        /// </summary>
        /// <param name="short"></param>
        /// <returns>
        /// A string representation of value of the current <see cref="short"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this short? @short)
        {
            if (@short is null)
                return DefaultString;
            short value = @short ?? default;

            return value.ToString();
        }

        /// <summary>
        /// Converts the <see cref="short"/> to a localized string representation.
        /// </summary>
        /// <param name="short"></param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="short"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this short? @short, IFormatProvider provider)
        {
            if (@short is null)
                return DefaultString;
            int value = @short ?? default;

            return value.ToString(provider);
        }

        /// <summary>
        /// Converts the <see cref="short"/> to a localized string representation.
        /// </summary>
        /// <param name="short"></param>
        /// <param name="format">A standard or custom numeric format string.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="short"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this short? @short, string format)
        {
            if (@short is null)
                return DefaultString;
            short value = @short ?? default;

            return value.ToString(format);
        }

        /// <summary>
        /// Converts the <see cref="int"/> to a localized string representation.
        /// </summary>
        /// <param name="int"></param>
        /// <returns>
        /// A string representation of value of the current <see cref="int"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this int? @int)
        {
            if (@int is null)
                return DefaultString;
            int value = @int ?? default;

            return value.ToString();
        }

        /// <summary>
        /// Converts the <see cref="int"/> to a localized string representation.
        /// </summary>
        /// <param name="int"></param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="int"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this int? @int, IFormatProvider provider)
        {
            if (@int is null)
                return DefaultString;
            int value = @int ?? default;

            return value.ToString(provider);
        }

        /// <summary>
        /// Converts the <see cref="int"/> to a localized string representation.
        /// </summary>
        /// <param name="int"></param>
        /// <param name="format">A standard or custom numeric format string.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="int"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this int? @int, string format)
        {
            if (@int is null)
                return DefaultString;
            int value = @int ?? default;

            return value.ToString(format);
        }

        /// <summary>
        /// Converts the <see cref="long"/> to a localized string representation.
        /// </summary>
        /// <param name="long"></param>
        /// <returns>
        /// A string representation of value of the current <see cref="long"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this long? @long)
        {
            if (@long is null)
                return DefaultString;
            long value = @long ?? default;

            return value.ToString();
        }

        /// <summary>
        /// Converts the <see cref="long"/> to a localized string representation.
        /// </summary>
        /// <param name="long"></param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="long"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this long? @long, IFormatProvider provider)
        {
            if (@long is null)
                return DefaultString;
            long value = @long ?? default;

            return value.ToString(provider);
        }

        /// <summary>
        /// Converts the <see cref="long"/> to a localized string representation.
        /// </summary>
        /// <param name="long"></param>
        /// <param name="format">A standard or custom numeric format string.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="long"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this long? @long, string format)
        {
            if (@long is null)
                return DefaultString;
            long value = @long ?? default;

            return value.ToString(format);
        }

        /// <summary>
        /// Converts the <see cref="double"/> to a localized string representation.
        /// </summary>
        /// <param name="double"></param>
        /// <returns>
        /// A string representation of value of the current <see cref="double"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this double? @double)
        {
            if (@double is null)
                return DefaultString;
            double value = @double ?? default;

            return value.ToString();
        }

        /// <summary>
        /// Converts the <see cref="double"/> to a localized string representation.
        /// </summary>
        /// <param name="double"></param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="double"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this double? @double, IFormatProvider provider)
        {
            if (@double is null)
                return DefaultString;
            double value = @double ?? default;

            return value.ToString(provider);
        }

        /// <summary>
        /// Converts the <see cref="double"/> to a localized string representation.
        /// </summary>
        /// <param name="double"></param>
        /// <param name="format">A standard or custom numeric format string.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="double"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this double? @double, string format)
        {
            if (@double is null)
                return DefaultString;
            double value = @double ?? default;

            return value.ToString(format);
        }

        /// <summary>
        /// Converts the <see cref="float"/> to a localized string representation.
        /// </summary>
        /// <param name="float"></param>
        /// <returns>
        /// A string representation of value of the current <see cref="float"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this float? @float)
        {
            if (@float is null)
                return DefaultString;
            float value = @float ?? default;

            return value.ToString();
        }

        /// <summary>
        /// Converts the <see cref="float"/> to a localized string representation.
        /// </summary>
        /// <param name="float"></param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="float"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this float? @float, IFormatProvider provider)
        {
            if (@float is null)
                return DefaultString;
            float value = @float ?? default;

            return value.ToString(provider);
        }

        /// <summary>
        /// Converts the <see cref="float"/> to a localized string representation.
        /// </summary>
        /// <param name="float"></param>
        /// <param name="format">A standard or custom numeric format string.</param>
        /// <returns>
        /// A string representation of value of the current <see cref="float"/> object as specified 
        /// by format.
        /// </returns>
        public static string? ToLocalizedString(this float? @float, string format)
        {
            if (@float is null) 
                return DefaultString;
            float value = @float ?? default;

            return value.ToString(format);
        }
        
        #endregion

        #region String converter extension methods
        public static string[] CustomShortDatePatterns { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Converts this string into a <see cref="DateTime"/> value, using culture-specific
        /// date formats.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>A <see cref="DateTime"/> if converted successfully, else null.</returns>
        public static DateTime? ConvertToDateTime(this string s)
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
        /// Converts this string to title case using the current culture.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>The <see cref="string"/>, converted to title case.</returns>
        
        public static string? ToTitleCase(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;

            return s?.ToTitleCase(CultureInfo.CurrentUICulture);
        }

        /// <summary>
        /// Converts this string to title case using the given culture.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to use as a formatting provider.</param>
        /// <returns>The <see cref="string"/>, converted to title case.</returns>
        public static string? ToTitleCase(this string s, CultureInfo cultureInfo)
        {
            if (string.IsNullOrEmpty(s))
            {
                return null;
            }
            else
            {
                return cultureInfo.TextInfo.ToTitleCase(s);
            }
        }

        #endregion

        #nullable disable
    }
}

using Ichosoft.Extensions.Common.Localization;
using Ichosoft.Extensions.Common;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Globalization;

namespace Ichosoft.Extensions.Common.UnitTest
{
    [TestClass]
    public class LocalizationTests
    {
        [TestMethod]
        public void ToLocalizedString_DateTime_NoInput_YieldsMatchingString()
        {
            DateTime? nullValue = null;
            DateTime? value = new(2021, 1, 1);
            DateTime nonNullvalue = value ?? default;

            Debug.WriteLine($"Observed< {value.ToLocalizedString()} >");
            Debug.WriteLine($"Expected< {nonNullvalue} >");

            Assert.IsNull(nullValue.ToLocalizedString());
            Assert.AreEqual(nonNullvalue.ToString(), value.ToLocalizedString());
        }

        [TestMethod]
        public void ToLocalizedString_DateTime_CultureInput_YieldsExpectedString()
        {
            DateTime? nullValue = null;
            DateTime? value = new(2021, 1, 1);
            DateTime nonNullvalue = value ?? default;

            var ctrlCulture = new CultureInfo("en-US");
            var expCulture = new CultureInfo("de-DE");

            SetCulture(expCulture);
            
            Debug.WriteLine($"Observed< {value.ToLocalizedString()} >");
            Debug.WriteLine($"Expected<! {nonNullvalue.ToString(ctrlCulture)} >");

            Assert.IsNull(nullValue.ToLocalizedString());
            Assert.AreNotEqual(nonNullvalue.ToString(ctrlCulture), value.ToLocalizedString());
            Assert.AreEqual(nonNullvalue.ToString(expCulture), value.ToLocalizedString());

            SetCulture(new("en-US"));
        }

        [TestMethod]
        public void ToLocalizedString_DateTime_FormatInput_YieldsExpectedString()
        {
            DateTime? nullValue = null;
            DateTime? value = new(2021, 1, 1);
            DateTime nonNullvalue = value ?? default;

            var ctrlCulture = new CultureInfo("en-US");
            var expCulture = new CultureInfo("de-DE");

            SetCulture(expCulture);

            Debug.WriteLine($"Observed< {value.ToLocalizedString()} >");
            Debug.WriteLine($"Expected<! {nonNullvalue.ToString(ctrlCulture)} >");

            Assert.IsNull(nullValue.ToLocalizedString());
            Assert.AreNotEqual(nonNullvalue.ToString(ctrlCulture), value.ToLocalizedString());
            Assert.AreEqual(nonNullvalue.ToString(expCulture), value.ToLocalizedString());

            SetCulture(new("en-US"));
        }

        [TestMethod]
        public void ToLocalizedString_Decimal_NoInput_YieldsMatchingString()
        {
            decimal? nullValue = null;
            decimal? value = new decimal(1.25);
            decimal nonNullvalue = value ?? default;

            Debug.WriteLine($"Observed< {value.ToLocalizedString()} >");
            Debug.WriteLine($"Expected< {nonNullvalue} >");

            Assert.IsNull(nullValue.ToLocalizedString());
            Assert.AreEqual(nonNullvalue.ToString(), value.ToLocalizedString());
        }

        [TestMethod]
        public void ToLocalizedString_Decimal_CultureInput_YieldsNonMatchingString()
        {
            decimal? nullValue = null;
            decimal? value = new decimal(1.25);
            decimal nonNullvalue = value ?? default;

            var ctrlCulture = new CultureInfo("en-US");
            var expCulture = new CultureInfo("de-DE");

            SetCulture(expCulture);

            Debug.WriteLine($"Observed< {value.ToLocalizedString()} >");
            Debug.WriteLine($"Expected<! {nonNullvalue.ToString(ctrlCulture.NumberFormat.CurrencySymbol)} >");

            Assert.IsNull(nullValue.ToLocalizedString());
            Assert.AreNotEqual(nonNullvalue.ToString(ctrlCulture.NumberFormat.CurrencySymbol), value.ToLocalizedString());

            SetCulture(new("en-US"));
        }

        [TestMethod]
        public void ConvertToDateTime_ValidInput_YieldsExpectedDateTime()
        {
            string dateTime = "01/01/2021";
            DateTime observed = dateTime.ConvertToDateTime() ?? default;
            DateTime expected = new(2021, 1, 1);

            Assert.AreEqual(expected, observed);
        }

        [TestMethod]
        public void ConvertToDateTime_ValidInput_DifferentCulture_YieldsExpectedDateTime()
        {
            string dateTime = "13.02.2021";

            CultureInfo expCulture = new("de-DE");

            SetCulture(expCulture);

            DateTime observed = dateTime.ConvertToDateTime() ?? default;
            DateTime expected = new(2021, 2, 13);

            Assert.AreEqual(expected, observed);

            SetCulture(new("en-US"));
        }

        [TestMethod]
        public void ConvertToDateTime_InvalidInput_ForCulture_YieldsNull()
        {
            string dateTime = "13.02.2021";

            CultureInfo expCulture = new("de-DE");
            CultureInfo ctrlCulture = new("en-US");

            SetCulture(ctrlCulture);

            DateTime? observed = dateTime.ConvertToDateTime();

            Assert.IsNull(observed);

            SetCulture(expCulture);

            observed = dateTime.ConvertToDateTime();

            Assert.IsNotNull(observed);

            SetCulture(new("en-US"));
        }

        [TestMethod] 
        public void ConvertToDateTime_ValidInput_WithPattern_YieldsExpectedDateTime()
        {
            string dateTime = "13.02.2021";

            DateTime? observed = dateTime.ConvertToDateTime("dd.MM.yyyy");
            DateTime? observedDefaultCulture = dateTime.ConvertToDateTime();

            Assert.AreEqual(new DateTime(2021, 2, 13), observed);
            Assert.IsNull(observedDefaultCulture);
        }


        [TestMethod]
        public void ConvertToDateTime_InvalidInput_YieldsNull()
        {
            string dateTime1 = "123456ABC";
            string dateTime2 = null;
            DateTime? observed1 = dateTime1.ConvertToDateTime();
            DateTime? observed2 = dateTime2.ConvertToDateTime();

            Assert.IsNull(observed1);
            Assert.IsNull(observed2);
        }

        [TestMethod]
        public void ToTitleCase_YieldsMatchingString()
        {
            string title = "one flew over the cuckoo's nest";
            string observed = title.ToTitleCase();
            string expected = "One Flew Over The Cuckoo's Nest";

            Debug.WriteLine($"Observed< {observed} >");
            Debug.WriteLine($"Expected< {expected} >");
            Assert.AreEqual(observed, expected);
        }

        private static void SetCulture(CultureInfo cultureInfo)
        {
            if (cultureInfo is null)
                throw new ArgumentNullException(paramName: nameof(cultureInfo));

            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;
        }
    }
}

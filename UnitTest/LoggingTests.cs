using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ichosoft.Extensions.Common.Logging;

namespace Ichosoft.Extensions.Common.UnitTest
{
    [TestClass]
    public class LoggingTests
    {
        [TestMethod]
        public void ConvertToLogTemplate_ValidEntry_YieldsExpectedString()
        {
            string str = "{0} initialized with initial parameters: {1} {2}";

            string expected = "{Class} initialized with initial parameters: {Value1} {Value2}";
            string observed = str.ConvertToLogTemplate("Class", "Value1", "Value2");


            Assert.AreEqual(expected, observed);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakeItTillYouMakeIt.Examples
{
    [TestClass]
    public class PhoneNumberTest
    {
        [TestMethod]
        public void TestPrint()
        {
            Assert.AreEqual("+1(858)336-6560", PhoneNumber.ToString("18583366560"));
        }
    }

    public class PhoneNumber
    {
        public static string ToString(String s)
        {
            return "+1(858)336-6560";
        }
    }
}

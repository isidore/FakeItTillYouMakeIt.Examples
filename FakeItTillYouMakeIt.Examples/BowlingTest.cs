using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakeItTillYouMakeIt.Examples
{
    [TestClass]
    public class BowlingTest
    {
        [TestMethod]
        public void TestScoring()
        {
            var javaPath = @"C:\ProgramData\Oracle\Java\javapath\javaw.exe";
            var counterDisplay = @"C:\code\FakeItTillYouMakeIt.Examples\CounterDisplay.jar";

            TestCounter.ResetAndLaunch(javaPath, counterDisplay);
            TestCounter.Launch(javaPath, counterDisplay);
            TestCounter.Track(Score);
        }

        public void Score()
        {
        }
    }
}
using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalUtilities.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakeItTillYouMakeIt.Examples
{
    [TestClass]
    public class BowlingTest
    {
        [TestMethod]
        public void TestScoring()
        {
            //TestCounter.ResetAndLaunch();
            TestCounter.Track(Score);
        }

        public void Score()
        {
           
        }
    }
}
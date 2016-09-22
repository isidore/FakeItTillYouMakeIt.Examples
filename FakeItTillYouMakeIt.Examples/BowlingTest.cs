﻿using System;
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
            try
            {
             // FakeItCounter.ResetAndLaunch();
            var game = new Bowling();
            game.Roll( 3, 5,10,3, 7,8, 1,10,10,6, 2,5, 4, 7, 3, 10, 6, 3);
            var expected = @"
1) 3, 5 [8]= 8
2) 10 [20] = 28
3) 3, 7 [18] = 46
4) 8 [9] = 55
5) 10 [26] = 81
6) 10 [18] = 99
7) 6, 2 [8] = 107
8) 5, 4 [9] = 116
9) 7, 3 [20] = 136
10) 10, 6, 3 [19] = 155
".Trim();
            Assert.AreEqual(expected, game.ToString());
            FakeItCounter.IncrementSuccess();
            }
            catch (Exception)
            {
                FakeItCounter.IncrementFailure();
                throw;
            }
        }
    }
}
using NUnit.Framework;
using Solutions;

namespace HackerRank
{
    [TestFixture]
    class WarmUpChallengesTests
    {

        [Test]
        public void SockMerchant()
        {
            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int n = 9;
            int result = WarmUpChallenges.SockMerchant(n, ar);

            int expected = 3;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CountingValleys()
        {
            //Test Case 1
            int n = 8;
            string s = "UDDDUDUU";
            int result = WarmUpChallenges.CountingValleys(n, s);

            int expected = 1;
            Assert.AreEqual(expected, result);


            //Test Case 2
            n = 12;
            s = "DDUUDDUDUUUD";
            result = WarmUpChallenges.CountingValleys(n, s);

            expected = 2;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void JumpingOnTheClouds()
        {
            //Test Case 1
            int[] c = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            int result = WarmUpChallenges.JumpingOnClouds(c);

            int expected = 4;
            Assert.AreEqual(expected, result);


            //Test Case 2
            c = new int[] { 0, 0, 0, 0, 1, 0 };
            result = WarmUpChallenges.JumpingOnClouds(c);

            expected = 3;
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void RepeatedString()
        {
            //Test Case 1
            string s = "aba";
            long n = 10;
            long result = WarmUpChallenges.RepeatedString(s, n);

            long expected = 7;
            Assert.AreEqual(expected, result);

            //Test Case 2
            s = "a";
            n = 1000000000000;
            result = WarmUpChallenges.RepeatedString(s, n);

            expected = 1000000000000;
            Assert.AreEqual(expected, result);
        }
    }
}

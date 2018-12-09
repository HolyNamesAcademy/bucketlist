using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace iBucketList.UITests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AzurePipelinesValidationTest()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void AzurePipelinesValidationTestThatFails()
        {
            Assert.AreEqual(1, 2);
        }
    }
}

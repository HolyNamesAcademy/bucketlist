using System;
using Xunit;

namespace iBucketList.UnitTests
{
    public class ValidationTests
    {
        [Fact]
        public void AzurePipelinesValidationTest()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void AzurePipelinesValidationTestThatFails()
        {
            Assert.Equal(1, 2);
        }
   }
}

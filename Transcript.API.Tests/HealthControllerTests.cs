using System;
using Transcript.API.Controllers;
using Xunit;

namespace Transcript.API.Tests
{
    public class HealthControllerTests
    {
        [Fact]
        public void GetTest()
        {
            var sut = new HealthController();
            Assert.NotNull(sut.Get());
        }
    }
}

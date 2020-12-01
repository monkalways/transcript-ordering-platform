using NUnit.Framework;
using Transcript.API.Controllers;

namespace TranscriptAPI.Tests
{
    public class Tests
    {
        [Test]
        public void GetTest()
        {
            var sut = new HealthController();
            Assert.IsNotNull(sut.Get());
        }
    }
}
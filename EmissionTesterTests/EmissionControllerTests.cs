using System;
using System.Threading.Tasks;
using Interfaces;
using KursSummerExperience2018;
using Moq;
using NUnit.Framework;

namespace EmissionTesterTests
{
    [TestFixture]
    public class EmissionControllerTests
    {
        public EmissionTestController emissionTestController;

        [SetUp]
        public void SetUp() {
            var emissionTester = new Mock<IEmissionTester>();

            emissionTester.Setup(x => x.RunEmissionTest()).Returns(Task.FromResult(9));

            emissionTestController = new EmissionTestController(emissionTester.Object);
        }

        [Test]
        public void EmissionTest() {
            var result = emissionTestController.DoTest().Result;

            Assert.That(result, Is.EqualTo(9));
        }
    }
}

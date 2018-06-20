using System;
using System.Threading.Tasks;
using Interfaces;

namespace KursSummerExperience2018
{
    public class EmissionTestController
    {
        private readonly IEmissionTester _emissionTester;

        public EmissionTestController(IEmissionTester emissionTester)
        {
            _emissionTester = emissionTester;
        }

        public async Task DoTest() {
            var result = await _emissionTester.RunEmissionTest();

            Console.WriteLine($"Emission test results: {result}");

            return;
        }
    }
}

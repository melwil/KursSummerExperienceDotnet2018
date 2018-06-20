using System;
using System.Threading.Tasks;
using Interfaces;

namespace Testing.API
{
    public class EmissionTester : IEmissionTester
    {
        public async Task<int> RunEmissionTest()
        {
            // Simulate api call
            var result = await Task.FromResult<int>(0);

            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace Testing.API
{
    public class EmissionTester : IEmissionTester
    {
        public async Task<int> RunEmissionTest()
        {
            // Simulate api call
            // Kunne like gjer vært: HttpClient.RunAsync(....) => int
            //var result = await Task.FromResult<int>(0);

            // Alternativ måte å bruke tasks
            var resultTask1 = Task.FromResult<int>(0);
            var resultTask2 = Task.FromResult<int>(5);

            var somethingElse = 2 + 2;

            var result = await Task.WhenAll(resultTask1, resultTask2);

            await Task.Delay(1000);

            return somethingElse + result.Sum();
        }

        // Out of place quick Linq tutorial

        //private void somethingElse() {
        //    var dictionary = new Dictionary<string, int>{
        //        {"one", 1},
        //        {"two", 2},
        //        {"three", 3}
        //    };

        //    var sumOfDictValues = dictionary
        //        .Select(x => x.Value.AddOne())
        //        .Sum();
        //}

        //public int AddOne(this int local) {
        //    return local + 1;
        //}
    }
}

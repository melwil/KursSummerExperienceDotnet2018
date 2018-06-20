using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ServiceResolution;

namespace KursSummerExperience2018
{
    public class Program
    {
        public IServiceProvider serviceProvider { get; private set; }

        static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync() {


            var car = new Mercedes(4);
            Console.WriteLine($"Our Mercedes has {car.Wheels} wheels!");

            InitializeIoC();

            //var emissionTester = serviceProvider.GetRequiredService<IEmissionTester>();

            //var result = emissionTester.RunEmissionTest().Result;

            //Console.WriteLine($"Emission test results: {result}");

            var emissionTestController = serviceProvider.GetRequiredService<EmissionTestController>();

            var testTask = emissionTestController.DoTest();

            Console.WriteLine("This is going to happen before DoTest prints!");

            await testTask;

        }

        private void InitializeIoC() {
            var services = new ServiceCollection();

            services.AddTransient<EmissionTestController>();

            IoC.Configure(services);

            serviceProvider = services.BuildServiceProvider();
        }
    }
}

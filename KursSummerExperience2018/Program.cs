using System;
using Microsoft.Extensions.DependencyInjection;
using ServiceResolution;

namespace KursSummerExperience2018
{
    public class Program
    {
        public IServiceProvider serviceProvider { get; private set; };

        static void Main(string[] args)
        {
            new Program();
        }

        public Program() {
            var services = new ServiceCollection();
            IoC.Configure(services);


            var car = new Mercedes(4);

            Console.WriteLine($"Our Mercedes has {car.Wheels} wheels!");
        }
    }
}

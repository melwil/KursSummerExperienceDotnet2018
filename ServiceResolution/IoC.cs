using System;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Testing.API;

namespace ServiceResolution
{
    public static class IoC
    {
        public static void Configure(IServiceCollection services) {
            services.AddTransient<IEmissionTester, EmissionTester>();
        }
    }
}

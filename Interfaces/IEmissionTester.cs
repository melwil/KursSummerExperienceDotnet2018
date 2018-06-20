using System;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEmissionTester
    {
        Task<int> RunEmissionTest();
    }
}

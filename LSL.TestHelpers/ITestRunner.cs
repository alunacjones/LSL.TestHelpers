using System.Threading.Tasks;

namespace LSL.TestHelpers;

/// <summary>
/// Interface for running tests
/// </summary>
/// <typeparam name="TSystemUnderTest"></typeparam>
public interface ITestRunner<TSystemUnderTest> 
{
    /// <summary>
    /// Runs an asynchronous test
    /// </summary>
    /// <param name="asyncTestRunningDelegate">The asynchronous delegate that performs the testing on the system under test</param>
    /// <returns></returns>    
    Task RunTestAsync(AsyncTestRunningDelegate<TSystemUnderTest> asyncTestRunningDelegate);
}

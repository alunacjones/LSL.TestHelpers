using System.Threading.Tasks;

namespace LSL.TestHelpers;

/// <summary>
/// TestRunnerExtensions
/// </summary>
public static class TestRunnerExtensions
{
    /// <summary>
    /// Runs a synchronous test
    /// </summary>
    /// <typeparam name="TSystemUnderTest"></typeparam>
    /// <param name="source"></param>
    /// <param name="testRunner">The delegate that performs the testing on the system under test</param>
    public static void RunTest<TSystemUnderTest>(this ITestRunner<TSystemUnderTest> source, SynchronousTestRunningDelegate<TSystemUnderTest> testRunner) => 
        Task.Run(() => source.RunTest(testRunner)).GetAwaiter().GetResult();
}

/// <summary>
/// Delegate for running a synchronous test
/// </summary>
/// <typeparam name="TSystemUnderTest"></typeparam>
/// <param name="testContext"></param>
/// <returns></returns>
public delegate void SynchronousTestRunningDelegate<TSystemUnderTest>(TestContext<TSystemUnderTest> testContext);
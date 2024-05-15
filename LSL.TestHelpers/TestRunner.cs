using System.Threading.Tasks;

namespace LSL.TestHelpers;

/// <summary>
/// Entry point for creating a test runner
/// </summary>
public static class TestRunner
{
    /// <summary>
    /// Creates a test runner to test the given type
    /// </summary>
    /// <typeparam name="TSystemUnderTest"></typeparam>
    /// <returns></returns>
    public static ITestRunner<TSystemUnderTest> Create<TSystemUnderTest>()
    {
        return new TestRunnerImpl<TSystemUnderTest>();    
    }
}

/// <summary>
/// Delegate for running an asynchronous test
/// </summary>
/// <typeparam name="TSystemUnderTest"></typeparam>
/// <param name="testContext"></param>
/// <returns></returns>
public delegate Task AsyncTestRunningDelegate<TSystemUnderTest>(TestContext<TSystemUnderTest> testContext);
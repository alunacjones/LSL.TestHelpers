using System.Threading.Tasks;

namespace LSL.TestHelpers;

internal class TestRunnerImpl<TSystemUnderTest> : ITestRunner<TSystemUnderTest>
{
    /// <inheritdoc/>
    public async Task RunTestAsync(AsyncTestRunningDelegate<TSystemUnderTest> asyncTestRunningDelegate)
    {
        var context = new TestContext<TSystemUnderTest>();
        await asyncTestRunningDelegate(context);
    }
}

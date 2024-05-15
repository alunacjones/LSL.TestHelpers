using System;

namespace LSL.TestHelpers;

/// <summary>
/// Context for the currently running test
/// </summary>
public interface ITestContext
{
    /// <summary>
    /// An <c>IServiceProvider</c> that can be used to retrieve registered services
    /// </summary>
    IServiceProvider ServiceProvider { get; }
}

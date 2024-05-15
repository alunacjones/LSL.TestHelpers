using System;

namespace LSL.TestHelpers;

/// <summary>
/// A context that provides a System Under Test (Sut) and associated defaults to test against
/// </summary>
/// <param name="Sut">The System Under Test</param>
/// <param name="ServiceProvider">An <c>IServiceProvider</c> that can be used to retrieve registered services</param>
/// <typeparam name="T"></typeparam>
/// <returns></returns>
public record TestContext<T>(T Sut, IServiceProvider ServiceProvider) : ITestContext;

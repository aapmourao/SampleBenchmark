using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

[MemoryDiagnoser]
//[ThreadingDiagnoser]
public class FunctionBenchmarkExecutor
{

    SimpleFunctionCompileTimeLogging simpleFunctionCompileTimeLogging; 
    SimpleFunctionLogging simpleFunctionLogging;
    const int iterations = 10000;

    public FunctionBenchmarkExecutor() {

        var serviceProvider = new ServiceCollection()
            .AddLogging()
            .AddScoped<SimpleFunctionCompileTimeLogging>()
            .AddScoped<SimpleFunctionLogging>()
            .BuildServiceProvider();

        simpleFunctionCompileTimeLogging = serviceProvider.GetService<SimpleFunctionCompileTimeLogging>()!;
        simpleFunctionLogging = serviceProvider.GetService<SimpleFunctionLogging>()!;
    }

    [Benchmark]
    public void BenchmarkSimpleFunctionCompileTimeLogging()
    {
        FunctionBenchmark benchmark = new FunctionBenchmark(simpleFunctionCompileTimeLogging);
        benchmark.Execute(iterations);
    }

    [Benchmark]
    public void BenchmarkSimpleFunctionLogging()
    {
        FunctionBenchmark benchmark = new FunctionBenchmark(simpleFunctionLogging);
        benchmark.Execute(iterations);
    }
}
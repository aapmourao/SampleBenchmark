// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


internal class Program
{
    private static void Main(string[] args)
    {
        // Run benchmarks - Note this isn't standard usage; see below for optimization ideas if needed!
        BenchmarkRunner.Run<FunctionBenchmarkExecutor>();
    }
}
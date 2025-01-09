```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
11th Gen Intel Core i7-11850H 2.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                                    | Mean      | Error    | StdDev   | Gen0      | Allocated |
|------------------------------------------ |----------:|---------:|---------:|----------:|----------:|
| BenchmarkSimpleFunctionCompileTimeLogging |  91.60 ms | 1.125 ms | 0.878 ms | 5833.3333 |  70.19 MB |
| BenchmarkSimpleFunctionLogging            | 120.04 ms | 2.369 ms | 3.618 ms | 7000.0000 |  85.45 MB |

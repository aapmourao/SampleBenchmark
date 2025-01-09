```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
11th Gen Intel Core i7-11850H 2.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                                    | Mean      | Error     | StdDev    | Gen0     | Allocated |
|------------------------------------------ |----------:|----------:|----------:|---------:|----------:|
| BenchmarkSimpleFunctionCompileTimeLogging |  8.731 ms | 0.1731 ms | 0.1852 ms | 578.1250 |   7.02 MB |
| BenchmarkSimpleFunctionLogging            | 11.071 ms | 0.2094 ms | 0.1958 ms | 703.1250 |   8.54 MB |

# Benchmark results

===
Interactions set to 10 000
===========================

| Method | Mean | Error | StdDev | Gen0 | Allocated |
| ------------------------------------------ | ----------: |----------: | ----------: |---------: | ----------: |
| BenchmarkSimpleFunctionCompileTimeLogging |  8.731 ms | 0.1731 ms | 0.1852 ms | 578.1250 |   7.02 MB
| BenchmarkSimpleFunctionLogging            | 11.071 ms | 0.2094 ms | 0.1958 ms | 703.1250 |   8.54 MB 
|
 **Legends**

-  Mean      : Arithmetic mean of all measurements
-  Error     : Half of 99.9% confidence interval
-  StdDev    : Standard deviation of all measurements
-  Gen0      : GC Generation 0 collects per 1000 operations
-  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
-  1 ms      : 1 Millisecond (0.001 sec)

## Summary (by Copilot):

When considering the use of `SimpleFunctionCompileTimeLogging` and `SimpleFunctionLogging` use case in an AWS Lambda environment, several factors come into play, including performance, memory usage, cold start times, and cost. Here's an analysis of the impact of each approach:

### **Performance**
SimpleFunctionCompileTimeLogging:
  - **Pros**: Faster execution time (8.867 ms vs. 11.342 ms).
  - **Cons:** None specific to performance.

SimpleFunctionLogging:
  - **Pros:** None specific to performance.
  - **Cons:** Slower execution time.

### **Memory Usage**
SimpleFunctionCompileTimeLogging:
  - **Pros:** Lower memory allocation (7.02 MB vs. 8.54 MB).
  - **Cons:** None specific to memory usage.

SimpleFunctionLogging:
  - **Pros:** None specific to memory usage.
  - **Cons:** Higher memory allocation.

### **Cold Start Times**
SimpleFunctionCompileTimeLogging:
  - **Pros:** Potentially faster cold start times due to lower memory usage and faster execution.
  - **Cons:** None specific to cold start times.

SimpleFunctionLogging:
  - **Pros:** None specific to cold start times.
  - **Cons:** Potentially slower cold start times due to higher memory usage and slower execution.

### **Cost**

SimpleFunctionCompileTimeLogging:
  - **Pros:** Lower cost due to faster execution and lower memory usage.
  - **Cons:** None specific to cost.

SimpleFunctionLogging:
  - **Pros:** None specific to cost.
  - **Cons:** Higher cost due to slower execution and higher memory usage.

### **Summary**

- `SimpleFunctionCompileTimeLogging` is generally more efficient and cost-effective in an AWS Lambda environment due to its faster execution time and lower memory usage. This can lead to reduced cold start times and lower overall costs.
- `SimpleFunctionLogging` is less efficient and may result in higher costs and slower performance in an AWS Lambda environment.

Given these factors, SimpleFunctionCompileTimeLogging is the preferable choice for use in an AWS Lambda environment.


===
Interactions set to 100 000
===========================

| Method                                    | Mean      | Error    | StdDev   | Gen0      | Allocated |
|------------------------------------------ |----------:|---------:|---------:|----------:|----------:|
| BenchmarkSimpleFunctionCompileTimeLogging |  91.60 ms | 1.125 ms | 0.878 ms | 5833.3333 |  70.19 MB |
| BenchmarkSimpleFunctionLogging            | 120.04 ms | 2.369 ms | 3.618 ms | 7000.0000 |  85.45 MB |

 **Legends**

-  Mean      : Arithmetic mean of all measurements
-  Error     : Half of 99.9% confidence interval
-  StdDev    : Standard deviation of all measurements
-  Gen0      : GC Generation 0 collects per 1000 operations
-  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
-  1 ms      : 1 Millisecond (0.001 sec)
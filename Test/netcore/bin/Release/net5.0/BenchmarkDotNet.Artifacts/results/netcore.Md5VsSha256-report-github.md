```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
Intel Core i3-1005G1 CPU 1.20GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]     : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2


```
| Method                    | Mean        | Error     | StdDev    |
|-------------------------- |------------:|----------:|----------:|
| MethodSumUsingFor         |    43.76 μs |  0.873 μs |  1.006 μs |
| MethodSumUsingForParallel | 2,457.55 μs | 25.275 μs | 23.642 μs |
| MethodSumUsingLinq        |          NA |        NA |        NA |

Benchmarks with issues:
  Md5VsSha256.MethodSumUsingLinq: DefaultJob

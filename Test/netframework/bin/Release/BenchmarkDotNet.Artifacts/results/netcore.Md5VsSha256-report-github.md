```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
Intel Core i3-1005G1 CPU 1.20GHz, 1 CPU, 4 logical and 2 physical cores
  [Host]     : .NET Framework 4.8.1 (4.8.9261.0), X86 LegacyJIT [AttachedDebugger]
  DefaultJob : .NET Framework 4.8.1 (4.8.9261.0), X86 LegacyJIT


```
| Method                    | Mean        | Error     | StdDev    |
|-------------------------- |------------:|----------:|----------:|
| MethodSumUsingFor         |    31.90 μs |  0.442 μs |  0.414 μs |
| MethodSumUsingForParallel | 2,304.70 μs | 43.335 μs | 60.750 μs |
| MethodSumUsingLinq        |          NA |        NA |        NA |

Benchmarks with issues:
  Md5VsSha256.MethodSumUsingLinq: DefaultJob

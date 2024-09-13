```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
Intel Core i3-1005G1 CPU 1.20GHz, 1 CPU, 4 logical and 2 physical cores
  [Host]     : .NET Framework 4.8.1 (4.8.9261.0), X86 LegacyJIT [AttachedDebugger]
  DefaultJob : .NET Framework 4.8.1 (4.8.9261.0), X86 LegacyJIT


```
| Method                | Mean      | Error    | StdDev   | Median    |
|---------------------- |----------:|---------:|---------:|----------:|
| ReadExcelUsingEPPlus  |  17.38 ms | 0.425 ms | 1.247 ms |  17.84 ms |
| ReadExcelUsingOpenXml | 174.88 ms | 3.458 ms | 8.864 ms | 174.41 ms |

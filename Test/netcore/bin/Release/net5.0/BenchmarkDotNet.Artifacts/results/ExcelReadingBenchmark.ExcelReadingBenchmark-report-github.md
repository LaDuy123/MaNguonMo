```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
Intel Core i3-1005G1 CPU 1.20GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]     : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2


```
| Method                | Mean      | Error    | StdDev   | Median    |
|---------------------- |----------:|---------:|---------:|----------:|
| ReadExcelUsingEPPlus  |  13.46 ms | 0.336 ms | 0.991 ms |  13.72 ms |
| ReadExcelUsingOpenXml | 106.78 ms | 2.723 ms | 7.855 ms | 107.06 ms |

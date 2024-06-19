```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3737/22H2/2022Update/SunValley2)
AMD Ryzen 5 4600H with Radeon Graphics, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


```
| Method    | Mean     | Error     | StdDev    |
|---------- |---------:|----------:|----------:|
| MyFor     | 1.100 ns | 0.0379 ns | 0.0354 ns |
| MyForEach | 4.426 ns | 0.0410 ns | 0.0383 ns |

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3737/22H2/2022Update/SunValley2)
AMD Ryzen 5 4600H with Radeon Graphics, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


```
| Method          | iterationNumber | Mean          | Error        | StdDev     | Gen0      | Allocated |
|---------------- |---------------- |--------------:|-------------:|-----------:|----------:|----------:|
| **MyString**        | **10**              |      **94.64 ns** |     **0.999 ns** |   **0.886 ns** |    **0.1606** |     **336 B** |
| MyStringBuilder | 10              |      47.95 ns |     0.288 ns |   0.255 ns |    0.0727 |     152 B |
| **MyString**        | **100**             |   **1,774.01 ns** |    **10.976 ns** |  **10.267 ns** |    **9.9716** |   **20856 B** |
| MyStringBuilder | 100             |     513.35 ns |     4.518 ns |   4.005 ns |    0.6113 |    1280 B |
| **MyString**        | **1000**            | **136,821.29 ns** | **1,017.641 ns** | **951.902 ns** | **1356.9336** | **2840456 B** |
| MyStringBuilder | 1000            |   4,602.22 ns |    27.891 ns |  26.090 ns |    7.0190 |   14712 B |

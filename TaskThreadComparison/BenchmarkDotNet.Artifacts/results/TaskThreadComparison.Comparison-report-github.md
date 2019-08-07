``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742190 Hz, Resolution=364.6720 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|  Method | limit |           Mean |        Error |      StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------- |------ |---------------:|-------------:|------------:|-------:|------:|------:|----------:|
| Threads |     3 |       483.9 us |     9.511 us |    11.32 us | 7.8125 |     - |     - |     688 B |
|   Tasks |     3 | 3,007,428.1 us | 7,006.843 us | 6,554.20 us |      - |     - |     - |     272 B |

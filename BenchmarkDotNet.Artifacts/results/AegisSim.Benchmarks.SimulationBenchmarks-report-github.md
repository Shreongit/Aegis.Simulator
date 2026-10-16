```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
12th Gen Intel Core i5-12450HX 2.40GHz, 1 CPU, 12 logical and 8 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method       | AgentCount | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------- |----------- |-----------:|---------:|---------:|-------:|----------:|
| **UpdateAgents** | **200**        |   **305.6 ns** |  **5.98 ns** |  **5.88 ns** | **0.0062** |      **40 B** |
| **UpdateAgents** | **500**        |   **815.6 ns** | **15.62 ns** | **21.37 ns** | **0.0057** |      **40 B** |
| **UpdateAgents** | **1000**       | **2,189.5 ns** | **30.08 ns** | **23.48 ns** | **0.0038** |      **40 B** |

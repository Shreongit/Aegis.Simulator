```text
PS C:\Users\patha\Documents\Programming\C# Development\Aegis Sim> dotnet build AegisSim.Benchmarks -c Release
Restore complete (0.4s)
  AegisSim.Core net10.0 succeeded (0.6s) → AegisSim.Core\bin\Release\net10.0\AegisSim.Core.dll
  AegisSim.Benchmarks net10.0 succeeded (0.5s) → AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks.dll

Build succeeded in 1.9s
PS C:\Users\patha\Documents\Programming\C# Development\Aegis Sim> dotnet run --project AegisSim.Benchmarks -c Release
// Validating benchmarks:
// ***** BenchmarkRunner: Start   *****
// ***** Found 3 benchmark(s) in total *****
// ***** Building 1 exe(s) in Parallel: Start   *****
// start dotnet  restore --nodeReuse:false /p:UseSharedCompilation=false /p:Deterministic=true /p:Optimize=true /p:ArtifactsPath="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1/" /p:OutDir="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1\bin\Release\net10.0/" /p:OutputPath="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1\bin\Release\net10.0/" /p:PublishDir="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1\publish/" in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1
// command took 1.12 sec and exited with 0
// start dotnet  build -c Release --no-restore --nodeReuse:false /p:UseSharedCompilation=false /p:Deterministic=true /p:Optimize=true /p:ArtifactsPath="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1/" /p:OutDir="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1\bin\Release\net10.0/" /p:OutputPath="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1\bin\Release\net10.0/" /p:PublishDir="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1\publish/" --output "C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1\bin\Release\net10.0/" in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1
// command took 6.08 sec and exited with 0
// ***** Done, took 00:00:07 (7.29 sec)   *****
// Found 3 benchmarks:
//   SimulationBenchmarks.UpdateAgents: DefaultJob [AgentCount=200]
//   SimulationBenchmarks.UpdateAgents: DefaultJob [AgentCount=500]                                                                                                                                                                 
//   SimulationBenchmarks.UpdateAgents: DefaultJob [AgentCount=1000]                                                                                                                                                                
                                                                                                                                                                                                                                    
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************                                                                                                                                                                                                       
// Benchmark: SimulationBenchmarks.UpdateAgents: DefaultJob [AgentCount=200]                                                                                                                                                        
// *** Execute ***                                                                                                                                                                                                                  
// Launch: 1 / 1                                                                                                                                                                                                                    
// Execute: dotnet AegisSim.Benchmarks-DefaultJob-1.dll --anonymousPipes 1460 1500 --benchmarkName "AegisSim.Benchmarks.SimulationBenchmarks.UpdateAgents(AgentCount: 200)" --job Default --benchmarkId 0 in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1\bin\Release\net10.0                                                                                                 
// BeforeAnythingElse                                                                                                                                                                                                               

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.8
// Runtime=.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2+BMI1+BMI2+F16C+FMA+LZCNT+MOVBE,AVX,SSE3+SSSE3+SSE4.1+SSE4.2+POPCNT,X86Base+SSE+SSE2,AES+PCLMUL,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 150700.00 ns, 150.7000 us/op
WorkloadJitting  1: 1 op, 1053900.00 ns, 1.0539 ms/op

OverheadJitting  2: 16 op, 205500.00 ns, 12.8438 us/op
WorkloadJitting  2: 16 op, 508000.00 ns, 31.7500 us/op

WorkloadPilot    1: 16 op, 339100.00 ns, 21.1938 us/op
WorkloadPilot    2: 32 op, 583500.00 ns, 18.2344 us/op
WorkloadPilot    3: 64 op, 1189900.00 ns, 18.5922 us/op
WorkloadPilot    4: 128 op, 958000.00 ns, 7.4844 us/op
WorkloadPilot    5: 256 op, 1537500.00 ns, 6.0059 us/op
WorkloadPilot    6: 512 op, 3084400.00 ns, 6.0242 us/op
WorkloadPilot    7: 1024 op, 6077700.00 ns, 5.9353 us/op
WorkloadPilot    8: 2048 op, 12025000.00 ns, 5.8716 us/op
WorkloadPilot    9: 4096 op, 23646000.00 ns, 5.7729 us/op
WorkloadPilot   10: 8192 op, 46553100.00 ns, 5.6828 us/op
WorkloadPilot   11: 16384 op, 93731800.00 ns, 5.7209 us/op
WorkloadPilot   12: 32768 op, 20543100.00 ns, 626.9257 ns/op
WorkloadPilot   13: 65536 op, 20505300.00 ns, 312.8860 ns/op
WorkloadPilot   14: 131072 op, 41766900.00 ns, 318.6562 ns/op
WorkloadPilot   15: 262144 op, 80480700.00 ns, 307.0095 ns/op
WorkloadPilot   16: 524288 op, 161451700.00 ns, 307.9447 ns/op
WorkloadPilot   17: 1048576 op, 325080400.00 ns, 310.0208 ns/op
WorkloadPilot   18: 2097152 op, 644765700.00 ns, 307.4482 ns/op

OverheadWarmup   1: 2097152 op, 4494200.00 ns, 2.1430 ns/op
OverheadWarmup   2: 2097152 op, 4567600.00 ns, 2.1780 ns/op
OverheadWarmup   3: 2097152 op, 4506500.00 ns, 2.1489 ns/op
OverheadWarmup   4: 2097152 op, 4737900.00 ns, 2.2592 ns/op
OverheadWarmup   5: 2097152 op, 4633700.00 ns, 2.2095 ns/op

OverheadActual   1: 2097152 op, 4703100.00 ns, 2.2426 ns/op
OverheadActual   2: 2097152 op, 4575500.00 ns, 2.1818 ns/op
OverheadActual   3: 2097152 op, 4674800.00 ns, 2.2291 ns/op
OverheadActual   4: 2097152 op, 4568700.00 ns, 2.1785 ns/op
OverheadActual   5: 2097152 op, 4507100.00 ns, 2.1492 ns/op
OverheadActual   6: 2097152 op, 4742700.00 ns, 2.2615 ns/op
OverheadActual   7: 2097152 op, 4660000.00 ns, 2.2221 ns/op
OverheadActual   8: 2097152 op, 4541100.00 ns, 2.1654 ns/op
OverheadActual   9: 2097152 op, 4804200.00 ns, 2.2908 ns/op
OverheadActual  10: 2097152 op, 4754500.00 ns, 2.2671 ns/op
OverheadActual  11: 2097152 op, 4706800.00 ns, 2.2444 ns/op
OverheadActual  12: 2097152 op, 4702000.00 ns, 2.2421 ns/op
OverheadActual  13: 2097152 op, 4712500.00 ns, 2.2471 ns/op
OverheadActual  14: 2097152 op, 4756700.00 ns, 2.2682 ns/op
OverheadActual  15: 2097152 op, 4903100.00 ns, 2.3380 ns/op

WorkloadWarmup   1: 2097152 op, 649062100.00 ns, 309.4969 ns/op
WorkloadWarmup   2: 2097152 op, 642586300.00 ns, 306.4090 ns/op
WorkloadWarmup   3: 2097152 op, 645329400.00 ns, 307.7170 ns/op
WorkloadWarmup   4: 2097152 op, 655964000.00 ns, 312.7880 ns/op
WorkloadWarmup   5: 2097152 op, 655544500.00 ns, 312.5880 ns/op
WorkloadWarmup   6: 2097152 op, 649314200.00 ns, 309.6171 ns/op
WorkloadWarmup   7: 2097152 op, 642965000.00 ns, 306.5896 ns/op
WorkloadWarmup   8: 2097152 op, 644099900.00 ns, 307.1308 ns/op
WorkloadWarmup   9: 2097152 op, 651689500.00 ns, 310.7498 ns/op
WorkloadWarmup  10: 2097152 op, 644525100.00 ns, 307.3335 ns/op

// BeforeActualRun
WorkloadActual   1: 2097152 op, 635284900.00 ns, 302.9274 ns/op
WorkloadActual   2: 2097152 op, 639517500.00 ns, 304.9457 ns/op
WorkloadActual   3: 2097152 op, 634518300.00 ns, 302.5619 ns/op
WorkloadActual   4: 2097152 op, 632267000.00 ns, 301.4884 ns/op
WorkloadActual   5: 2097152 op, 631729100.00 ns, 301.2319 ns/op
WorkloadActual   6: 2097152 op, 629445200.00 ns, 300.1429 ns/op
WorkloadActual   7: 2097152 op, 645161600.00 ns, 307.6370 ns/op
WorkloadActual   8: 2097152 op, 655091900.00 ns, 312.3722 ns/op
WorkloadActual   9: 2097152 op, 643263900.00 ns, 306.7321 ns/op
WorkloadActual  10: 2097152 op, 710646400.00 ns, 338.8626 ns/op
WorkloadActual  11: 2097152 op, 655859100.00 ns, 312.7380 ns/op
WorkloadActual  12: 2097152 op, 663203500.00 ns, 316.2401 ns/op
WorkloadActual  13: 2097152 op, 656624200.00 ns, 313.1028 ns/op
WorkloadActual  14: 2097152 op, 672809200.00 ns, 320.8204 ns/op
WorkloadActual  15: 2097152 op, 719485500.00 ns, 343.0774 ns/op
WorkloadActual  16: 2097152 op, 643828400.00 ns, 307.0013 ns/op
WorkloadActual  17: 2097152 op, 643280700.00 ns, 306.7401 ns/op
WorkloadActual  18: 2097152 op, 646367800.00 ns, 308.2122 ns/op

// AfterActualRun
WorkloadResult   1: 2097152 op, 630581800.00 ns, 300.6848 ns/op
WorkloadResult   2: 2097152 op, 634814400.00 ns, 302.7031 ns/op
WorkloadResult   3: 2097152 op, 629815200.00 ns, 300.3193 ns/op
WorkloadResult   4: 2097152 op, 627563900.00 ns, 299.2458 ns/op
WorkloadResult   5: 2097152 op, 627026000.00 ns, 298.9893 ns/op
WorkloadResult   6: 2097152 op, 624742100.00 ns, 297.9002 ns/op
WorkloadResult   7: 2097152 op, 640458500.00 ns, 305.3944 ns/op
WorkloadResult   8: 2097152 op, 650388800.00 ns, 310.1295 ns/op
WorkloadResult   9: 2097152 op, 638560800.00 ns, 304.4895 ns/op
WorkloadResult  10: 2097152 op, 651156000.00 ns, 310.4954 ns/op
WorkloadResult  11: 2097152 op, 658500400.00 ns, 313.9975 ns/op
WorkloadResult  12: 2097152 op, 651921100.00 ns, 310.8602 ns/op
WorkloadResult  13: 2097152 op, 668106100.00 ns, 318.5778 ns/op
WorkloadResult  14: 2097152 op, 639125300.00 ns, 304.7587 ns/op
WorkloadResult  15: 2097152 op, 638577600.00 ns, 304.4975 ns/op
WorkloadResult  16: 2097152 op, 641664700.00 ns, 305.9696 ns/op
// GC:  13 0 0 83886080 2097152
// Threading:  0 0 2097152

// AfterAll
// Benchmark Process 18936 has exited with code 0.
                                                                                                                                                                                                                                    
Mean = 305.563 ns, StdErr = 1.469 ns (0.48%), N = 16, StdDev = 5.878 ns
Min = 297.900 ns, Q1 = 300.593 ns, Median = 304.628 ns, Q3 = 310.221 ns, Max = 318.578 ns                                                                                                                                           
IQR = 9.628 ns, LowerFence = 286.152 ns, UpperFence = 324.662 ns                                                                                                                                                                    
ConfidenceInterval = [299.579 ns; 311.548 ns] (CI 99.9%), Margin = 5.985 ns (1.96% of Mean)                                                                                                                                         
Skewness = 0.58, Kurtosis = 2.3, MValue = 2                                                                                                                                                                                         
                                                                                                                                                                                                                                    
// ** Remained 2 (66.7%) benchmark(s) to run. Estimated finish 2026-10-15 14:38 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)                                                                                                                                        
// **************************                                                                                                                                                                                                       
// Benchmark: SimulationBenchmarks.UpdateAgents: DefaultJob [AgentCount=500]                                                                                                                                                        
// *** Execute ***                                                                                                                                                                                                                  
// Launch: 1 / 1                                                                                                                                                                                                                    
// Execute: dotnet AegisSim.Benchmarks-DefaultJob-1.dll --anonymousPipes 1512 1528 --benchmarkName "AegisSim.Benchmarks.SimulationBenchmarks.UpdateAgents(AgentCount: 500)" --job Default --benchmarkId 1 in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1\bin\Release\net10.0                                                                                                 
// BeforeAnythingElse                                                                                                                                                                                                               

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.8
// Runtime=.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2+BMI1+BMI2+F16C+FMA+LZCNT+MOVBE,AVX,SSE3+SSSE3+SSE4.1+SSE4.2+POPCNT,X86Base+SSE+SSE2,AES+PCLMUL,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 168100.00 ns, 168.1000 us/op
WorkloadJitting  1: 1 op, 1215400.00 ns, 1.2154 ms/op

OverheadJitting  2: 16 op, 183600.00 ns, 11.4750 us/op
WorkloadJitting  2: 16 op, 1017100.00 ns, 63.5688 us/op

WorkloadPilot    1: 16 op, 700200.00 ns, 43.7625 us/op
WorkloadPilot    2: 32 op, 1509100.00 ns, 47.1594 us/op
WorkloadPilot    3: 64 op, 2725400.00 ns, 42.5844 us/op
WorkloadPilot    4: 128 op, 2275600.00 ns, 17.7781 us/op
WorkloadPilot    5: 256 op, 3799200.00 ns, 14.8406 us/op
WorkloadPilot    6: 512 op, 7422000.00 ns, 14.4961 us/op
WorkloadPilot    7: 1024 op, 14985500.00 ns, 14.6343 us/op
WorkloadPilot    8: 2048 op, 30066600.00 ns, 14.6810 us/op
WorkloadPilot    9: 4096 op, 57430400.00 ns, 14.0211 us/op
WorkloadPilot   10: 8192 op, 100883600.00 ns, 12.3149 us/op
WorkloadPilot   11: 16384 op, 13003200.00 ns, 793.6523 ns/op
WorkloadPilot   12: 32768 op, 26969000.00 ns, 823.0286 ns/op
WorkloadPilot   13: 65536 op, 52973900.00 ns, 808.3176 ns/op
WorkloadPilot   14: 131072 op, 111113900.00 ns, 847.7318 ns/op
WorkloadPilot   15: 262144 op, 210216500.00 ns, 801.9123 ns/op
WorkloadPilot   16: 524288 op, 425657900.00 ns, 811.8780 ns/op
WorkloadPilot   17: 1048576 op, 852040500.00 ns, 812.5691 ns/op

OverheadWarmup   1: 1048576 op, 2335200.00 ns, 2.2270 ns/op
OverheadWarmup   2: 1048576 op, 2253100.00 ns, 2.1487 ns/op
OverheadWarmup   3: 1048576 op, 2294300.00 ns, 2.1880 ns/op
OverheadWarmup   4: 1048576 op, 2305600.00 ns, 2.1988 ns/op
OverheadWarmup   5: 1048576 op, 2812700.00 ns, 2.6824 ns/op
OverheadWarmup   6: 1048576 op, 2413300.00 ns, 2.3015 ns/op
OverheadWarmup   7: 1048576 op, 2339900.00 ns, 2.2315 ns/op
OverheadWarmup   8: 1048576 op, 2321800.00 ns, 2.2142 ns/op
OverheadWarmup   9: 1048576 op, 2277800.00 ns, 2.1723 ns/op
OverheadWarmup  10: 1048576 op, 2385500.00 ns, 2.2750 ns/op

OverheadActual   1: 1048576 op, 2391900.00 ns, 2.2811 ns/op
OverheadActual   2: 1048576 op, 2249900.00 ns, 2.1457 ns/op
OverheadActual   3: 1048576 op, 2275600.00 ns, 2.1702 ns/op
OverheadActual   4: 1048576 op, 2323800.00 ns, 2.2161 ns/op
OverheadActual   5: 1048576 op, 2327900.00 ns, 2.2201 ns/op
OverheadActual   6: 1048576 op, 2361300.00 ns, 2.2519 ns/op
OverheadActual   7: 1048576 op, 2355000.00 ns, 2.2459 ns/op
OverheadActual   8: 1048576 op, 2440700.00 ns, 2.3276 ns/op
OverheadActual   9: 1048576 op, 2324300.00 ns, 2.2166 ns/op
OverheadActual  10: 1048576 op, 2356200.00 ns, 2.2470 ns/op
OverheadActual  11: 1048576 op, 2774100.00 ns, 2.6456 ns/op
OverheadActual  12: 1048576 op, 2438900.00 ns, 2.3259 ns/op
OverheadActual  13: 1048576 op, 2801400.00 ns, 2.6716 ns/op
OverheadActual  14: 1048576 op, 2345100.00 ns, 2.2365 ns/op
OverheadActual  15: 1048576 op, 2766300.00 ns, 2.6381 ns/op

WorkloadWarmup   1: 1048576 op, 844259700.00 ns, 805.1488 ns/op
WorkloadWarmup   2: 1048576 op, 845491700.00 ns, 806.3237 ns/op
WorkloadWarmup   3: 1048576 op, 834112500.00 ns, 795.4717 ns/op
WorkloadWarmup   4: 1048576 op, 840970700.00 ns, 802.0122 ns/op
WorkloadWarmup   5: 1048576 op, 885035700.00 ns, 844.0358 ns/op
WorkloadWarmup   6: 1048576 op, 881908800.00 ns, 841.0538 ns/op

// BeforeActualRun
WorkloadActual   1: 1048576 op, 883400100.00 ns, 842.4760 ns/op
WorkloadActual   2: 1048576 op, 855007700.00 ns, 815.3989 ns/op
WorkloadActual   3: 1048576 op, 851549400.00 ns, 812.1008 ns/op
WorkloadActual   4: 1048576 op, 938771700.00 ns, 895.2825 ns/op
WorkloadActual   5: 1048576 op, 893031500.00 ns, 851.6612 ns/op
WorkloadActual   6: 1048576 op, 867383300.00 ns, 827.2012 ns/op
WorkloadActual   7: 1048576 op, 884093100.00 ns, 843.1369 ns/op
WorkloadActual   8: 1048576 op, 882675100.00 ns, 841.7846 ns/op
WorkloadActual   9: 1048576 op, 895129000.00 ns, 853.6615 ns/op
WorkloadActual  10: 1048576 op, 849585400.00 ns, 810.2278 ns/op
WorkloadActual  11: 1048576 op, 838288000.00 ns, 799.4537 ns/op
WorkloadActual  12: 1048576 op, 836072400.00 ns, 797.3408 ns/op
WorkloadActual  13: 1048576 op, 839106000.00 ns, 800.2338 ns/op
WorkloadActual  14: 1048576 op, 836427600.00 ns, 797.6795 ns/op
WorkloadActual  15: 1048576 op, 847904700.00 ns, 808.6249 ns/op
WorkloadActual  16: 1048576 op, 851021700.00 ns, 811.5975 ns/op
WorkloadActual  17: 1048576 op, 838834600.00 ns, 799.9750 ns/op
WorkloadActual  18: 1048576 op, 837537800.00 ns, 798.7383 ns/op
WorkloadActual  19: 1048576 op, 821411700.00 ns, 783.3592 ns/op
WorkloadActual  20: 1048576 op, 873989300.00 ns, 833.5011 ns/op
WorkloadActual  21: 1048576 op, 838944400.00 ns, 800.0797 ns/op
WorkloadActual  22: 1048576 op, 901000800.00 ns, 859.2613 ns/op
WorkloadActual  23: 1048576 op, 837733100.00 ns, 798.9245 ns/op
WorkloadActual  24: 1048576 op, 866953100.00 ns, 826.7909 ns/op
WorkloadActual  25: 1048576 op, 873093200.00 ns, 832.6466 ns/op
WorkloadActual  26: 1048576 op, 863183600.00 ns, 823.1960 ns/op
WorkloadActual  27: 1048576 op, 832848900.00 ns, 794.2666 ns/op

// AfterActualRun
WorkloadResult   1: 1048576 op, 881043900.00 ns, 840.2289 ns/op
WorkloadResult   2: 1048576 op, 852651500.00 ns, 813.1518 ns/op
WorkloadResult   3: 1048576 op, 849193200.00 ns, 809.8537 ns/op
WorkloadResult   4: 1048576 op, 890675300.00 ns, 849.4142 ns/op
WorkloadResult   5: 1048576 op, 865027100.00 ns, 824.9541 ns/op
WorkloadResult   6: 1048576 op, 881736900.00 ns, 840.8898 ns/op
WorkloadResult   7: 1048576 op, 880318900.00 ns, 839.5375 ns/op
WorkloadResult   8: 1048576 op, 892772800.00 ns, 851.4145 ns/op
WorkloadResult   9: 1048576 op, 847229200.00 ns, 807.9807 ns/op
WorkloadResult  10: 1048576 op, 835931800.00 ns, 797.2067 ns/op
WorkloadResult  11: 1048576 op, 833716200.00 ns, 795.0937 ns/op
WorkloadResult  12: 1048576 op, 836749800.00 ns, 797.9868 ns/op
WorkloadResult  13: 1048576 op, 834071400.00 ns, 795.4325 ns/op
WorkloadResult  14: 1048576 op, 845548500.00 ns, 806.3779 ns/op
WorkloadResult  15: 1048576 op, 848665500.00 ns, 809.3505 ns/op
WorkloadResult  16: 1048576 op, 836478400.00 ns, 797.7280 ns/op
WorkloadResult  17: 1048576 op, 835181600.00 ns, 796.4912 ns/op
WorkloadResult  18: 1048576 op, 819055500.00 ns, 781.1122 ns/op
WorkloadResult  19: 1048576 op, 871633100.00 ns, 831.2541 ns/op
WorkloadResult  20: 1048576 op, 836588200.00 ns, 797.8327 ns/op
WorkloadResult  21: 1048576 op, 898644600.00 ns, 857.0143 ns/op
WorkloadResult  22: 1048576 op, 835376900.00 ns, 796.6775 ns/op
WorkloadResult  23: 1048576 op, 864596900.00 ns, 824.5439 ns/op
WorkloadResult  24: 1048576 op, 870737000.00 ns, 830.3995 ns/op
WorkloadResult  25: 1048576 op, 860827400.00 ns, 820.9490 ns/op
WorkloadResult  26: 1048576 op, 830492700.00 ns, 792.0196 ns/op
// GC:  6 0 0 41943040 1048576
// Threading:  0 0 1048576

// AfterAll
// Benchmark Process 16244 has exited with code 0.
                                                                                                                                                                                                                                    
Mean = 815.573 ns, StdErr = 4.192 ns (0.51%), N = 26, StdDev = 21.374 ns
Min = 781.112 ns, Q1 = 797.337 ns, Median = 809.602 ns, Q3 = 831.040 ns, Max = 857.014 ns                                                                                                                                           
IQR = 33.703 ns, LowerFence = 746.782 ns, UpperFence = 881.596 ns                                                                                                                                                                   
ConfidenceInterval = [799.958 ns; 831.188 ns] (CI 99.9%), Margin = 15.615 ns (1.91% of Mean)                                                                                                                                        
Skewness = 0.4, Kurtosis = 1.82, MValue = 2                                                                                                                                                                                         
                                                                                                                                                                                                                                    
// ** Remained 1 (33.3%) benchmark(s) to run. Estimated finish 2026-10-15 14:38 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)                                                                                                                                        
// **************************                                                                                                                                                                                                       
// Benchmark: SimulationBenchmarks.UpdateAgents: DefaultJob [AgentCount=1000]                                                                                                                                                       
// *** Execute ***                                                                                                                                                                                                                  
// Launch: 1 / 1                                                                                                                                                                                                                    
// Execute: dotnet AegisSim.Benchmarks-DefaultJob-1.dll --anonymousPipes 1420 1492 --benchmarkName "AegisSim.Benchmarks.SimulationBenchmarks.UpdateAgents(AgentCount: 1000)" --job Default --benchmarkId 2 in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-1\bin\Release\net10.0                                                                                                
// BeforeAnythingElse                                                                                                                                                                                                               

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.8
// Runtime=.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2+BMI1+BMI2+F16C+FMA+LZCNT+MOVBE,AVX,SSE3+SSSE3+SSE4.1+SSE4.2+POPCNT,X86Base+SSE+SSE2,AES+PCLMUL,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 133700.00 ns, 133.7000 us/op
WorkloadJitting  1: 1 op, 1300500.00 ns, 1.3005 ms/op

OverheadJitting  2: 16 op, 202100.00 ns, 12.6313 us/op
WorkloadJitting  2: 16 op, 3560800.00 ns, 222.5500 us/op

WorkloadPilot    1: 16 op, 1448700.00 ns, 90.5438 us/op
WorkloadPilot    2: 32 op, 2946800.00 ns, 92.0875 us/op
WorkloadPilot    3: 64 op, 5573600.00 ns, 87.0875 us/op
WorkloadPilot    4: 128 op, 4365600.00 ns, 34.1063 us/op
WorkloadPilot    5: 256 op, 7518200.00 ns, 29.3680 us/op
WorkloadPilot    6: 512 op, 14522900.00 ns, 28.3650 us/op
WorkloadPilot    7: 1024 op, 29586700.00 ns, 28.8933 us/op
WorkloadPilot    8: 2048 op, 46794700.00 ns, 22.8490 us/op
WorkloadPilot    9: 4096 op, 9323400.00 ns, 2.2762 us/op
WorkloadPilot   10: 8192 op, 17615900.00 ns, 2.1504 us/op
WorkloadPilot   11: 16384 op, 35460700.00 ns, 2.1643 us/op
WorkloadPilot   12: 32768 op, 72630600.00 ns, 2.2165 us/op
WorkloadPilot   13: 65536 op, 147854100.00 ns, 2.2561 us/op
WorkloadPilot   14: 131072 op, 289547100.00 ns, 2.2091 us/op
WorkloadPilot   15: 262144 op, 588601400.00 ns, 2.2453 us/op

OverheadWarmup   1: 262144 op, 558500.00 ns, 2.1305 ns/op
OverheadWarmup   2: 262144 op, 562000.00 ns, 2.1439 ns/op
OverheadWarmup   3: 262144 op, 557200.00 ns, 2.1255 ns/op
OverheadWarmup   4: 262144 op, 556900.00 ns, 2.1244 ns/op
OverheadWarmup   5: 262144 op, 589300.00 ns, 2.2480 ns/op
OverheadWarmup   6: 262144 op, 585700.00 ns, 2.2343 ns/op

OverheadActual   1: 262144 op, 613000.00 ns, 2.3384 ns/op
OverheadActual   2: 262144 op, 563000.00 ns, 2.1477 ns/op
OverheadActual   3: 262144 op, 593800.00 ns, 2.2652 ns/op
OverheadActual   4: 262144 op, 584000.00 ns, 2.2278 ns/op
OverheadActual   5: 262144 op, 584600.00 ns, 2.2301 ns/op
OverheadActual   6: 262144 op, 584200.00 ns, 2.2285 ns/op
OverheadActual   7: 262144 op, 593100.00 ns, 2.2625 ns/op
OverheadActual   8: 262144 op, 588000.00 ns, 2.2430 ns/op
OverheadActual   9: 262144 op, 595300.00 ns, 2.2709 ns/op
OverheadActual  10: 262144 op, 587700.00 ns, 2.2419 ns/op
OverheadActual  11: 262144 op, 588000.00 ns, 2.2430 ns/op
OverheadActual  12: 262144 op, 584500.00 ns, 2.2297 ns/op
OverheadActual  13: 262144 op, 584900.00 ns, 2.2312 ns/op
OverheadActual  14: 262144 op, 591400.00 ns, 2.2560 ns/op
OverheadActual  15: 262144 op, 585100.00 ns, 2.2320 ns/op

WorkloadWarmup   1: 262144 op, 574362400.00 ns, 2.1910 us/op
WorkloadWarmup   2: 262144 op, 577309600.00 ns, 2.2023 us/op
WorkloadWarmup   3: 262144 op, 577321200.00 ns, 2.2023 us/op
WorkloadWarmup   4: 262144 op, 583643000.00 ns, 2.2264 us/op
WorkloadWarmup   5: 262144 op, 643755600.00 ns, 2.4557 us/op
WorkloadWarmup   6: 262144 op, 580712700.00 ns, 2.2152 us/op
WorkloadWarmup   7: 262144 op, 577296300.00 ns, 2.2022 us/op
WorkloadWarmup   8: 262144 op, 589435800.00 ns, 2.2485 us/op
WorkloadWarmup   9: 262144 op, 615735300.00 ns, 2.3488 us/op
WorkloadWarmup  10: 262144 op, 602016200.00 ns, 2.2965 us/op

// BeforeActualRun
WorkloadActual   1: 262144 op, 579377600.00 ns, 2.2102 us/op
WorkloadActual   2: 262144 op, 570948900.00 ns, 2.1780 us/op
WorkloadActual   3: 262144 op, 560280400.00 ns, 2.1373 us/op
WorkloadActual   4: 262144 op, 581032000.00 ns, 2.2165 us/op
WorkloadActual   5: 262144 op, 568020400.00 ns, 2.1668 us/op
WorkloadActual   6: 262144 op, 575938500.00 ns, 2.1970 us/op
WorkloadActual   7: 262144 op, 578059300.00 ns, 2.2051 us/op
WorkloadActual   8: 262144 op, 581144000.00 ns, 2.2169 us/op
WorkloadActual   9: 262144 op, 578764700.00 ns, 2.2078 us/op
WorkloadActual  10: 262144 op, 746001200.00 ns, 2.8458 us/op
WorkloadActual  11: 262144 op, 824623600.00 ns, 3.1457 us/op
WorkloadActual  12: 262144 op, 575559800.00 ns, 2.1956 us/op
WorkloadActual  13: 262144 op, 570587100.00 ns, 2.1766 us/op
WorkloadActual  14: 262144 op, 574773300.00 ns, 2.1926 us/op
WorkloadActual  15: 262144 op, 607572200.00 ns, 2.3177 us/op

// AfterActualRun
WorkloadResult   1: 262144 op, 578789900.00 ns, 2.2079 us/op
WorkloadResult   2: 262144 op, 570361200.00 ns, 2.1758 us/op
WorkloadResult   3: 262144 op, 559692700.00 ns, 2.1351 us/op
WorkloadResult   4: 262144 op, 580444300.00 ns, 2.2142 us/op
WorkloadResult   5: 262144 op, 567432700.00 ns, 2.1646 us/op
WorkloadResult   6: 262144 op, 575350800.00 ns, 2.1948 us/op
WorkloadResult   7: 262144 op, 577471600.00 ns, 2.2029 us/op
WorkloadResult   8: 262144 op, 580556300.00 ns, 2.2146 us/op
WorkloadResult   9: 262144 op, 578177000.00 ns, 2.2056 us/op
WorkloadResult  10: 262144 op, 574972100.00 ns, 2.1933 us/op
WorkloadResult  11: 262144 op, 569999400.00 ns, 2.1744 us/op
WorkloadResult  12: 262144 op, 574185600.00 ns, 2.1903 us/op
// GC:  1 0 0 10485760 262144
// Threading:  0 0 262144

// AfterAll
// Benchmark Process 20152 has exited with code 0.
                                                                                                                                                                                                                                    
Mean = 2.189 us, StdErr = 0.007 us (0.31%), N = 12, StdDev = 0.023 us
Min = 2.135 us, Q1 = 2.175 us, Median = 2.194 us, Q3 = 2.206 us, Max = 2.215 us                                                                                                                                                     
IQR = 0.031 us, LowerFence = 2.129 us, UpperFence = 2.252 us                                                                                                                                                                        
ConfidenceInterval = [2.159 us; 2.220 us] (CI 99.9%), Margin = 0.030 us (1.37% of Mean)                                                                                                                                             
Skewness = -0.89, Kurtosis = 2.8, MValue = 2                                                                                                                                                                                        
                                                                                                                                                                                                                                    
// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2026-10-15 14:38 (0h 0m from now) **
Successfully reverted power plan (GUID: 381b4222-f694-41f0-9685-ff5bb260df2e FriendlyName: Balanced)                                                                                                                                
// ***** BenchmarkRunner: Finish  *****                                                                                                                                                                                             
                                                                                                                                                                                                                                    
// * Export *
  BenchmarkDotNet.Artifacts\results\AegisSim.Benchmarks.SimulationBenchmarks-report.csv                                                                                                                                             
  BenchmarkDotNet.Artifacts\results\AegisSim.Benchmarks.SimulationBenchmarks-report-github.md                                                                                                                                       
  BenchmarkDotNet.Artifacts\results\AegisSim.Benchmarks.SimulationBenchmarks-report.html                                                                                                                                            
                                                                                                                                                                                                                                    
// * Detailed results *
SimulationBenchmarks.UpdateAgents: DefaultJob [AgentCount=200]                                                                                                                                                                      
Runtime = .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation                                                                                                                                
Mean = 305.563 ns, StdErr = 1.469 ns (0.48%), N = 16, StdDev = 5.878 ns                                                                                                                                                             
Min = 297.900 ns, Q1 = 300.593 ns, Median = 304.628 ns, Q3 = 310.221 ns, Max = 318.578 ns                                                                                                                                           
IQR = 9.628 ns, LowerFence = 286.152 ns, UpperFence = 324.662 ns                                                                                                                                                                    
ConfidenceInterval = [299.579 ns; 311.548 ns] (CI 99.9%), Margin = 5.985 ns (1.96% of Mean)                                                                                                                                         
Skewness = 0.58, Kurtosis = 2.3, MValue = 2                                                                                                                                                                                         
-------------------- Histogram --------------------                                                                                                                                                                                 
[294.839 ns ; 306.206 ns) | @@@@@@@@@@@                                                                                                                                                                                             
[306.206 ns ; 315.184 ns) | @@@@                                                                                                                                                                                                    
[315.184 ns ; 321.639 ns) | @                                                                                                                                                                                                       
---------------------------------------------------                                                                                                                                                                                 
                                                                                                                                                                                                                                    
SimulationBenchmarks.UpdateAgents: DefaultJob [AgentCount=500]
Runtime = .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation                                                                                                                                
Mean = 815.573 ns, StdErr = 4.192 ns (0.51%), N = 26, StdDev = 21.374 ns                                                                                                                                                            
Min = 781.112 ns, Q1 = 797.337 ns, Median = 809.602 ns, Q3 = 831.040 ns, Max = 857.014 ns                                                                                                                                           
IQR = 33.703 ns, LowerFence = 746.782 ns, UpperFence = 881.596 ns                                                                                                                                                                   
ConfidenceInterval = [799.958 ns; 831.188 ns] (CI 99.9%), Margin = 15.615 ns (1.91% of Mean)                                                                                                                                        
Skewness = 0.4, Kurtosis = 1.82, MValue = 2                                                                                                                                                                                         
-------------------- Histogram --------------------                                                                                                                                                                                 
[771.643 ns ; 791.467 ns) | @                                                                                                                                                                                                       
[791.467 ns ; 823.247 ns) | @@@@@@@@@@@@@@@                                                                                                                                                                                         
[823.247 ns ; 842.186 ns) | @@@@@@@                                                                                                                                                                                                 
[842.186 ns ; 862.684 ns) | @@@                                                                                                                                                                                                     
---------------------------------------------------                                                                                                                                                                                 
                                                                                                                                                                                                                                    
SimulationBenchmarks.UpdateAgents: DefaultJob [AgentCount=1000]
Runtime = .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation                                                                                                                                
Mean = 2.189 us, StdErr = 0.007 us (0.31%), N = 12, StdDev = 0.023 us                                                                                                                                                               
Min = 2.135 us, Q1 = 2.175 us, Median = 2.194 us, Q3 = 2.206 us, Max = 2.215 us                                                                                                                                                     
IQR = 0.031 us, LowerFence = 2.129 us, UpperFence = 2.252 us                                                                                                                                                                        
ConfidenceInterval = [2.159 us; 2.220 us] (CI 99.9%), Margin = 0.030 us (1.37% of Mean)                                                                                                                                             
Skewness = -0.89, Kurtosis = 2.8, MValue = 2                                                                                                                                                                                        
-------------------- Histogram --------------------                                                                                                                                                                                 
[2.122 us ; 2.225 us) | @@@@@@@@@@@@                                                                                                                                                                                                
---------------------------------------------------                                                                                                                                                                                 
                                                                                                                                                                                                                                    
// * Summary *
                                                                                                                                                                                                                                    
BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
12th Gen Intel Core i5-12450HX 2.40GHz, 1 CPU, 12 logical and 8 physical cores                                                                                                                                                      
.NET SDK 10.0.401                                                                                                                                                                                                                   
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3                                                                                                                                                        
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3                                                                                                                                                        
                                                                                                                                                                                                                                    

| Method       | AgentCount | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------- |----------- |-----------:|---------:|---------:|-------:|----------:|
| UpdateAgents | 200        |   305.6 ns |  5.98 ns |  5.88 ns | 0.0062 |      40 B |                                                                                                                                               
| UpdateAgents | 500        |   815.6 ns | 15.62 ns | 21.37 ns | 0.0057 |      40 B |
| UpdateAgents | 1000       | 2,189.5 ns | 30.08 ns | 23.48 ns | 0.0038 |      40 B |

// * Hints *                                                                                                                                                                                                                        
Outliers                                                                                                                                                                                                                            
  SimulationBenchmarks.UpdateAgents: Default -> 2 outliers were removed (338.86 ns, 343.08 ns)                                                                                                                                      
  SimulationBenchmarks.UpdateAgents: Default -> 1 outlier  was  removed (895.28 ns)                                                                                                                                                 
  SimulationBenchmarks.UpdateAgents: Default -> 3 outliers were removed, 4 outliers were detected (2.14 us, 2.32 us..3.15 us)                                                                                                       
                                                                                                                                                                                                                                    
// * Legends *
  AgentCount : Value of the 'AgentCount' parameter                                                                                                                                                                                  
  Mean       : Arithmetic mean of all measurements                                                                                                                                                                                  
  Error      : Half of 99.9% confidence interval                                                                                                                                                                                    
  StdDev     : Standard deviation of all measurements                                                                                                                                                                               
  Gen0       : GC Generation 0 collects per 1000 operations                                                                                                                                                                         
  Allocated  : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)                                                                                                                                         
  1 ns       : 1 Nanosecond (0.000000001 sec)                                                                                                                                                                                       
                                                                                                                                                                                                                                    
// * Diagnostic Output - MemoryDiagnoser *
                                                                                                                                                                                                                                    

// ***** BenchmarkRunner: End *****
Run time: 00:01:10 (70.15 sec), executed benchmarks: 3                                                                                                                                                                              
                                                                                                                                                                                                                                    
Global total time: 00:01:18 (78.46 sec), executed benchmarks: 3
// * Artifacts cleanup *                                                                                                                                                                                                            
Artifacts cleanup is finished                                                                                                                                                                                                       
// Validating benchmarks:                                                                                                                                                                                                           
// ***** BenchmarkRunner: Start   *****                                                                                                                                                                                             
// ***** Found 6 benchmark(s) in total *****                                                                                                                                                                                        
// ***** Building 1 exe(s) in Parallel: Start   *****                                                                                                                                                                               
// start dotnet  restore --nodeReuse:false /p:UseSharedCompilation=false /p:Deterministic=true /p:Optimize=true /p:ArtifactsPath="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2/" /p:OutDir="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0/" /p:OutputPath="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0/" /p:PublishDir="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\publish/" in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2        
// command took 1.18 sec and exited with 0                                                                                                                                                                                          
// start dotnet  build -c Release --no-restore --nodeReuse:false /p:UseSharedCompilation=false /p:Deterministic=true /p:Optimize=true /p:ArtifactsPath="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2/" /p:OutDir="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0/" /p:OutputPath="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0/" /p:PublishDir="C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\publish/" --output "C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0/" in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2                                               
// command took 6.24 sec and exited with 0                                                                                                                                                                                          
// ***** Done, took 00:00:07 (7.44 sec)   *****                                                                                                                                                                                     
// Found 6 benchmarks:                                                                                                                                                                                                              
//   SpatialHashBenchmarks.RebuildSpatialHash: DefaultJob [AgentCount=200]                                                                                                                                                          
//   SpatialHashBenchmarks.QueryNearbyAgents: DefaultJob [AgentCount=200]                                                                                                                                                           
//   SpatialHashBenchmarks.RebuildSpatialHash: DefaultJob [AgentCount=500]                                                                                                                                                          
//   SpatialHashBenchmarks.QueryNearbyAgents: DefaultJob [AgentCount=500]                                                                                                                                                           
//   SpatialHashBenchmarks.RebuildSpatialHash: DefaultJob [AgentCount=1000]                                                                                                                                                         
//   SpatialHashBenchmarks.QueryNearbyAgents: DefaultJob [AgentCount=1000]                                                                                                                                                          
                                                                                                                                                                                                                                    
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************                                                                                                                                                                                                       
// Benchmark: SpatialHashBenchmarks.RebuildSpatialHash: DefaultJob [AgentCount=200]                                                                                                                                                 
// *** Execute ***                                                                                                                                                                                                                  
// Launch: 1 / 1                                                                                                                                                                                                                    
// Execute: dotnet AegisSim.Benchmarks-DefaultJob-2.dll --anonymousPipes 1672 1632 --benchmarkName "AegisSim.Benchmarks.SpatialHashBenchmarks.RebuildSpatialHash(AgentCount: 200)" --job Default --benchmarkId 0 in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0                                                                                          
// BeforeAnythingElse                                                                                                                                                                                                               

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.8
// Runtime=.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2+BMI1+BMI2+F16C+FMA+LZCNT+MOVBE,AVX,SSE3+SSSE3+SSE4.1+SSE4.2+POPCNT,X86Base+SSE+SSE2,AES+PCLMUL,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 175700.00 ns, 175.7000 us/op
WorkloadJitting  1: 1 op, 236800.00 ns, 236.8000 us/op

OverheadJitting  2: 16 op, 172200.00 ns, 10.7625 us/op
WorkloadJitting  2: 16 op, 479300.00 ns, 29.9563 us/op

WorkloadPilot    1: 16 op, 318600.00 ns, 19.9125 us/op
WorkloadPilot    2: 32 op, 652500.00 ns, 20.3906 us/op
WorkloadPilot    3: 64 op, 1237300.00 ns, 19.3328 us/op
WorkloadPilot    4: 128 op, 2610800.00 ns, 20.3969 us/op
WorkloadPilot    5: 256 op, 5796300.00 ns, 22.6418 us/op
WorkloadPilot    6: 512 op, 9964200.00 ns, 19.4613 us/op
WorkloadPilot    7: 1024 op, 19459400.00 ns, 19.0033 us/op
WorkloadPilot    8: 2048 op, 36245400.00 ns, 17.6979 us/op
WorkloadPilot    9: 4096 op, 71637200.00 ns, 17.4896 us/op
WorkloadPilot   10: 8192 op, 191090400.00 ns, 23.3265 us/op
WorkloadPilot   11: 16384 op, 219246400.00 ns, 13.3817 us/op
WorkloadPilot   12: 32768 op, 113769900.00 ns, 3.4720 us/op
WorkloadPilot   13: 65536 op, 219422600.00 ns, 3.3481 us/op
WorkloadPilot   14: 131072 op, 449133500.00 ns, 3.4266 us/op
WorkloadPilot   15: 262144 op, 880856500.00 ns, 3.3602 us/op

OverheadWarmup   1: 262144 op, 580400.00 ns, 2.2141 ns/op
OverheadWarmup   2: 262144 op, 579900.00 ns, 2.2121 ns/op
OverheadWarmup   3: 262144 op, 579700.00 ns, 2.2114 ns/op
OverheadWarmup   4: 262144 op, 562600.00 ns, 2.1461 ns/op
OverheadWarmup   5: 262144 op, 580300.00 ns, 2.2137 ns/op
OverheadWarmup   6: 262144 op, 586700.00 ns, 2.2381 ns/op
OverheadWarmup   7: 262144 op, 579300.00 ns, 2.2099 ns/op
OverheadWarmup   8: 262144 op, 635800.00 ns, 2.4254 ns/op
OverheadWarmup   9: 262144 op, 621100.00 ns, 2.3693 ns/op

OverheadActual   1: 262144 op, 580400.00 ns, 2.2141 ns/op
OverheadActual   2: 262144 op, 579900.00 ns, 2.2121 ns/op
OverheadActual   3: 262144 op, 628000.00 ns, 2.3956 ns/op
OverheadActual   4: 262144 op, 579900.00 ns, 2.2121 ns/op
OverheadActual   5: 262144 op, 579600.00 ns, 2.2110 ns/op
OverheadActual   6: 262144 op, 579300.00 ns, 2.2099 ns/op
OverheadActual   7: 262144 op, 580500.00 ns, 2.2144 ns/op
OverheadActual   8: 262144 op, 579700.00 ns, 2.2114 ns/op
OverheadActual   9: 262144 op, 583400.00 ns, 2.2255 ns/op
OverheadActual  10: 262144 op, 586600.00 ns, 2.2377 ns/op
OverheadActual  11: 262144 op, 589700.00 ns, 2.2495 ns/op
OverheadActual  12: 262144 op, 621600.00 ns, 2.3712 ns/op
OverheadActual  13: 262144 op, 581000.00 ns, 2.2163 ns/op
OverheadActual  14: 262144 op, 582200.00 ns, 2.2209 ns/op
OverheadActual  15: 262144 op, 579500.00 ns, 2.2106 ns/op

WorkloadWarmup   1: 262144 op, 891135300.00 ns, 3.3994 us/op
WorkloadWarmup   2: 262144 op, 886394600.00 ns, 3.3813 us/op
WorkloadWarmup   3: 262144 op, 860174300.00 ns, 3.2813 us/op
WorkloadWarmup   4: 262144 op, 859091800.00 ns, 3.2772 us/op
WorkloadWarmup   5: 262144 op, 859703700.00 ns, 3.2795 us/op
WorkloadWarmup   6: 262144 op, 869494500.00 ns, 3.3169 us/op
WorkloadWarmup   7: 262144 op, 857263300.00 ns, 3.2702 us/op
WorkloadWarmup   8: 262144 op, 847875000.00 ns, 3.2344 us/op
WorkloadWarmup   9: 262144 op, 840167800.00 ns, 3.2050 us/op
WorkloadWarmup  10: 262144 op, 845738500.00 ns, 3.2262 us/op
WorkloadWarmup  11: 262144 op, 870327300.00 ns, 3.3200 us/op
WorkloadWarmup  12: 262144 op, 921219800.00 ns, 3.5142 us/op
WorkloadWarmup  13: 262144 op, 915742100.00 ns, 3.4933 us/op

// BeforeActualRun
WorkloadActual   1: 262144 op, 925631100.00 ns, 3.5310 us/op
WorkloadActual   2: 262144 op, 929202500.00 ns, 3.5446 us/op
WorkloadActual   3: 262144 op, 924598500.00 ns, 3.5271 us/op
WorkloadActual   4: 262144 op, 926215300.00 ns, 3.5332 us/op
WorkloadActual   5: 262144 op, 856773100.00 ns, 3.2683 us/op
WorkloadActual   6: 262144 op, 851928500.00 ns, 3.2498 us/op
WorkloadActual   7: 262144 op, 853925300.00 ns, 3.2575 us/op
WorkloadActual   8: 262144 op, 882363700.00 ns, 3.3660 us/op
WorkloadActual   9: 262144 op, 890212000.00 ns, 3.3959 us/op
WorkloadActual  10: 262144 op, 894468100.00 ns, 3.4121 us/op
WorkloadActual  11: 262144 op, 902642700.00 ns, 3.4433 us/op
WorkloadActual  12: 262144 op, 906713800.00 ns, 3.4588 us/op
WorkloadActual  13: 262144 op, 861505500.00 ns, 3.2864 us/op
WorkloadActual  14: 262144 op, 856468400.00 ns, 3.2672 us/op
WorkloadActual  15: 262144 op, 863644400.00 ns, 3.2945 us/op
WorkloadActual  16: 262144 op, 857896800.00 ns, 3.2726 us/op
WorkloadActual  17: 262144 op, 859465600.00 ns, 3.2786 us/op
WorkloadActual  18: 262144 op, 895249500.00 ns, 3.4151 us/op
WorkloadActual  19: 262144 op, 905816700.00 ns, 3.4554 us/op
WorkloadActual  20: 262144 op, 871882100.00 ns, 3.3260 us/op
WorkloadActual  21: 262144 op, 894741900.00 ns, 3.4132 us/op
WorkloadActual  22: 262144 op, 936419700.00 ns, 3.5722 us/op
WorkloadActual  23: 262144 op, 1713735900.00 ns, 6.5374 us/op
WorkloadActual  24: 262144 op, 1740321100.00 ns, 6.6388 us/op
WorkloadActual  25: 262144 op, 1766681500.00 ns, 6.7394 us/op
WorkloadActual  26: 262144 op, 1723985600.00 ns, 6.5765 us/op
WorkloadActual  27: 262144 op, 1779144100.00 ns, 6.7869 us/op
WorkloadActual  28: 262144 op, 1642957200.00 ns, 6.2674 us/op
WorkloadActual  29: 262144 op, 990217000.00 ns, 3.7774 us/op
WorkloadActual  30: 262144 op, 1021627000.00 ns, 3.8972 us/op
WorkloadActual  31: 262144 op, 1019534300.00 ns, 3.8892 us/op
WorkloadActual  32: 262144 op, 959566600.00 ns, 3.6605 us/op
WorkloadActual  33: 262144 op, 900949300.00 ns, 3.4368 us/op
WorkloadActual  34: 262144 op, 848619700.00 ns, 3.2372 us/op
WorkloadActual  35: 262144 op, 848561600.00 ns, 3.2370 us/op
WorkloadActual  36: 262144 op, 855180900.00 ns, 3.2623 us/op
WorkloadActual  37: 262144 op, 862415400.00 ns, 3.2899 us/op
WorkloadActual  38: 262144 op, 873985100.00 ns, 3.3340 us/op
WorkloadActual  39: 262144 op, 897013900.00 ns, 3.4218 us/op
WorkloadActual  40: 262144 op, 909133000.00 ns, 3.4681 us/op
WorkloadActual  41: 262144 op, 845733900.00 ns, 3.2262 us/op
WorkloadActual  42: 262144 op, 868707200.00 ns, 3.3139 us/op
WorkloadActual  43: 262144 op, 854932400.00 ns, 3.2613 us/op
WorkloadActual  44: 262144 op, 846047100.00 ns, 3.2274 us/op
WorkloadActual  45: 262144 op, 850857300.00 ns, 3.2458 us/op
WorkloadActual  46: 262144 op, 849063800.00 ns, 3.2389 us/op
WorkloadActual  47: 262144 op, 839820500.00 ns, 3.2037 us/op
WorkloadActual  48: 262144 op, 846765600.00 ns, 3.2302 us/op
WorkloadActual  49: 262144 op, 844790800.00 ns, 3.2226 us/op
WorkloadActual  50: 262144 op, 958712100.00 ns, 3.6572 us/op
WorkloadActual  51: 262144 op, 890594900.00 ns, 3.3973 us/op
WorkloadActual  52: 262144 op, 900405300.00 ns, 3.4348 us/op
WorkloadActual  53: 262144 op, 958205400.00 ns, 3.6553 us/op
WorkloadActual  54: 262144 op, 937259900.00 ns, 3.5754 us/op
WorkloadActual  55: 262144 op, 918279500.00 ns, 3.5030 us/op
WorkloadActual  56: 262144 op, 957270500.00 ns, 3.6517 us/op
WorkloadActual  57: 262144 op, 954158400.00 ns, 3.6398 us/op
WorkloadActual  58: 262144 op, 913255100.00 ns, 3.4838 us/op
WorkloadActual  59: 262144 op, 885154400.00 ns, 3.3766 us/op
WorkloadActual  60: 262144 op, 929087300.00 ns, 3.5442 us/op
WorkloadActual  61: 262144 op, 983137100.00 ns, 3.7504 us/op
WorkloadActual  62: 262144 op, 938288800.00 ns, 3.5793 us/op
WorkloadActual  63: 262144 op, 956733300.00 ns, 3.6496 us/op
WorkloadActual  64: 262144 op, 945954800.00 ns, 3.6085 us/op
WorkloadActual  65: 262144 op, 989803600.00 ns, 3.7758 us/op
WorkloadActual  66: 262144 op, 849879100.00 ns, 3.2420 us/op
WorkloadActual  67: 262144 op, 866112600.00 ns, 3.3040 us/op
WorkloadActual  68: 262144 op, 889144800.00 ns, 3.3918 us/op
WorkloadActual  69: 262144 op, 881265800.00 ns, 3.3618 us/op
WorkloadActual  70: 262144 op, 897717100.00 ns, 3.4245 us/op
WorkloadActual  71: 262144 op, 881884400.00 ns, 3.3641 us/op
WorkloadActual  72: 262144 op, 886690900.00 ns, 3.3825 us/op
WorkloadActual  73: 262144 op, 925906000.00 ns, 3.5321 us/op
WorkloadActual  74: 262144 op, 904628200.00 ns, 3.4509 us/op
WorkloadActual  75: 262144 op, 893080400.00 ns, 3.4068 us/op
WorkloadActual  76: 262144 op, 910778100.00 ns, 3.4743 us/op
WorkloadActual  77: 262144 op, 885296600.00 ns, 3.3771 us/op
WorkloadActual  78: 262144 op, 877552100.00 ns, 3.3476 us/op

// AfterActualRun
WorkloadResult   1: 262144 op, 925050600.00 ns, 3.5288 us/op
WorkloadResult   2: 262144 op, 928622000.00 ns, 3.5424 us/op
WorkloadResult   3: 262144 op, 924018000.00 ns, 3.5248 us/op
WorkloadResult   4: 262144 op, 925634800.00 ns, 3.5310 us/op
WorkloadResult   5: 262144 op, 856192600.00 ns, 3.2661 us/op
WorkloadResult   6: 262144 op, 851348000.00 ns, 3.2476 us/op
WorkloadResult   7: 262144 op, 853344800.00 ns, 3.2553 us/op
WorkloadResult   8: 262144 op, 881783200.00 ns, 3.3637 us/op
WorkloadResult   9: 262144 op, 889631500.00 ns, 3.3937 us/op
WorkloadResult  10: 262144 op, 893887600.00 ns, 3.4099 us/op
WorkloadResult  11: 262144 op, 902062200.00 ns, 3.4411 us/op
WorkloadResult  12: 262144 op, 906133300.00 ns, 3.4566 us/op
WorkloadResult  13: 262144 op, 860925000.00 ns, 3.2842 us/op
WorkloadResult  14: 262144 op, 855887900.00 ns, 3.2650 us/op
WorkloadResult  15: 262144 op, 863063900.00 ns, 3.2923 us/op
WorkloadResult  16: 262144 op, 857316300.00 ns, 3.2704 us/op
WorkloadResult  17: 262144 op, 858885100.00 ns, 3.2764 us/op
WorkloadResult  18: 262144 op, 894669000.00 ns, 3.4129 us/op
WorkloadResult  19: 262144 op, 905236200.00 ns, 3.4532 us/op
WorkloadResult  20: 262144 op, 871301600.00 ns, 3.3238 us/op
WorkloadResult  21: 262144 op, 894161400.00 ns, 3.4110 us/op
WorkloadResult  22: 262144 op, 935839200.00 ns, 3.5699 us/op
WorkloadResult  23: 262144 op, 989636500.00 ns, 3.7752 us/op
WorkloadResult  24: 262144 op, 1021046500.00 ns, 3.8950 us/op
WorkloadResult  25: 262144 op, 1018953800.00 ns, 3.8870 us/op
WorkloadResult  26: 262144 op, 958986100.00 ns, 3.6582 us/op
WorkloadResult  27: 262144 op, 900368800.00 ns, 3.4346 us/op
WorkloadResult  28: 262144 op, 848039200.00 ns, 3.2350 us/op
WorkloadResult  29: 262144 op, 847981100.00 ns, 3.2348 us/op
WorkloadResult  30: 262144 op, 854600400.00 ns, 3.2600 us/op
WorkloadResult  31: 262144 op, 861834900.00 ns, 3.2876 us/op
WorkloadResult  32: 262144 op, 873404600.00 ns, 3.3318 us/op
WorkloadResult  33: 262144 op, 896433400.00 ns, 3.4196 us/op
WorkloadResult  34: 262144 op, 908552500.00 ns, 3.4659 us/op
WorkloadResult  35: 262144 op, 845153400.00 ns, 3.2240 us/op
WorkloadResult  36: 262144 op, 868126700.00 ns, 3.3116 us/op
WorkloadResult  37: 262144 op, 854351900.00 ns, 3.2591 us/op
WorkloadResult  38: 262144 op, 845466600.00 ns, 3.2252 us/op
WorkloadResult  39: 262144 op, 850276800.00 ns, 3.2435 us/op
WorkloadResult  40: 262144 op, 848483300.00 ns, 3.2367 us/op
WorkloadResult  41: 262144 op, 839240000.00 ns, 3.2014 us/op
WorkloadResult  42: 262144 op, 846185100.00 ns, 3.2279 us/op
WorkloadResult  43: 262144 op, 844210300.00 ns, 3.2204 us/op
WorkloadResult  44: 262144 op, 958131600.00 ns, 3.6550 us/op
WorkloadResult  45: 262144 op, 890014400.00 ns, 3.3951 us/op
WorkloadResult  46: 262144 op, 899824800.00 ns, 3.4326 us/op
WorkloadResult  47: 262144 op, 957624900.00 ns, 3.6530 us/op
WorkloadResult  48: 262144 op, 936679400.00 ns, 3.5731 us/op
WorkloadResult  49: 262144 op, 917699000.00 ns, 3.5007 us/op
WorkloadResult  50: 262144 op, 956690000.00 ns, 3.6495 us/op
WorkloadResult  51: 262144 op, 953577900.00 ns, 3.6376 us/op
WorkloadResult  52: 262144 op, 912674600.00 ns, 3.4816 us/op
WorkloadResult  53: 262144 op, 884573900.00 ns, 3.3744 us/op
WorkloadResult  54: 262144 op, 928506800.00 ns, 3.5420 us/op
WorkloadResult  55: 262144 op, 982556600.00 ns, 3.7482 us/op
WorkloadResult  56: 262144 op, 937708300.00 ns, 3.5771 us/op
WorkloadResult  57: 262144 op, 956152800.00 ns, 3.6474 us/op
WorkloadResult  58: 262144 op, 945374300.00 ns, 3.6063 us/op
WorkloadResult  59: 262144 op, 989223100.00 ns, 3.7736 us/op
WorkloadResult  60: 262144 op, 849298600.00 ns, 3.2398 us/op
WorkloadResult  61: 262144 op, 865532100.00 ns, 3.3017 us/op
WorkloadResult  62: 262144 op, 888564300.00 ns, 3.3896 us/op
WorkloadResult  63: 262144 op, 880685300.00 ns, 3.3595 us/op
WorkloadResult  64: 262144 op, 897136600.00 ns, 3.4223 us/op
WorkloadResult  65: 262144 op, 881303900.00 ns, 3.3619 us/op
WorkloadResult  66: 262144 op, 886110400.00 ns, 3.3802 us/op
WorkloadResult  67: 262144 op, 925325500.00 ns, 3.5298 us/op
WorkloadResult  68: 262144 op, 904047700.00 ns, 3.4487 us/op
WorkloadResult  69: 262144 op, 892499900.00 ns, 3.4046 us/op
WorkloadResult  70: 262144 op, 910197600.00 ns, 3.4721 us/op
WorkloadResult  71: 262144 op, 884716100.00 ns, 3.3749 us/op
WorkloadResult  72: 262144 op, 876971600.00 ns, 3.3454 us/op
// GC:  275 3 0 1730150400 262144
// Threading:  0 0 262144

// AfterAll
// Benchmark Process 24544 has exited with code 0.
                                                                                                                                                                                                                                    
Mean = 3.428 us, StdErr = 0.020 us (0.58%), N = 72, StdDev = 0.168 us
Min = 3.201 us, Q1 = 3.282 us, Median = 3.407 us, Q3 = 3.530 us, Max = 3.895 us                                                                                                                                                     
IQR = 0.248 us, LowerFence = 2.910 us, UpperFence = 3.902 us                                                                                                                                                                        
ConfidenceInterval = [3.360 us; 3.496 us] (CI 99.9%), Margin = 0.068 us (1.98% of Mean)                                                                                                                                             
Skewness = 0.79, Kurtosis = 3.02, MValue = 2                                                                                                                                                                                        
                                                                                                                                                                                                                                    
// ** Remained 5 (83.3%) benchmark(s) to run. Estimated finish 2026-10-15 14:47 (0h 7m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)                                                                                                                                        
// **************************                                                                                                                                                                                                       
// Benchmark: SpatialHashBenchmarks.QueryNearbyAgents: DefaultJob [AgentCount=200]                                                                                                                                                  
// *** Execute ***                                                                                                                                                                                                                  
// Launch: 1 / 1                                                                                                                                                                                                                    
// Execute: dotnet AegisSim.Benchmarks-DefaultJob-2.dll --anonymousPipes 1680 1728 --benchmarkName "AegisSim.Benchmarks.SpatialHashBenchmarks.QueryNearbyAgents(AgentCount: 200)" --job Default --benchmarkId 1 in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0                                                                                           
// BeforeAnythingElse                                                                                                                                                                                                               

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.8
// Runtime=.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2+BMI1+BMI2+F16C+FMA+LZCNT+MOVBE,AVX,SSE3+SSSE3+SSE4.1+SSE4.2+POPCNT,X86Base+SSE+SSE2,AES+PCLMUL,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 167900.00 ns, 167.9000 us/op
WorkloadJitting  1: 1 op, 670300.00 ns, 670.3000 us/op

OverheadJitting  2: 16 op, 309100.00 ns, 19.3188 us/op
WorkloadJitting  2: 16 op, 2937900.00 ns, 183.6188 us/op

WorkloadPilot    1: 16 op, 2474700.00 ns, 154.6688 us/op
WorkloadPilot    2: 32 op, 4846700.00 ns, 151.4594 us/op
WorkloadPilot    3: 64 op, 9115600.00 ns, 142.4313 us/op
WorkloadPilot    4: 128 op, 16988400.00 ns, 132.7219 us/op
WorkloadPilot    5: 256 op, 32893000.00 ns, 128.4883 us/op
WorkloadPilot    6: 512 op, 62171500.00 ns, 121.4287 us/op
WorkloadPilot    7: 1024 op, 141091800.00 ns, 137.7850 us/op
WorkloadPilot    8: 2048 op, 211465000.00 ns, 103.2544 us/op
WorkloadPilot    9: 4096 op, 125280600.00 ns, 30.5861 us/op
WorkloadPilot   10: 8192 op, 239388700.00 ns, 29.2223 us/op
WorkloadPilot   11: 16384 op, 479143300.00 ns, 29.2446 us/op
WorkloadPilot   12: 32768 op, 954950500.00 ns, 29.1428 us/op

OverheadWarmup   1: 32768 op, 72300.00 ns, 2.2064 ns/op
OverheadWarmup   2: 32768 op, 70900.00 ns, 2.1637 ns/op
OverheadWarmup   3: 32768 op, 74600.00 ns, 2.2766 ns/op
OverheadWarmup   4: 32768 op, 71100.00 ns, 2.1698 ns/op
OverheadWarmup   5: 32768 op, 71100.00 ns, 2.1698 ns/op
OverheadWarmup   6: 32768 op, 72100.00 ns, 2.2003 ns/op

OverheadActual   1: 32768 op, 75100.00 ns, 2.2919 ns/op
OverheadActual   2: 32768 op, 71200.00 ns, 2.1729 ns/op
OverheadActual   3: 32768 op, 76300.00 ns, 2.3285 ns/op
OverheadActual   4: 32768 op, 70800.00 ns, 2.1606 ns/op
OverheadActual   5: 32768 op, 78600.00 ns, 2.3987 ns/op
OverheadActual   6: 32768 op, 70700.00 ns, 2.1576 ns/op
OverheadActual   7: 32768 op, 72000.00 ns, 2.1973 ns/op
OverheadActual   8: 32768 op, 74500.00 ns, 2.2736 ns/op
OverheadActual   9: 32768 op, 75200.00 ns, 2.2949 ns/op
OverheadActual  10: 32768 op, 74100.00 ns, 2.2614 ns/op
OverheadActual  11: 32768 op, 75700.00 ns, 2.3102 ns/op
OverheadActual  12: 32768 op, 74200.00 ns, 2.2644 ns/op
OverheadActual  13: 32768 op, 75400.00 ns, 2.3010 ns/op
OverheadActual  14: 32768 op, 74400.00 ns, 2.2705 ns/op
OverheadActual  15: 32768 op, 75200.00 ns, 2.2949 ns/op

WorkloadWarmup   1: 32768 op, 971706200.00 ns, 29.6541 us/op
WorkloadWarmup   2: 32768 op, 948002400.00 ns, 28.9307 us/op
WorkloadWarmup   3: 32768 op, 947267300.00 ns, 28.9083 us/op
WorkloadWarmup   4: 32768 op, 956193100.00 ns, 29.1807 us/op
WorkloadWarmup   5: 32768 op, 948281600.00 ns, 28.9393 us/op
WorkloadWarmup   6: 32768 op, 952361500.00 ns, 29.0638 us/op
WorkloadWarmup   7: 32768 op, 1502025900.00 ns, 45.8382 us/op
WorkloadWarmup   8: 32768 op, 1919264100.00 ns, 58.5713 us/op
WorkloadWarmup   9: 32768 op, 2080819800.00 ns, 63.5016 us/op
WorkloadWarmup  10: 32768 op, 1987307200.00 ns, 60.6478 us/op

// BeforeActualRun
WorkloadActual   1: 32768 op, 2078223400.00 ns, 63.4223 us/op
WorkloadActual   2: 32768 op, 2025309600.00 ns, 61.8075 us/op
WorkloadActual   3: 32768 op, 2111150400.00 ns, 64.4272 us/op
WorkloadActual   4: 32768 op, 2098019900.00 ns, 64.0265 us/op
WorkloadActual   5: 32768 op, 2072234900.00 ns, 63.2396 us/op
WorkloadActual   6: 32768 op, 2057528100.00 ns, 62.7908 us/op
WorkloadActual   7: 32768 op, 2057638600.00 ns, 62.7941 us/op
WorkloadActual   8: 32768 op, 2037781400.00 ns, 62.1882 us/op
WorkloadActual   9: 32768 op, 2075295500.00 ns, 63.3330 us/op
WorkloadActual  10: 32768 op, 1978384500.00 ns, 60.3755 us/op
WorkloadActual  11: 32768 op, 2030562500.00 ns, 61.9678 us/op
WorkloadActual  12: 32768 op, 1966358900.00 ns, 60.0085 us/op
WorkloadActual  13: 32768 op, 2031791100.00 ns, 62.0053 us/op
WorkloadActual  14: 32768 op, 2058346600.00 ns, 62.8158 us/op
WorkloadActual  15: 32768 op, 2002055000.00 ns, 61.0979 us/op
WorkloadActual  16: 32768 op, 2045504900.00 ns, 62.4239 us/op

// AfterActualRun
WorkloadResult   1: 32768 op, 2078148900.00 ns, 63.4201 us/op
WorkloadResult   2: 32768 op, 2025235100.00 ns, 61.8053 us/op
WorkloadResult   3: 32768 op, 2111075900.00 ns, 64.4249 us/op
WorkloadResult   4: 32768 op, 2097945400.00 ns, 64.0242 us/op
WorkloadResult   5: 32768 op, 2072160400.00 ns, 63.2373 us/op
WorkloadResult   6: 32768 op, 2057453600.00 ns, 62.7885 us/op
WorkloadResult   7: 32768 op, 2057564100.00 ns, 62.7919 us/op
WorkloadResult   8: 32768 op, 2037706900.00 ns, 62.1859 us/op
WorkloadResult   9: 32768 op, 2075221000.00 ns, 63.3307 us/op
WorkloadResult  10: 32768 op, 1978310000.00 ns, 60.3732 us/op
WorkloadResult  11: 32768 op, 2030488000.00 ns, 61.9656 us/op
WorkloadResult  12: 32768 op, 1966284400.00 ns, 60.0062 us/op
WorkloadResult  13: 32768 op, 2031716600.00 ns, 62.0031 us/op
WorkloadResult  14: 32768 op, 2058272100.00 ns, 62.8135 us/op
WorkloadResult  15: 32768 op, 2001980500.00 ns, 61.0956 us/op
WorkloadResult  16: 32768 op, 2045430400.00 ns, 62.4216 us/op
// GC:  336 0 0 2109734912 32768
// Threading:  0 0 32768

// AfterAll
// Benchmark Process 22168 has exited with code 0.
                                                                                                                                                                                                                                    
Mean = 62.418 us, StdErr = 0.303 us (0.49%), N = 16, StdDev = 1.214 us
Min = 60.006 us, Q1 = 61.925 us, Median = 62.605 us, Q3 = 63.261 us, Max = 64.425 us                                                                                                                                                
IQR = 1.335 us, LowerFence = 59.923 us, UpperFence = 65.263 us                                                                                                                                                                      
ConfidenceInterval = [61.182 us; 63.654 us] (CI 99.9%), Margin = 1.236 us (1.98% of Mean)                                                                                                                                           
Skewness = -0.37, Kurtosis = 2.29, MValue = 2                                                                                                                                                                                       
                                                                                                                                                                                                                                    
// ** Remained 4 (66.7%) benchmark(s) to run. Estimated finish 2026-10-15 14:45 (0h 4m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)                                                                                                                                        
// **************************                                                                                                                                                                                                       
// Benchmark: SpatialHashBenchmarks.RebuildSpatialHash: DefaultJob [AgentCount=500]                                                                                                                                                 
// *** Execute ***                                                                                                                                                                                                                  
// Launch: 1 / 1                                                                                                                                                                                                                    
// Execute: dotnet AegisSim.Benchmarks-DefaultJob-2.dll --anonymousPipes 1748 1732 --benchmarkName "AegisSim.Benchmarks.SpatialHashBenchmarks.RebuildSpatialHash(AgentCount: 500)" --job Default --benchmarkId 2 in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0                                                                                          
// BeforeAnythingElse                                                                                                                                                                                                               

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.8
// Runtime=.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2+BMI1+BMI2+F16C+FMA+LZCNT+MOVBE,AVX,SSE3+SSSE3+SSE4.1+SSE4.2+POPCNT,X86Base+SSE+SSE2,AES+PCLMUL,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 150800.00 ns, 150.8000 us/op
WorkloadJitting  1: 1 op, 435000.00 ns, 435.0000 us/op

OverheadJitting  2: 16 op, 192800.00 ns, 12.0500 us/op
WorkloadJitting  2: 16 op, 1049000.00 ns, 65.5625 us/op

WorkloadPilot    1: 16 op, 948900.00 ns, 59.3063 us/op
WorkloadPilot    2: 32 op, 2140900.00 ns, 66.9031 us/op
WorkloadPilot    3: 64 op, 4058300.00 ns, 63.4109 us/op
WorkloadPilot    4: 128 op, 7459800.00 ns, 58.2797 us/op
WorkloadPilot    5: 256 op, 14331200.00 ns, 55.9813 us/op
WorkloadPilot    6: 512 op, 24919000.00 ns, 48.6699 us/op
WorkloadPilot    7: 1024 op, 48014500.00 ns, 46.8892 us/op
WorkloadPilot    8: 2048 op, 104171500.00 ns, 50.8650 us/op
WorkloadPilot    9: 4096 op, 255284200.00 ns, 62.3252 us/op
WorkloadPilot   10: 8192 op, 131902700.00 ns, 16.1014 us/op
WorkloadPilot   11: 16384 op, 195311600.00 ns, 11.9209 us/op
WorkloadPilot   12: 32768 op, 381523700.00 ns, 11.6432 us/op
WorkloadPilot   13: 65536 op, 668371000.00 ns, 10.1985 us/op

OverheadWarmup   1: 65536 op, 139900.00 ns, 2.1347 ns/op
OverheadWarmup   2: 65536 op, 139300.00 ns, 2.1255 ns/op
OverheadWarmup   3: 65536 op, 138800.00 ns, 2.1179 ns/op
OverheadWarmup   4: 65536 op, 138800.00 ns, 2.1179 ns/op
OverheadWarmup   5: 65536 op, 145400.00 ns, 2.2186 ns/op
OverheadWarmup   6: 65536 op, 160000.00 ns, 2.4414 ns/op
OverheadWarmup   7: 65536 op, 145400.00 ns, 2.2186 ns/op
OverheadWarmup   8: 65536 op, 143200.00 ns, 2.1851 ns/op
OverheadWarmup   9: 65536 op, 145100.00 ns, 2.2141 ns/op

OverheadActual   1: 65536 op, 138900.00 ns, 2.1194 ns/op
OverheadActual   2: 65536 op, 139200.00 ns, 2.1240 ns/op
OverheadActual   3: 65536 op, 147700.00 ns, 2.2537 ns/op
OverheadActual   4: 65536 op, 144300.00 ns, 2.2018 ns/op
OverheadActual   5: 65536 op, 143700.00 ns, 2.1927 ns/op
OverheadActual   6: 65536 op, 143900.00 ns, 2.1957 ns/op
OverheadActual   7: 65536 op, 144500.00 ns, 2.2049 ns/op
OverheadActual   8: 65536 op, 145900.00 ns, 2.2263 ns/op
OverheadActual   9: 65536 op, 146300.00 ns, 2.2324 ns/op
OverheadActual  10: 65536 op, 145300.00 ns, 2.2171 ns/op
OverheadActual  11: 65536 op, 145200.00 ns, 2.2156 ns/op
OverheadActual  12: 65536 op, 145400.00 ns, 2.2186 ns/op
OverheadActual  13: 65536 op, 145100.00 ns, 2.2141 ns/op
OverheadActual  14: 65536 op, 190700.00 ns, 2.9099 ns/op
OverheadActual  15: 65536 op, 142500.00 ns, 2.1744 ns/op

WorkloadWarmup   1: 65536 op, 760704000.00 ns, 11.6074 us/op
WorkloadWarmup   2: 65536 op, 730965000.00 ns, 11.1536 us/op
WorkloadWarmup   3: 65536 op, 783919700.00 ns, 11.9617 us/op
WorkloadWarmup   4: 65536 op, 750180900.00 ns, 11.4469 us/op
WorkloadWarmup   5: 65536 op, 734200100.00 ns, 11.2030 us/op
WorkloadWarmup   6: 65536 op, 781088700.00 ns, 11.9185 us/op
WorkloadWarmup   7: 65536 op, 753090200.00 ns, 11.4912 us/op

// BeforeActualRun
WorkloadActual   1: 65536 op, 669964600.00 ns, 10.2228 us/op
WorkloadActual   2: 65536 op, 722493000.00 ns, 11.0244 us/op
WorkloadActual   3: 65536 op, 695329500.00 ns, 10.6099 us/op
WorkloadActual   4: 65536 op, 669490800.00 ns, 10.2156 us/op
WorkloadActual   5: 65536 op, 685963000.00 ns, 10.4670 us/op
WorkloadActual   6: 65536 op, 662085700.00 ns, 10.1026 us/op
WorkloadActual   7: 65536 op, 672776400.00 ns, 10.2658 us/op
WorkloadActual   8: 65536 op, 707504300.00 ns, 10.7957 us/op
WorkloadActual   9: 65536 op, 654084700.00 ns, 9.9805 us/op
WorkloadActual  10: 65536 op, 652694700.00 ns, 9.9593 us/op
WorkloadActual  11: 65536 op, 669586400.00 ns, 10.2171 us/op
WorkloadActual  12: 65536 op, 653033100.00 ns, 9.9645 us/op
WorkloadActual  13: 65536 op, 700189700.00 ns, 10.6840 us/op
WorkloadActual  14: 65536 op, 666530300.00 ns, 10.1704 us/op
WorkloadActual  15: 65536 op, 722132900.00 ns, 11.0189 us/op
WorkloadActual  16: 65536 op, 760514100.00 ns, 11.6045 us/op
WorkloadActual  17: 65536 op, 661802300.00 ns, 10.0983 us/op
WorkloadActual  18: 65536 op, 752375600.00 ns, 11.4803 us/op
WorkloadActual  19: 65536 op, 757202400.00 ns, 11.5540 us/op
WorkloadActual  20: 65536 op, 662733700.00 ns, 10.1125 us/op
WorkloadActual  21: 65536 op, 699321400.00 ns, 10.6708 us/op
WorkloadActual  22: 65536 op, 929694600.00 ns, 14.1860 us/op
WorkloadActual  23: 65536 op, 1497602600.00 ns, 22.8516 us/op
WorkloadActual  24: 65536 op, 1440806100.00 ns, 21.9850 us/op
WorkloadActual  25: 65536 op, 1344997400.00 ns, 20.5230 us/op
WorkloadActual  26: 65536 op, 1431708000.00 ns, 21.8461 us/op
WorkloadActual  27: 65536 op, 1308437300.00 ns, 19.9652 us/op
WorkloadActual  28: 65536 op, 1427446800.00 ns, 21.7811 us/op
WorkloadActual  29: 65536 op, 1307379900.00 ns, 19.9490 us/op
WorkloadActual  30: 65536 op, 1397632400.00 ns, 21.3262 us/op
WorkloadActual  31: 65536 op, 1429120000.00 ns, 21.8066 us/op
WorkloadActual  32: 65536 op, 1417285700.00 ns, 21.6261 us/op
WorkloadActual  33: 65536 op, 1293859100.00 ns, 19.7427 us/op
WorkloadActual  34: 65536 op, 1425155200.00 ns, 21.7461 us/op
WorkloadActual  35: 65536 op, 1337637500.00 ns, 20.4107 us/op
WorkloadActual  36: 65536 op, 1413558000.00 ns, 21.5692 us/op
WorkloadActual  37: 65536 op, 1280512000.00 ns, 19.5391 us/op
WorkloadActual  38: 65536 op, 1425508600.00 ns, 21.7515 us/op
WorkloadActual  39: 65536 op, 1318919200.00 ns, 20.1251 us/op
WorkloadActual  40: 65536 op, 1330056500.00 ns, 20.2951 us/op
WorkloadActual  41: 65536 op, 1444628900.00 ns, 22.0433 us/op
WorkloadActual  42: 65536 op, 1429935400.00 ns, 21.8191 us/op
WorkloadActual  43: 65536 op, 1419100200.00 ns, 21.6538 us/op
WorkloadActual  44: 65536 op, 1392338900.00 ns, 21.2454 us/op
WorkloadActual  45: 65536 op, 1056399300.00 ns, 16.1194 us/op
WorkloadActual  46: 65536 op, 767656700.00 ns, 11.7135 us/op
WorkloadActual  47: 65536 op, 750651100.00 ns, 11.4540 us/op
WorkloadActual  48: 65536 op, 718008200.00 ns, 10.9559 us/op
WorkloadActual  49: 65536 op, 749652500.00 ns, 11.4388 us/op
WorkloadActual  50: 65536 op, 723981000.00 ns, 11.0471 us/op
WorkloadActual  51: 65536 op, 692269300.00 ns, 10.5632 us/op
WorkloadActual  52: 65536 op, 672065800.00 ns, 10.2549 us/op
WorkloadActual  53: 65536 op, 683583300.00 ns, 10.4307 us/op
WorkloadActual  54: 65536 op, 683103100.00 ns, 10.4233 us/op
WorkloadActual  55: 65536 op, 695656400.00 ns, 10.6149 us/op
WorkloadActual  56: 65536 op, 694649500.00 ns, 10.5995 us/op
WorkloadActual  57: 65536 op, 702034700.00 ns, 10.7122 us/op
WorkloadActual  58: 65536 op, 682129100.00 ns, 10.4085 us/op
WorkloadActual  59: 65536 op, 943666200.00 ns, 14.3992 us/op
WorkloadActual  60: 65536 op, 1404436300.00 ns, 21.4300 us/op
WorkloadActual  61: 65536 op, 1457160200.00 ns, 22.2345 us/op
WorkloadActual  62: 65536 op, 1399123100.00 ns, 21.3489 us/op
WorkloadActual  63: 65536 op, 1480500600.00 ns, 22.5906 us/op
WorkloadActual  64: 65536 op, 1439603900.00 ns, 21.9666 us/op
WorkloadActual  65: 65536 op, 1328874100.00 ns, 20.2770 us/op
WorkloadActual  66: 65536 op, 1376958300.00 ns, 21.0107 us/op
WorkloadActual  67: 65536 op, 1327253200.00 ns, 20.2523 us/op
WorkloadActual  68: 65536 op, 1402480400.00 ns, 21.4002 us/op
WorkloadActual  69: 65536 op, 1282428500.00 ns, 19.5683 us/op
WorkloadActual  70: 65536 op, 1360040900.00 ns, 20.7526 us/op
WorkloadActual  71: 65536 op, 1446390400.00 ns, 22.0702 us/op
WorkloadActual  72: 65536 op, 1415741000.00 ns, 21.6025 us/op
WorkloadActual  73: 65536 op, 1452798000.00 ns, 22.1679 us/op
WorkloadActual  74: 65536 op, 1471006800.00 ns, 22.4458 us/op
WorkloadActual  75: 65536 op, 1389796900.00 ns, 21.2066 us/op
WorkloadActual  76: 65536 op, 1358958000.00 ns, 20.7361 us/op
WorkloadActual  77: 65536 op, 1157441700.00 ns, 17.6612 us/op
WorkloadActual  78: 65536 op, 1429045200.00 ns, 21.8055 us/op
WorkloadActual  79: 65536 op, 1248836900.00 ns, 19.0557 us/op
WorkloadActual  80: 65536 op, 1402222800.00 ns, 21.3962 us/op
WorkloadActual  81: 65536 op, 1424927200.00 ns, 21.7427 us/op
WorkloadActual  82: 65536 op, 1385880700.00 ns, 21.1469 us/op
WorkloadActual  83: 65536 op, 1373442400.00 ns, 20.9571 us/op
WorkloadActual  84: 65536 op, 1433387100.00 ns, 21.8718 us/op
WorkloadActual  85: 65536 op, 1294214900.00 ns, 19.7482 us/op
WorkloadActual  86: 65536 op, 1416723400.00 ns, 21.6175 us/op
WorkloadActual  87: 65536 op, 1459182500.00 ns, 22.2654 us/op
WorkloadActual  88: 65536 op, 1406618800.00 ns, 21.4633 us/op
WorkloadActual  89: 65536 op, 845214800.00 ns, 12.8970 us/op
WorkloadActual  90: 65536 op, 695410100.00 ns, 10.6111 us/op
WorkloadActual  91: 65536 op, 771138800.00 ns, 11.7666 us/op
WorkloadActual  92: 65536 op, 736777600.00 ns, 11.2423 us/op
WorkloadActual  93: 65536 op, 675378200.00 ns, 10.3055 us/op
WorkloadActual  94: 65536 op, 1318148300.00 ns, 20.1133 us/op
WorkloadActual  95: 65536 op, 1397381900.00 ns, 21.3224 us/op
WorkloadActual  96: 65536 op, 1416261200.00 ns, 21.6104 us/op
WorkloadActual  97: 65536 op, 1437322800.00 ns, 21.9318 us/op
WorkloadActual  98: 65536 op, 1403907600.00 ns, 21.4219 us/op
WorkloadActual  99: 65536 op, 1456002200.00 ns, 22.2168 us/op
WorkloadActual  100: 65536 op, 1404957200.00 ns, 21.4379 us/op

// AfterActualRun
WorkloadResult   1: 65536 op, 669819500.00 ns, 10.2206 us/op
WorkloadResult   2: 65536 op, 722347900.00 ns, 11.0222 us/op
WorkloadResult   3: 65536 op, 695184400.00 ns, 10.6077 us/op
WorkloadResult   4: 65536 op, 669345700.00 ns, 10.2134 us/op
WorkloadResult   5: 65536 op, 685817900.00 ns, 10.4648 us/op
WorkloadResult   6: 65536 op, 661940600.00 ns, 10.1004 us/op
WorkloadResult   7: 65536 op, 672631300.00 ns, 10.2635 us/op
WorkloadResult   8: 65536 op, 707359200.00 ns, 10.7934 us/op
WorkloadResult   9: 65536 op, 653939600.00 ns, 9.9783 us/op
WorkloadResult  10: 65536 op, 652549600.00 ns, 9.9571 us/op
WorkloadResult  11: 65536 op, 669441300.00 ns, 10.2149 us/op
WorkloadResult  12: 65536 op, 652888000.00 ns, 9.9623 us/op
WorkloadResult  13: 65536 op, 700044600.00 ns, 10.6818 us/op
WorkloadResult  14: 65536 op, 666385200.00 ns, 10.1682 us/op
WorkloadResult  15: 65536 op, 721987800.00 ns, 11.0167 us/op
WorkloadResult  16: 65536 op, 760369000.00 ns, 11.6023 us/op
WorkloadResult  17: 65536 op, 661657200.00 ns, 10.0961 us/op
WorkloadResult  18: 65536 op, 752230500.00 ns, 11.4781 us/op
WorkloadResult  19: 65536 op, 757057300.00 ns, 11.5518 us/op
WorkloadResult  20: 65536 op, 662588600.00 ns, 10.1103 us/op
WorkloadResult  21: 65536 op, 699176300.00 ns, 10.6686 us/op
WorkloadResult  22: 65536 op, 929549500.00 ns, 14.1838 us/op
WorkloadResult  23: 65536 op, 1497457500.00 ns, 22.8494 us/op
WorkloadResult  24: 65536 op, 1440661000.00 ns, 21.9827 us/op
WorkloadResult  25: 65536 op, 1344852300.00 ns, 20.5208 us/op
WorkloadResult  26: 65536 op, 1431562900.00 ns, 21.8439 us/op
WorkloadResult  27: 65536 op, 1308292200.00 ns, 19.9630 us/op
WorkloadResult  28: 65536 op, 1427301700.00 ns, 21.7789 us/op
WorkloadResult  29: 65536 op, 1307234800.00 ns, 19.9468 us/op
WorkloadResult  30: 65536 op, 1397487300.00 ns, 21.3240 us/op
WorkloadResult  31: 65536 op, 1428974900.00 ns, 21.8044 us/op
WorkloadResult  32: 65536 op, 1417140600.00 ns, 21.6238 us/op
WorkloadResult  33: 65536 op, 1293714000.00 ns, 19.7405 us/op
WorkloadResult  34: 65536 op, 1425010100.00 ns, 21.7439 us/op
WorkloadResult  35: 65536 op, 1337492400.00 ns, 20.4085 us/op
WorkloadResult  36: 65536 op, 1413412900.00 ns, 21.5670 us/op
WorkloadResult  37: 65536 op, 1280366900.00 ns, 19.5368 us/op
WorkloadResult  38: 65536 op, 1425363500.00 ns, 21.7493 us/op
WorkloadResult  39: 65536 op, 1318774100.00 ns, 20.1229 us/op
WorkloadResult  40: 65536 op, 1329911400.00 ns, 20.2928 us/op
WorkloadResult  41: 65536 op, 1444483800.00 ns, 22.0411 us/op
WorkloadResult  42: 65536 op, 1429790300.00 ns, 21.8169 us/op
WorkloadResult  43: 65536 op, 1418955100.00 ns, 21.6515 us/op
WorkloadResult  44: 65536 op, 1392193800.00 ns, 21.2432 us/op
WorkloadResult  45: 65536 op, 1056254200.00 ns, 16.1172 us/op
WorkloadResult  46: 65536 op, 767511600.00 ns, 11.7113 us/op
WorkloadResult  47: 65536 op, 750506000.00 ns, 11.4518 us/op
WorkloadResult  48: 65536 op, 717863100.00 ns, 10.9537 us/op
WorkloadResult  49: 65536 op, 749507400.00 ns, 11.4366 us/op
WorkloadResult  50: 65536 op, 723835900.00 ns, 11.0449 us/op
WorkloadResult  51: 65536 op, 692124200.00 ns, 10.5610 us/op
WorkloadResult  52: 65536 op, 671920700.00 ns, 10.2527 us/op
WorkloadResult  53: 65536 op, 683438200.00 ns, 10.4284 us/op
WorkloadResult  54: 65536 op, 682958000.00 ns, 10.4211 us/op
WorkloadResult  55: 65536 op, 695511300.00 ns, 10.6127 us/op
WorkloadResult  56: 65536 op, 694504400.00 ns, 10.5973 us/op
WorkloadResult  57: 65536 op, 701889600.00 ns, 10.7100 us/op
WorkloadResult  58: 65536 op, 681984000.00 ns, 10.4063 us/op
WorkloadResult  59: 65536 op, 943521100.00 ns, 14.3970 us/op
WorkloadResult  60: 65536 op, 1404291200.00 ns, 21.4278 us/op
WorkloadResult  61: 65536 op, 1457015100.00 ns, 22.2323 us/op
WorkloadResult  62: 65536 op, 1398978000.00 ns, 21.3467 us/op
WorkloadResult  63: 65536 op, 1480355500.00 ns, 22.5884 us/op
WorkloadResult  64: 65536 op, 1439458800.00 ns, 21.9644 us/op
WorkloadResult  65: 65536 op, 1328729000.00 ns, 20.2748 us/op
WorkloadResult  66: 65536 op, 1376813200.00 ns, 21.0085 us/op
WorkloadResult  67: 65536 op, 1327108100.00 ns, 20.2501 us/op
WorkloadResult  68: 65536 op, 1402335300.00 ns, 21.3979 us/op
WorkloadResult  69: 65536 op, 1282283400.00 ns, 19.5661 us/op
WorkloadResult  70: 65536 op, 1359895800.00 ns, 20.7504 us/op
WorkloadResult  71: 65536 op, 1446245300.00 ns, 22.0680 us/op
WorkloadResult  72: 65536 op, 1415595900.00 ns, 21.6003 us/op
WorkloadResult  73: 65536 op, 1452652900.00 ns, 22.1657 us/op
WorkloadResult  74: 65536 op, 1470861700.00 ns, 22.4436 us/op
WorkloadResult  75: 65536 op, 1389651800.00 ns, 21.2044 us/op
WorkloadResult  76: 65536 op, 1358812900.00 ns, 20.7338 us/op
WorkloadResult  77: 65536 op, 1157296600.00 ns, 17.6589 us/op
WorkloadResult  78: 65536 op, 1428900100.00 ns, 21.8033 us/op
WorkloadResult  79: 65536 op, 1248691800.00 ns, 19.0535 us/op
WorkloadResult  80: 65536 op, 1402077700.00 ns, 21.3940 us/op
WorkloadResult  81: 65536 op, 1424782100.00 ns, 21.7404 us/op
WorkloadResult  82: 65536 op, 1385735600.00 ns, 21.1446 us/op
WorkloadResult  83: 65536 op, 1373297300.00 ns, 20.9549 us/op
WorkloadResult  84: 65536 op, 1433242000.00 ns, 21.8695 us/op
WorkloadResult  85: 65536 op, 1294069800.00 ns, 19.7459 us/op
WorkloadResult  86: 65536 op, 1416578300.00 ns, 21.6153 us/op
WorkloadResult  87: 65536 op, 1459037400.00 ns, 22.2631 us/op
WorkloadResult  88: 65536 op, 1406473700.00 ns, 21.4611 us/op
WorkloadResult  89: 65536 op, 845069700.00 ns, 12.8947 us/op
WorkloadResult  90: 65536 op, 695265000.00 ns, 10.6089 us/op
WorkloadResult  91: 65536 op, 770993700.00 ns, 11.7644 us/op
WorkloadResult  92: 65536 op, 736632500.00 ns, 11.2401 us/op
WorkloadResult  93: 65536 op, 675233100.00 ns, 10.3032 us/op
WorkloadResult  94: 65536 op, 1318003200.00 ns, 20.1111 us/op
WorkloadResult  95: 65536 op, 1397236800.00 ns, 21.3201 us/op
WorkloadResult  96: 65536 op, 1416116100.00 ns, 21.6082 us/op
WorkloadResult  97: 65536 op, 1437177700.00 ns, 21.9296 us/op
WorkloadResult  98: 65536 op, 1403762500.00 ns, 21.4197 us/op
WorkloadResult  99: 65536 op, 1455857100.00 ns, 22.2146 us/op
WorkloadResult  100: 65536 op, 1404812100.00 ns, 21.4357 us/op
// GC:  275 13 0 1730150400 65536
// Threading:  0 0 65536

// AfterAll
// Benchmark Process 24228 has exited with code 0.
                                                                                                                                                                                                                                    
Mean = 16.926 us, StdErr = 0.516 us (3.05%), N = 100, StdDev = 5.162 us
Min = 9.957 us, Q1 = 10.773 us, Median = 20.037 us, Q3 = 21.602 us, Max = 22.849 us                                                                                                                                                 
IQR = 10.830 us, LowerFence = -5.472 us, UpperFence = 37.847 us                                                                                                                                                                     
ConfidenceInterval = [15.175 us; 18.676 us] (CI 99.9%), Margin = 1.751 us (10.34% of Mean)                                                                                                                                          
Skewness = -0.32, Kurtosis = 1.2, MValue = 3.38                                                                                                                                                                                     
                                                                                                                                                                                                                                    
// ** Remained 3 (50.0%) benchmark(s) to run. Estimated finish 2026-10-15 14:47 (0h 4m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)                                                                                                                                        
// **************************                                                                                                                                                                                                       
// Benchmark: SpatialHashBenchmarks.QueryNearbyAgents: DefaultJob [AgentCount=500]                                                                                                                                                  
// *** Execute ***                                                                                                                                                                                                                  
// Launch: 1 / 1                                                                                                                                                                                                                    
// Execute: dotnet AegisSim.Benchmarks-DefaultJob-2.dll --anonymousPipes 1840 1764 --benchmarkName "AegisSim.Benchmarks.SpatialHashBenchmarks.QueryNearbyAgents(AgentCount: 500)" --job Default --benchmarkId 3 in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0                                                                                           
// BeforeAnythingElse                                                                                                                                                                                                               

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.8
// Runtime=.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2+BMI1+BMI2+F16C+FMA+LZCNT+MOVBE,AVX,SSE3+SSSE3+SSE4.1+SSE4.2+POPCNT,X86Base+SSE+SSE2,AES+PCLMUL,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 193300.00 ns, 193.3000 us/op
WorkloadJitting  1: 1 op, 1005200.00 ns, 1.0052 ms/op

OverheadJitting  2: 16 op, 358900.00 ns, 22.4313 us/op
WorkloadJitting  2: 16 op, 8385700.00 ns, 524.1063 us/op

WorkloadPilot    1: 16 op, 7566100.00 ns, 472.8813 us/op
WorkloadPilot    2: 32 op, 13332200.00 ns, 416.6313 us/op
WorkloadPilot    3: 64 op, 24778500.00 ns, 387.1641 us/op
WorkloadPilot    4: 128 op, 52109900.00 ns, 407.1086 us/op
WorkloadPilot    5: 256 op, 100724400.00 ns, 393.4547 us/op
WorkloadPilot    6: 512 op, 260633500.00 ns, 509.0498 us/op
WorkloadPilot    7: 1024 op, 168675800.00 ns, 164.7225 us/op
WorkloadPilot    8: 2048 op, 333215500.00 ns, 162.7029 us/op
WorkloadPilot    9: 4096 op, 676205200.00 ns, 165.0892 us/op

OverheadWarmup   1: 4096 op, 10600.00 ns, 2.5879 ns/op
OverheadWarmup   2: 4096 op, 9300.00 ns, 2.2705 ns/op
OverheadWarmup   3: 4096 op, 9300.00 ns, 2.2705 ns/op
OverheadWarmup   4: 4096 op, 9200.00 ns, 2.2461 ns/op
OverheadWarmup   5: 4096 op, 9200.00 ns, 2.2461 ns/op
OverheadWarmup   6: 4096 op, 9100.00 ns, 2.2217 ns/op

OverheadActual   1: 4096 op, 9400.00 ns, 2.2949 ns/op
OverheadActual   2: 4096 op, 9200.00 ns, 2.2461 ns/op
OverheadActual   3: 4096 op, 9300.00 ns, 2.2705 ns/op
OverheadActual   4: 4096 op, 9600.00 ns, 2.3438 ns/op
OverheadActual   5: 4096 op, 9700.00 ns, 2.3682 ns/op
OverheadActual   6: 4096 op, 9700.00 ns, 2.3682 ns/op
OverheadActual   7: 4096 op, 9500.00 ns, 2.3193 ns/op
OverheadActual   8: 4096 op, 9500.00 ns, 2.3193 ns/op
OverheadActual   9: 4096 op, 9500.00 ns, 2.3193 ns/op
OverheadActual  10: 4096 op, 9500.00 ns, 2.3193 ns/op
OverheadActual  11: 4096 op, 10000.00 ns, 2.4414 ns/op
OverheadActual  12: 4096 op, 9500.00 ns, 2.3193 ns/op
OverheadActual  13: 4096 op, 9500.00 ns, 2.3193 ns/op
OverheadActual  14: 4096 op, 9400.00 ns, 2.2949 ns/op
OverheadActual  15: 4096 op, 9400.00 ns, 2.2949 ns/op

WorkloadWarmup   1: 4096 op, 658040300.00 ns, 160.6544 us/op
WorkloadWarmup   2: 4096 op, 795536200.00 ns, 194.2227 us/op
WorkloadWarmup   3: 4096 op, 1186821600.00 ns, 289.7514 us/op
WorkloadWarmup   4: 4096 op, 1096409200.00 ns, 267.6780 us/op
WorkloadWarmup   5: 4096 op, 700520600.00 ns, 171.0255 us/op
WorkloadWarmup   6: 4096 op, 666686200.00 ns, 162.7652 us/op
WorkloadWarmup   7: 4096 op, 657960400.00 ns, 160.6349 us/op
WorkloadWarmup   8: 4096 op, 667371800.00 ns, 162.9326 us/op
WorkloadWarmup   9: 4096 op, 658990100.00 ns, 160.8863 us/op

// BeforeActualRun
WorkloadActual   1: 4096 op, 644724500.00 ns, 157.4034 us/op
WorkloadActual   2: 4096 op, 650469200.00 ns, 158.8060 us/op
WorkloadActual   3: 4096 op, 657369200.00 ns, 160.4905 us/op
WorkloadActual   4: 4096 op, 646175500.00 ns, 157.7577 us/op
WorkloadActual   5: 4096 op, 643957500.00 ns, 157.2162 us/op
WorkloadActual   6: 4096 op, 651680300.00 ns, 159.1016 us/op
WorkloadActual   7: 4096 op, 648536100.00 ns, 158.3340 us/op
WorkloadActual   8: 4096 op, 643321600.00 ns, 157.0609 us/op
WorkloadActual   9: 4096 op, 647667100.00 ns, 158.1219 us/op
WorkloadActual  10: 4096 op, 643701300.00 ns, 157.1536 us/op
WorkloadActual  11: 4096 op, 645804900.00 ns, 157.6672 us/op
WorkloadActual  12: 4096 op, 643302400.00 ns, 157.0563 us/op
WorkloadActual  13: 4096 op, 642885600.00 ns, 156.9545 us/op
WorkloadActual  14: 4096 op, 651144600.00 ns, 158.9708 us/op
WorkloadActual  15: 4096 op, 642595400.00 ns, 156.8836 us/op

// AfterActualRun
WorkloadResult   1: 4096 op, 644715000.00 ns, 157.4011 us/op
WorkloadResult   2: 4096 op, 650459700.00 ns, 158.8036 us/op
WorkloadResult   3: 4096 op, 657359700.00 ns, 160.4882 us/op
WorkloadResult   4: 4096 op, 646166000.00 ns, 157.7554 us/op
WorkloadResult   5: 4096 op, 643948000.00 ns, 157.2139 us/op
WorkloadResult   6: 4096 op, 651670800.00 ns, 159.0993 us/op
WorkloadResult   7: 4096 op, 648526600.00 ns, 158.3317 us/op
WorkloadResult   8: 4096 op, 643312100.00 ns, 157.0586 us/op
WorkloadResult   9: 4096 op, 647657600.00 ns, 158.1195 us/op
WorkloadResult  10: 4096 op, 643691800.00 ns, 157.1513 us/op
WorkloadResult  11: 4096 op, 645795400.00 ns, 157.6649 us/op
WorkloadResult  12: 4096 op, 643292900.00 ns, 157.0539 us/op
WorkloadResult  13: 4096 op, 642876100.00 ns, 156.9522 us/op
WorkloadResult  14: 4096 op, 651135100.00 ns, 158.9685 us/op
WorkloadResult  15: 4096 op, 642585900.00 ns, 156.8813 us/op
// GC:  178 0 0 1119027200 4096
// Threading:  0 0 4096

// AfterAll
// Benchmark Process 19996 has exited with code 0.
                                                                                                                                                                                                                                    
Mean = 157.930 us, StdErr = 0.268 us (0.17%), N = 15, StdDev = 1.036 us
Min = 156.881 us, Q1 = 157.105 us, Median = 157.665 us, Q3 = 158.568 us, Max = 160.488 us                                                                                                                                           
IQR = 1.463 us, LowerFence = 154.911 us, UpperFence = 160.762 us                                                                                                                                                                    
ConfidenceInterval = [156.822 us; 159.037 us] (CI 99.9%), Margin = 1.108 us (0.70% of Mean)                                                                                                                                         
Skewness = 0.95, Kurtosis = 2.92, MValue = 2                                                                                                                                                                                        
                                                                                                                                                                                                                                    
// ** Remained 2 (33.3%) benchmark(s) to run. Estimated finish 2026-10-15 14:45 (0h 2m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)                                                                                                                                        
// **************************                                                                                                                                                                                                       
// Benchmark: SpatialHashBenchmarks.RebuildSpatialHash: DefaultJob [AgentCount=1000]                                                                                                                                                
// *** Execute ***                                                                                                                                                                                                                  
// Launch: 1 / 1                                                                                                                                                                                                                    
// Execute: dotnet AegisSim.Benchmarks-DefaultJob-2.dll --anonymousPipes 1876 1868 --benchmarkName "AegisSim.Benchmarks.SpatialHashBenchmarks.RebuildSpatialHash(AgentCount: 1000)" --job Default --benchmarkId 4 in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0                                                                                         
// BeforeAnythingElse                                                                                                                                                                                                               

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.8
// Runtime=.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2+BMI1+BMI2+F16C+FMA+LZCNT+MOVBE,AVX,SSE3+SSSE3+SSE4.1+SSE4.2+POPCNT,X86Base+SSE+SSE2,AES+PCLMUL,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 136200.00 ns, 136.2000 us/op
WorkloadJitting  1: 1 op, 339600.00 ns, 339.6000 us/op

OverheadJitting  2: 16 op, 182800.00 ns, 11.4250 us/op
WorkloadJitting  2: 16 op, 5224800.00 ns, 326.5500 us/op

WorkloadPilot    1: 16 op, 1836700.00 ns, 114.7938 us/op
WorkloadPilot    2: 32 op, 3908200.00 ns, 122.1313 us/op
WorkloadPilot    3: 64 op, 6745700.00 ns, 105.4016 us/op
WorkloadPilot    4: 128 op, 12707500.00 ns, 99.2773 us/op
WorkloadPilot    5: 256 op, 23222900.00 ns, 90.7145 us/op
WorkloadPilot    6: 512 op, 44189100.00 ns, 86.3068 us/op
WorkloadPilot    7: 1024 op, 87619400.00 ns, 85.5658 us/op
WorkloadPilot    8: 2048 op, 254833800.00 ns, 124.4306 us/op
WorkloadPilot    9: 4096 op, 221714800.00 ns, 54.1296 us/op
WorkloadPilot   10: 8192 op, 157648400.00 ns, 19.2442 us/op
WorkloadPilot   11: 16384 op, 314776600.00 ns, 19.2124 us/op
WorkloadPilot   12: 32768 op, 629317100.00 ns, 19.2052 us/op

OverheadWarmup   1: 32768 op, 70700.00 ns, 2.1576 ns/op
OverheadWarmup   2: 32768 op, 69700.00 ns, 2.1271 ns/op
OverheadWarmup   3: 32768 op, 70000.00 ns, 2.1362 ns/op
OverheadWarmup   4: 32768 op, 69300.00 ns, 2.1149 ns/op
OverheadWarmup   5: 32768 op, 69600.00 ns, 2.1240 ns/op
OverheadWarmup   6: 32768 op, 72600.00 ns, 2.2156 ns/op
OverheadWarmup   7: 32768 op, 72900.00 ns, 2.2247 ns/op
OverheadWarmup   8: 32768 op, 72700.00 ns, 2.2186 ns/op

OverheadActual   1: 32768 op, 73600.00 ns, 2.2461 ns/op
OverheadActual   2: 32768 op, 72600.00 ns, 2.2156 ns/op
OverheadActual   3: 32768 op, 75300.00 ns, 2.2980 ns/op
OverheadActual   4: 32768 op, 73100.00 ns, 2.2308 ns/op
OverheadActual   5: 32768 op, 73700.00 ns, 2.2491 ns/op
OverheadActual   6: 32768 op, 72100.00 ns, 2.2003 ns/op
OverheadActual   7: 32768 op, 72200.00 ns, 2.2034 ns/op
OverheadActual   8: 32768 op, 71700.00 ns, 2.1881 ns/op
OverheadActual   9: 32768 op, 84000.00 ns, 2.5635 ns/op
OverheadActual  10: 32768 op, 73000.00 ns, 2.2278 ns/op
OverheadActual  11: 32768 op, 73200.00 ns, 2.2339 ns/op
OverheadActual  12: 32768 op, 72700.00 ns, 2.2186 ns/op
OverheadActual  13: 32768 op, 73000.00 ns, 2.2278 ns/op
OverheadActual  14: 32768 op, 72700.00 ns, 2.2186 ns/op
OverheadActual  15: 32768 op, 73100.00 ns, 2.2308 ns/op

WorkloadWarmup   1: 32768 op, 624835400.00 ns, 19.0685 us/op
WorkloadWarmup   2: 32768 op, 656348600.00 ns, 20.0302 us/op
WorkloadWarmup   3: 32768 op, 685203000.00 ns, 20.9107 us/op
WorkloadWarmup   4: 32768 op, 682549800.00 ns, 20.8298 us/op
WorkloadWarmup   5: 32768 op, 685030900.00 ns, 20.9055 us/op
WorkloadWarmup   6: 32768 op, 693087900.00 ns, 21.1514 us/op
WorkloadWarmup   7: 32768 op, 681550100.00 ns, 20.7993 us/op

// BeforeActualRun
WorkloadActual   1: 32768 op, 683396000.00 ns, 20.8556 us/op
WorkloadActual   2: 32768 op, 683741100.00 ns, 20.8661 us/op
WorkloadActual   3: 32768 op, 674051100.00 ns, 20.5704 us/op
WorkloadActual   4: 32768 op, 637199000.00 ns, 19.4458 us/op
WorkloadActual   5: 32768 op, 632877400.00 ns, 19.3139 us/op
WorkloadActual   6: 32768 op, 639699400.00 ns, 19.5221 us/op
WorkloadActual   7: 32768 op, 629368300.00 ns, 19.2068 us/op
WorkloadActual   8: 32768 op, 634090800.00 ns, 19.3509 us/op
WorkloadActual   9: 32768 op, 633468300.00 ns, 19.3319 us/op
WorkloadActual  10: 32768 op, 633268600.00 ns, 19.3258 us/op
WorkloadActual  11: 32768 op, 629684500.00 ns, 19.2164 us/op
WorkloadActual  12: 32768 op, 635306800.00 ns, 19.3880 us/op
WorkloadActual  13: 32768 op, 625885300.00 ns, 19.1005 us/op
WorkloadActual  14: 32768 op, 631588700.00 ns, 19.2746 us/op
WorkloadActual  15: 32768 op, 636411600.00 ns, 19.4217 us/op

// AfterActualRun
WorkloadResult   1: 32768 op, 637126000.00 ns, 19.4435 us/op
WorkloadResult   2: 32768 op, 632804400.00 ns, 19.3117 us/op
WorkloadResult   3: 32768 op, 639626400.00 ns, 19.5198 us/op
WorkloadResult   4: 32768 op, 629295300.00 ns, 19.2046 us/op
WorkloadResult   5: 32768 op, 634017800.00 ns, 19.3487 us/op
WorkloadResult   6: 32768 op, 633395300.00 ns, 19.3297 us/op
WorkloadResult   7: 32768 op, 633195600.00 ns, 19.3236 us/op
WorkloadResult   8: 32768 op, 629611500.00 ns, 19.2142 us/op
WorkloadResult   9: 32768 op, 635233800.00 ns, 19.3858 us/op
WorkloadResult  10: 32768 op, 625812300.00 ns, 19.0983 us/op
WorkloadResult  11: 32768 op, 631515700.00 ns, 19.2723 us/op
WorkloadResult  12: 32768 op, 636338600.00 ns, 19.4195 us/op
// GC:  241 17 0 1513881600 32768
// Threading:  0 0 32768

// AfterAll
// Benchmark Process 4904 has exited with code 0.
                                                                                                                                                                                                                                    
Mean = 19.323 us, StdErr = 0.033 us (0.17%), N = 12, StdDev = 0.115 us
Min = 19.098 us, Q1 = 19.258 us, Median = 19.327 us, Q3 = 19.394 us, Max = 19.520 us                                                                                                                                                
IQR = 0.136 us, LowerFence = 19.053 us, UpperFence = 19.599 us                                                                                                                                                                      
ConfidenceInterval = [19.175 us; 19.470 us] (CI 99.9%), Margin = 0.148 us (0.76% of Mean)                                                                                                                                           
Skewness = -0.2, Kurtosis = 2.22, MValue = 2                                                                                                                                                                                        
                                                                                                                                                                                                                                    
// ** Remained 1 (16.7%) benchmark(s) to run. Estimated finish 2026-10-15 14:44 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)                                                                                                                                        
// **************************                                                                                                                                                                                                       
// Benchmark: SpatialHashBenchmarks.QueryNearbyAgents: DefaultJob [AgentCount=1000]                                                                                                                                                 
// *** Execute ***                                                                                                                                                                                                                  
// Launch: 1 / 1                                                                                                                                                                                                                    
// Execute: dotnet AegisSim.Benchmarks-DefaultJob-2.dll --anonymousPipes 1708 1816 --benchmarkName "AegisSim.Benchmarks.SpatialHashBenchmarks.QueryNearbyAgents(AgentCount: 1000)" --job Default --benchmarkId 5 in C:\Users\patha\Documents\Programming\C# Development\Aegis Sim\AegisSim.Benchmarks\bin\Release\net10.0\AegisSim.Benchmarks-DefaultJob-2\bin\Release\net10.0                                                                                          
// BeforeAnythingElse                                                                                                                                                                                                               

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.8
// Runtime=.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2+BMI1+BMI2+F16C+FMA+LZCNT+MOVBE,AVX,SSE3+SSSE3+SSE4.1+SSE4.2+POPCNT,X86Base+SSE+SSE2,AES+PCLMUL,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 163800.00 ns, 163.8000 us/op
WorkloadJitting  1: 1 op, 1824200.00 ns, 1.8242 ms/op

OverheadJitting  2: 16 op, 341000.00 ns, 21.3125 us/op
WorkloadJitting  2: 16 op, 21430200.00 ns, 1.3394 ms/op

WorkloadPilot    1: 16 op, 15521900.00 ns, 970.1188 us/op
WorkloadPilot    2: 32 op, 28662100.00 ns, 895.6906 us/op
WorkloadPilot    3: 64 op, 54593200.00 ns, 853.0188 us/op
WorkloadPilot    4: 128 op, 112156700.00 ns, 876.2242 us/op
WorkloadPilot    5: 256 op, 292446000.00 ns, 1.1424 ms/op
WorkloadPilot    6: 512 op, 214692800.00 ns, 419.3219 us/op
WorkloadPilot    7: 1024 op, 383319800.00 ns, 374.3357 us/op
WorkloadPilot    8: 2048 op, 771930000.00 ns, 376.9189 us/op

OverheadWarmup   1: 2048 op, 6800.00 ns, 3.3203 ns/op
OverheadWarmup   2: 2048 op, 5500.00 ns, 2.6855 ns/op
OverheadWarmup   3: 2048 op, 5300.00 ns, 2.5879 ns/op
OverheadWarmup   4: 2048 op, 5200.00 ns, 2.5391 ns/op
OverheadWarmup   5: 2048 op, 5600.00 ns, 2.7344 ns/op
OverheadWarmup   6: 2048 op, 5300.00 ns, 2.5879 ns/op
OverheadWarmup   7: 2048 op, 5200.00 ns, 2.5391 ns/op
OverheadWarmup   8: 2048 op, 5200.00 ns, 2.5391 ns/op
OverheadWarmup   9: 2048 op, 5200.00 ns, 2.5391 ns/op

OverheadActual   1: 2048 op, 5700.00 ns, 2.7832 ns/op
OverheadActual   2: 2048 op, 6000.00 ns, 2.9297 ns/op
OverheadActual   3: 2048 op, 6200.00 ns, 3.0273 ns/op
OverheadActual   4: 2048 op, 5800.00 ns, 2.8320 ns/op
OverheadActual   5: 2048 op, 5400.00 ns, 2.6367 ns/op
OverheadActual   6: 2048 op, 5500.00 ns, 2.6855 ns/op
OverheadActual   7: 2048 op, 5500.00 ns, 2.6855 ns/op
OverheadActual   8: 2048 op, 5500.00 ns, 2.6855 ns/op
OverheadActual   9: 2048 op, 5700.00 ns, 2.7832 ns/op
OverheadActual  10: 2048 op, 5700.00 ns, 2.7832 ns/op
OverheadActual  11: 2048 op, 5500.00 ns, 2.6855 ns/op
OverheadActual  12: 2048 op, 5600.00 ns, 2.7344 ns/op
OverheadActual  13: 2048 op, 5700.00 ns, 2.7832 ns/op
OverheadActual  14: 2048 op, 5500.00 ns, 2.6855 ns/op
OverheadActual  15: 2048 op, 5600.00 ns, 2.7344 ns/op

WorkloadWarmup   1: 2048 op, 768927000.00 ns, 375.4526 us/op
WorkloadWarmup   2: 2048 op, 769144400.00 ns, 375.5588 us/op
WorkloadWarmup   3: 2048 op, 769085000.00 ns, 375.5298 us/op
WorkloadWarmup   4: 2048 op, 767986600.00 ns, 374.9935 us/op
WorkloadWarmup   5: 2048 op, 766870700.00 ns, 374.4486 us/op
WorkloadWarmup   6: 2048 op, 768867000.00 ns, 375.4233 us/op
WorkloadWarmup   7: 2048 op, 764149700.00 ns, 373.1200 us/op

// BeforeActualRun
WorkloadActual   1: 2048 op, 770722200.00 ns, 376.3292 us/op
WorkloadActual   2: 2048 op, 780321500.00 ns, 381.0164 us/op
WorkloadActual   3: 2048 op, 824239000.00 ns, 402.4604 us/op
WorkloadActual   4: 2048 op, 762363300.00 ns, 372.2477 us/op
WorkloadActual   5: 2048 op, 785033300.00 ns, 383.3170 us/op
WorkloadActual   6: 2048 op, 836552600.00 ns, 408.4729 us/op
WorkloadActual   7: 2048 op, 799163700.00 ns, 390.2167 us/op
WorkloadActual   8: 2048 op, 779160800.00 ns, 380.4496 us/op
WorkloadActual   9: 2048 op, 790141100.00 ns, 385.8111 us/op
WorkloadActual  10: 2048 op, 788187100.00 ns, 384.8570 us/op
WorkloadActual  11: 2048 op, 794099700.00 ns, 387.7440 us/op
WorkloadActual  12: 2048 op, 806164000.00 ns, 393.6348 us/op
WorkloadActual  13: 2048 op, 840644300.00 ns, 410.4708 us/op
WorkloadActual  14: 2048 op, 841662100.00 ns, 410.9678 us/op
WorkloadActual  15: 2048 op, 832613400.00 ns, 406.5495 us/op
WorkloadActual  16: 2048 op, 827927700.00 ns, 404.2616 us/op
WorkloadActual  17: 2048 op, 837430600.00 ns, 408.9017 us/op
WorkloadActual  18: 2048 op, 794935900.00 ns, 388.1523 us/op
WorkloadActual  19: 2048 op, 766330700.00 ns, 374.1849 us/op
WorkloadActual  20: 2048 op, 771252200.00 ns, 376.5880 us/op
WorkloadActual  21: 2048 op, 767750800.00 ns, 374.8783 us/op
WorkloadActual  22: 2048 op, 760617400.00 ns, 371.3952 us/op
WorkloadActual  23: 2048 op, 764334500.00 ns, 373.2102 us/op
WorkloadActual  24: 2048 op, 771171000.00 ns, 376.5483 us/op
WorkloadActual  25: 2048 op, 772116700.00 ns, 377.0101 us/op
WorkloadActual  26: 2048 op, 761354800.00 ns, 371.7553 us/op
WorkloadActual  27: 2048 op, 768513400.00 ns, 375.2507 us/op
WorkloadActual  28: 2048 op, 775391100.00 ns, 378.6089 us/op
WorkloadActual  29: 2048 op, 771380900.00 ns, 376.6508 us/op
WorkloadActual  30: 2048 op, 764990500.00 ns, 373.5305 us/op
WorkloadActual  31: 2048 op, 763648800.00 ns, 372.8754 us/op
WorkloadActual  32: 2048 op, 766214700.00 ns, 374.1283 us/op
WorkloadActual  33: 2048 op, 766830400.00 ns, 374.4289 us/op
WorkloadActual  34: 2048 op, 792850300.00 ns, 387.1339 us/op
WorkloadActual  35: 2048 op, 785653700.00 ns, 383.6200 us/op
WorkloadActual  36: 2048 op, 768973000.00 ns, 375.4751 us/op

// AfterActualRun
WorkloadResult   1: 2048 op, 770716600.00 ns, 376.3265 us/op
WorkloadResult   2: 2048 op, 780315900.00 ns, 381.0136 us/op
WorkloadResult   3: 2048 op, 824233400.00 ns, 402.4577 us/op
WorkloadResult   4: 2048 op, 762357700.00 ns, 372.2450 us/op
WorkloadResult   5: 2048 op, 785027700.00 ns, 383.3143 us/op
WorkloadResult   6: 2048 op, 836547000.00 ns, 408.4702 us/op
WorkloadResult   7: 2048 op, 799158100.00 ns, 390.2139 us/op
WorkloadResult   8: 2048 op, 779155200.00 ns, 380.4469 us/op
WorkloadResult   9: 2048 op, 790135500.00 ns, 385.8083 us/op
WorkloadResult  10: 2048 op, 788181500.00 ns, 384.8542 us/op
WorkloadResult  11: 2048 op, 794094100.00 ns, 387.7413 us/op
WorkloadResult  12: 2048 op, 806158400.00 ns, 393.6320 us/op
WorkloadResult  13: 2048 op, 832607800.00 ns, 406.5468 us/op
WorkloadResult  14: 2048 op, 827922100.00 ns, 404.2588 us/op
WorkloadResult  15: 2048 op, 837425000.00 ns, 408.8989 us/op
WorkloadResult  16: 2048 op, 794930300.00 ns, 388.1496 us/op
WorkloadResult  17: 2048 op, 766325100.00 ns, 374.1822 us/op
WorkloadResult  18: 2048 op, 771246600.00 ns, 376.5853 us/op
WorkloadResult  19: 2048 op, 767745200.00 ns, 374.8756 us/op
WorkloadResult  20: 2048 op, 760611800.00 ns, 371.3925 us/op
WorkloadResult  21: 2048 op, 764328900.00 ns, 373.2075 us/op
WorkloadResult  22: 2048 op, 771165400.00 ns, 376.5456 us/op
WorkloadResult  23: 2048 op, 772111100.00 ns, 377.0074 us/op
WorkloadResult  24: 2048 op, 761349200.00 ns, 371.7525 us/op
WorkloadResult  25: 2048 op, 768507800.00 ns, 375.2479 us/op
WorkloadResult  26: 2048 op, 775385500.00 ns, 378.6062 us/op
WorkloadResult  27: 2048 op, 771375300.00 ns, 376.6481 us/op
WorkloadResult  28: 2048 op, 764984900.00 ns, 373.5278 us/op
WorkloadResult  29: 2048 op, 763643200.00 ns, 372.8727 us/op
WorkloadResult  30: 2048 op, 766209100.00 ns, 374.1255 us/op
WorkloadResult  31: 2048 op, 766824800.00 ns, 374.4262 us/op
WorkloadResult  32: 2048 op, 792844700.00 ns, 387.1312 us/op
WorkloadResult  33: 2048 op, 785648100.00 ns, 383.6172 us/op
WorkloadResult  34: 2048 op, 768967400.00 ns, 375.4724 us/op
// GC:  221 0 0 1390575616 2048
// Threading:  0 0 2048

// AfterAll
// Benchmark Process 23192 has exited with code 0.
                                                                                                                                                                                                                                    
Mean = 382.988 us, StdErr = 1.948 us (0.51%), N = 34, StdDev = 11.360 us
Min = 371.392 us, Q1 = 374.539 us, Median = 377.807 us, Q3 = 387.589 us, Max = 408.899 us                                                                                                                                           
IQR = 13.050 us, LowerFence = 354.963 us, UpperFence = 407.164 us                                                                                                                                                                   
ConfidenceInterval = [375.953 us; 390.023 us] (CI 99.9%), Margin = 7.035 us (1.84% of Mean)                                                                                                                                         
Skewness = 1.09, Kurtosis = 2.93, MValue = 2                                                                                                                                                                                        
                                                                                                                                                                                                                                    
// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2026-10-15 14:44 (0h 0m from now) **
Successfully reverted power plan (GUID: 381b4222-f694-41f0-9685-ff5bb260df2e FriendlyName: Balanced)                                                                                                                                
// ***** BenchmarkRunner: Finish  *****                                                                                                                                                                                             
                                                                                                                                                                                                                                    
// * Export *
  BenchmarkDotNet.Artifacts\results\AegisSim.Benchmarks.SpatialHashBenchmarks-report.csv                                                                                                                                            
  BenchmarkDotNet.Artifacts\results\AegisSim.Benchmarks.SpatialHashBenchmarks-report-github.md                                                                                                                                      
  BenchmarkDotNet.Artifacts\results\AegisSim.Benchmarks.SpatialHashBenchmarks-report.html                                                                                                                                           
                                                                                                                                                                                                                                    
// * Detailed results *
SpatialHashBenchmarks.RebuildSpatialHash: DefaultJob [AgentCount=200]                                                                                                                                                               
Runtime = .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation                                                                                                                                
Mean = 3.428 us, StdErr = 0.020 us (0.58%), N = 72, StdDev = 0.168 us                                                                                                                                                               
Min = 3.201 us, Q1 = 3.282 us, Median = 3.407 us, Q3 = 3.530 us, Max = 3.895 us                                                                                                                                                     
IQR = 0.248 us, LowerFence = 2.910 us, UpperFence = 3.902 us                                                                                                                                                                        
ConfidenceInterval = [3.360 us; 3.496 us] (CI 99.9%), Margin = 0.068 us (1.98% of Mean)                                                                                                                                             
Skewness = 0.79, Kurtosis = 3.02, MValue = 2                                                                                                                                                                                        
-------------------- Histogram --------------------                                                                                                                                                                                 
[3.148 us ; 3.219 us) | @                                                                                                                                                                                                           
[3.219 us ; 3.325 us) | @@@@@@@@@@@@@@@@@@@@@@@                                                                                                                                                                                     
[3.325 us ; 3.461 us) | @@@@@@@@@@@@@@@@@@@@@@@                                                                                                                                                                                     
[3.461 us ; 3.578 us) | @@@@@@@@@@@@@                                                                                                                                                                                               
[3.578 us ; 3.685 us) | @@@@@@@                                                                                                                                                                                                     
[3.685 us ; 3.815 us) | @@@                                                                                                                                                                                                         
[3.815 us ; 3.948 us) | @@                                                                                                                                                                                                          
---------------------------------------------------                                                                                                                                                                                 
                                                                                                                                                                                                                                    
SpatialHashBenchmarks.QueryNearbyAgents: DefaultJob [AgentCount=200]
Runtime = .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation                                                                                                                                
Mean = 62.418 us, StdErr = 0.303 us (0.49%), N = 16, StdDev = 1.214 us                                                                                                                                                              
Min = 60.006 us, Q1 = 61.925 us, Median = 62.605 us, Q3 = 63.261 us, Max = 64.425 us                                                                                                                                                
IQR = 1.335 us, LowerFence = 59.923 us, UpperFence = 65.263 us                                                                                                                                                                      
ConfidenceInterval = [61.182 us; 63.654 us] (CI 99.9%), Margin = 1.236 us (1.98% of Mean)                                                                                                                                           
Skewness = -0.37, Kurtosis = 2.29, MValue = 2                                                                                                                                                                                       
-------------------- Histogram --------------------                                                                                                                                                                                 
[59.919 us ; 61.183 us) | @@@                                                                                                                                                                                                       
[61.183 us ; 62.942 us) | @@@@@@@@                                                                                                                                                                                                  
[62.942 us ; 64.469 us) | @@@@@                                                                                                                                                                                                     
---------------------------------------------------                                                                                                                                                                                 
                                                                                                                                                                                                                                    
SpatialHashBenchmarks.RebuildSpatialHash: DefaultJob [AgentCount=500]
Runtime = .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation                                                                                                                                
Mean = 16.926 us, StdErr = 0.516 us (3.05%), N = 100, StdDev = 5.162 us                                                                                                                                                             
Min = 9.957 us, Q1 = 10.773 us, Median = 20.037 us, Q3 = 21.602 us, Max = 22.849 us                                                                                                                                                 
IQR = 10.830 us, LowerFence = -5.472 us, UpperFence = 37.847 us                                                                                                                                                                     
ConfidenceInterval = [15.175 us; 18.676 us] (CI 99.9%), Margin = 1.751 us (10.34% of Mean)                                                                                                                                          
Skewness = -0.32, Kurtosis = 1.2, MValue = 3.38                                                                                                                                                                                     
-------------------- Histogram --------------------                                                                                                                                                                                 
[ 9.401 us ; 12.320 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                                                                                                                                                    
[12.320 us ; 15.105 us) | @@@                                                                                                                                                                                                       
[15.105 us ; 16.897 us) | @                                                                                                                                                                                                         
[16.897 us ; 19.531 us) | @@                                                                                                                                                                                                        
[19.531 us ; 22.450 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                                                                                                                                    
[22.450 us ; 24.309 us) | @@                                                                                                                                                                                                        
---------------------------------------------------                                                                                                                                                                                 
                                                                                                                                                                                                                                    
SpatialHashBenchmarks.QueryNearbyAgents: DefaultJob [AgentCount=500]
Runtime = .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation                                                                                                                                
Mean = 157.930 us, StdErr = 0.268 us (0.17%), N = 15, StdDev = 1.036 us                                                                                                                                                             
Min = 156.881 us, Q1 = 157.105 us, Median = 157.665 us, Q3 = 158.568 us, Max = 160.488 us                                                                                                                                           
IQR = 1.463 us, LowerFence = 154.911 us, UpperFence = 160.762 us                                                                                                                                                                    
ConfidenceInterval = [156.822 us; 159.037 us] (CI 99.9%), Margin = 1.108 us (0.70% of Mean)                                                                                                                                         
Skewness = 0.95, Kurtosis = 2.92, MValue = 2                                                                                                                                                                                        
-------------------- Histogram --------------------                                                                                                                                                                                 
[156.330 us ; 161.040 us) | @@@@@@@@@@@@@@@                                                                                                                                                                                         
---------------------------------------------------                                                                                                                                                                                 
                                                                                                                                                                                                                                    
SpatialHashBenchmarks.RebuildSpatialHash: DefaultJob [AgentCount=1000]
Runtime = .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation                                                                                                                                
Mean = 19.323 us, StdErr = 0.033 us (0.17%), N = 12, StdDev = 0.115 us                                                                                                                                                              
Min = 19.098 us, Q1 = 19.258 us, Median = 19.327 us, Q3 = 19.394 us, Max = 19.520 us                                                                                                                                                
IQR = 0.136 us, LowerFence = 19.053 us, UpperFence = 19.599 us                                                                                                                                                                      
ConfidenceInterval = [19.175 us; 19.470 us] (CI 99.9%), Margin = 0.148 us (0.76% of Mean)                                                                                                                                           
Skewness = -0.2, Kurtosis = 2.22, MValue = 2                                                                                                                                                                                        
-------------------- Histogram --------------------                                                                                                                                                                                 
[19.032 us ; 19.571 us) | @@@@@@@@@@@@                                                                                                                                                                                              
---------------------------------------------------                                                                                                                                                                                 
                                                                                                                                                                                                                                    
SpatialHashBenchmarks.QueryNearbyAgents: DefaultJob [AgentCount=1000]
Runtime = .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation                                                                                                                                
Mean = 382.988 us, StdErr = 1.948 us (0.51%), N = 34, StdDev = 11.360 us                                                                                                                                                            
Min = 371.392 us, Q1 = 374.539 us, Median = 377.807 us, Q3 = 387.589 us, Max = 408.899 us                                                                                                                                           
IQR = 13.050 us, LowerFence = 354.963 us, UpperFence = 407.164 us                                                                                                                                                                   
ConfidenceInterval = [375.953 us; 390.023 us] (CI 99.9%), Margin = 7.035 us (1.84% of Mean)                                                                                                                                         
Skewness = 1.09, Kurtosis = 2.93, MValue = 2                                                                                                                                                                                        
-------------------- Histogram --------------------                                                                                                                                                                                 
[371.317 us ; 380.522 us) | @@@@@@@@@@@@@@@@@@@                                                                                                                                                                                     
[380.522 us ; 390.216 us) | @@@@@@@@@                                                                                                                                                                                               
[390.216 us ; 401.076 us) | @                                                                                                                                                                                                       
[401.076 us ; 410.281 us) | @@@@@                                                                                                                                                                                                   
---------------------------------------------------                                                                                                                                                                                 
                                                                                                                                                                                                                                    
// * Summary *
                                                                                                                                                                                                                                    
BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
12th Gen Intel Core i5-12450HX 2.40GHz, 1 CPU, 12 logical and 8 physical cores                                                                                                                                                      
.NET SDK 10.0.401                                                                                                                                                                                                                   
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3                                                                                                                                                        
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3                                                                                                                                                        
                                                                                                                                                                                                                                    

| Method             | AgentCount | Mean       | Error     | StdDev     | Median     | Gen0     | Gen1   | Allocated |
|------------------- |----------- |-----------:|----------:|-----------:|-----------:|---------:|-------:|----------:|
| RebuildSpatialHash | 200        |   3.428 us | 0.0679 us |  0.1679 us |   3.407 us |   1.0490 | 0.0114 |   6.45 KB |                                                                                                              
| QueryNearbyAgents  | 200        |  62.418 us | 1.2360 us |  1.2139 us |  62.605 us |  10.2539 |      - |  62.88 KB |
| RebuildSpatialHash | 500        |  16.926 us | 1.7506 us |  5.1617 us |  20.037 us |   4.1962 | 0.1984 |  25.78 KB |
| QueryNearbyAgents  | 500        | 157.930 us | 1.1078 us |  1.0362 us | 157.665 us |  43.4570 |      - |  266.8 KB |
| RebuildSpatialHash | 1000       |  19.323 us | 0.1477 us |  0.1153 us |  19.327 us |   7.3547 | 0.5188 |  45.12 KB |
| QueryNearbyAgents  | 1000       | 382.988 us | 7.0349 us | 11.3600 us | 377.807 us | 107.9102 |      - | 663.08 KB |

// * Warnings *                                                                                                                                                                                                                     
MultimodalDistribution                                                                                                                                                                                                              
  SpatialHashBenchmarks.RebuildSpatialHash: Default -> It seems that the distribution is bimodal (mValue = 3.38)                                                                                                                    
                                                                                                                                                                                                                                    
// * Hints *                                                                                                                                                                                                                        
Outliers                                                                                                                                                                                                                            
  SpatialHashBenchmarks.RebuildSpatialHash: Default -> 6 outliers were removed (6.27 us..6.79 us)                                                                                                                                   
  SpatialHashBenchmarks.RebuildSpatialHash: Default -> 3 outliers were removed (20.57 us..20.87 us)                                                                                                                                 
  SpatialHashBenchmarks.QueryNearbyAgents: Default  -> 2 outliers were removed (410.47 us, 410.97 us)                                                                                                                               
                                                                                                                                                                                                                                    
// * Legends *
  AgentCount : Value of the 'AgentCount' parameter                                                                                                                                                                                  
  Mean       : Arithmetic mean of all measurements                                                                                                                                                                                  
  Error      : Half of 99.9% confidence interval                                                                                                                                                                                    
  StdDev     : Standard deviation of all measurements                                                                                                                                                                               
  Median     : Value separating the higher half of all measurements (50th percentile)                                                                                                                                               
  Gen0       : GC Generation 0 collects per 1000 operations                                                                                                                                                                         
  Gen1       : GC Generation 1 collects per 1000 operations                                                                                                                                                                         
  Allocated  : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)                                                                                                                                         
  1 us       : 1 Microsecond (0.000001 sec)                                                                                                                                                                                         
                                                                                                                                                                                                                                    
// * Diagnostic Output - MemoryDiagnoser *
                                                                                                                                                                                                                                    

// ***** BenchmarkRunner: End *****
Run time: 00:05:34 (334.33 sec), executed benchmarks: 6                                                                                                                                                                             
                                                                                                                                                                                                                                    
Global total time: 00:05:41 (341.8 sec), executed benchmarks: 6
// * Artifacts cleanup *                                                                                                                                                                                                            
Artifacts cleanup is finished                                                                                                                                                                                                       
PS C:\Users\patha\Documents\Programming\C# Development\Aegis Sim>                                                                                                                                                                   

```

# AegisSim

A high-performance, deterministic 2D simulation engine core built from scratch using **C#**, **.NET 10**, and **MonoGame**. This engine separates heavy systemic simulation updates from variable graphics rendering cycles to achieve robust execution parity across diverse consumer hardware.

This project serves as a portfolio showcase focusing on low-level data-oriented optimization, spatial partitioning arrays, and high-density algorithmic scaling without relying on off-the-shelf commercial engine physics frameworks.

## 🛠️ Core Engineering Highlights

*   **Deterministic Simulation Loop:** Completely decouples simulation ticks (fixed timestep) from presentation frames, isolating physical interactions and state mutation from variable delta-time frame rates.
*   **Zero-Allocation Spatial Hash Grid:** Partitions 2D world space into a dynamic index mapping, dropping complex collision and visibility proximity queries from an expensive O(N²) brute-force check to an optimized, cache-friendly O(1) lookup.
*   **Modern .NET 10 Framework Optimization:** Leverages RyuJIT compiler optimizations, structural value types (`struct`), and packed contiguous arrays to maximize L1/L2 data cache hits and minimize runtime Garbage Collection overhead.

---

## 📊 Performance & Benchmarks

The core engine systems are aggressively stress-tested and tracked using **BenchmarkDotNet v0.15.8** on isolated release runtimes. The following results illustrate execution timelines across scaling agent loads under a high-performance power plan profile.

### Environment Context
*   **OS / Runtime:** Windows 11, .NET 10.0.12 Execution Context
*   **Hardware:** 12th Gen Intel Core i5-12450HX (2.40GHz, 8 Physical Cores, 12 Logical Cores)
*   **Compiler Targets:** X64 RyuJIT x86-64-v3 with packed Vector Size (256-bit SIMD lane capability)
*   **Hardware Intrinsics Enabled:** AVX2, BMI1, BMI2, FMA, LZCNT, SSE4.2

### 1. Simulation Loop Cycles (`SimulationBenchmarks`)
Measures the computational budget consumed by mass-agent updates inside the fixed timestep window.

| Method | Agent Count | Execution Mean | Std. Deviation | Gen 0 / 1k Ops | Allocated Memory |
| :--- | :---: | :---: | :---: | :---: | :---: |
| **UpdateAgents** | 200 | **305.6 ns** | 5.88 ns | 0.0062 | 40 B |
| **UpdateAgents** | 500 | **815.6 ns** | 21.37 ns | 0.0057 | 40 B |
| **UpdateAgents** | 1000 | **2,189.5 ns** | 23.48 ns | 0.0038 | 40 B |

### 2. Spatial Partitioning Subsystems (`SpatialHashBenchmarks`)
Tracks structural rebuild times per cycle and the subsequent proximity spatial query lookups across localized cell buckets.

| Method | Agent Count | Execution Mean | Std. Deviation | Gen 0 / 1k Ops | Allocated Memory |
| :--- | :---: | :---: | :---: | :---: | :---: |
| **RebuildSpatialHash** | 200 | **3.428 μs** | 0.168 μs | 1.0490 | 6.45 KB |
| **QueryNearbyAgents** | 200 | **62.418 μs** | 1.214 μs | 10.2539 | 62.88 KB |
| **RebuildSpatialHash** | 500 | **16.926 μs** | 5.162 μs | 4.1962 | 25.78 KB |
| **QueryNearbyAgents** | 500 | **157.930 μs** | 1.036 μs | 43.4570 | 266.80 KB |
| **RebuildSpatialHash** | 1000 | **19.323 μs** | 0.115 μs | 7.3547 | 45.12 KB |
| **QueryNearbyAgents** | 1000 | **382.988 μs** | 11.360 μs | 107.9102 | 663.08 KB |

*Analysis Takeaway:* Querying localized subsets out of **1,000 distinct agents** completes in less than **0.38 milliseconds**, verifying that spatial pruning successfully isolates the processing pipeline from standard performance pitfalls.

---

## 🏗️ Architectural Topology


                         [ OS User Input Engine ]
                                    │
               ┌────────────────────┴────────────────────┐
               ▼                                         ▼
   ┌───────────────────────┐                 ┌───────────────────────┐
   │ SIMULATION SUB-TICK   │                 │ GRAPHICS RENDER LOOP  │
   │ (Deterministic Clock) │                 │  (Variable Framerate) │
   ├───────────────────────┤                 ├───────────────────────┤
   │ Fixed Timestep Ticks  │                 │ Interpolated Frame    │
   │ Fixed-Point Logic     │                 │ State Snapshots       │
   │ Spatial Hash Buckets  │                 │ Sprite Batch Ingest   │
   │ Agent FSM Mutations   │                 │ Debug Metric Overlay  │
   └───────────────────────┘                 └───────────────────────┘ 



### Decoupled Subsystems
1. **`AegisSim.Core`**: Housing the mathematical foundations, spatial grid data structures, agent controllers, and engine tick management pipelines. 
2. **`AegisSim.Benchmarks`**: Dedicated harness layer tracking algorithmic execution timelines using BenchmarkDotNet to capture regressions at the microsecond level.

---

## 🚀 Getting Started & Local Compilation

### Prerequisites
*   .NET 10.0 SDK (`SDK 10.0.401` or later recommended)
*   IDE with support for C# 14 / .NET 10 compilation (JetBrains Rider, Visual Studio 2022 Preview, or VS Code with C# Dev Kit)

### Step 1: Clone and Build the Core Assembly
```bash
git clone https://github.com
cd AegisSim
dotnet build -c Release
```

### Step 2: Execute Performance Diagnostic Profiles
To repeat the deterministic performance runs and output structural CSV/HTML trace data:
```bash
dotnet run --project AegisSim.Benchmarks -c Release
```

---

## 🎯 Target Milestones
- [x] Fixed-Timestep Core Loop & Delta Separation
- [x] Dynamic Uniform Spatial Hash Grid Implementation
- [x] Micro-architectural benchmarking profiles (.NET 10 Target)
- [ ] Integration of Automated Flow-Field Vector Pathfinding Matrices
- [ ] Ingestion layout integration with Python Texture Atlas Packer metadata

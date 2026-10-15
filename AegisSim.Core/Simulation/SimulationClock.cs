using System;

namespace AegisSim.Core.Simulation;

/// <summary>
/// Tracks elapsed time and determines when fixed simulation ticks should run.
/// </summary>
public sealed class SimulationClock
{
    public const double TargetTickRate = 30.0;

    public const double TargetTickTime = 1.0 / TargetTickRate;

    private const double MaxFrameTime = 0.25;

    private double _accumulatedTime;

    public double AccumulatedTime => _accumulatedTime;

    public long TotalTicks { get; private set; }

    /// <summary>
    /// Adds elapsed wall-clock time and returns the number of
    /// fixed simulation ticks that are ready to execute.
    /// </summary>
    public int Advance(double elapsedSeconds)
    {
        if (!double.IsFinite(elapsedSeconds) || elapsedSeconds < 0.0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(elapsedSeconds),
                "Elapsed time must be finite and non-negative.");
        }

        _accumulatedTime += Math.Min(elapsedSeconds, MaxFrameTime);

        int ticksToRun = (int)(_accumulatedTime / TargetTickTime);

        _accumulatedTime -= ticksToRun * TargetTickTime;

        TotalTicks += ticksToRun;

        return ticksToRun;
    }

    /// <summary>
    /// Resets the accumulated time and tick counter.
    /// </summary>
    public void Reset()
    {
        _accumulatedTime = 0.0;
        TotalTicks = 0;
    }
}
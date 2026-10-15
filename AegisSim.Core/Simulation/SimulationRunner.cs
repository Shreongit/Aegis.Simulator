using System;

namespace AegisSim.Core.Simulation;

/// <summary>
/// Executes simulation updates at a fixed timestep,
/// independently of the rendering frame rate.
/// </summary>
public sealed class SimulationRunner
{
    private readonly SimulationClock _clock;
    private readonly Action<double> _updateSimulation;

    public SimulationRunner(Action<double> updateSimulation)
    {
        ArgumentNullException.ThrowIfNull(updateSimulation);

        _clock = new SimulationClock();
        _updateSimulation = updateSimulation;
    }

    public long TotalTicks => _clock.TotalTicks;

    public double InterpolationAlpha =>
        _clock.AccumulatedTime / SimulationClock.TargetTickTime;

    /// <summary>
    /// Advances the clock and executes every scheduled simulation tick.
    /// </summary>
    public int Advance(double elapsedSeconds)
    {
        int ticksToRun = _clock.Advance(elapsedSeconds);

        for (int i = 0; i < ticksToRun; i++)
        {
            _updateSimulation(SimulationClock.TargetTickTime);
        }

        return ticksToRun;
    }

    /// <summary>
    /// Resets the simulation clock.
    /// </summary>
    public void Reset()
    {
        _clock.Reset();
    }
}
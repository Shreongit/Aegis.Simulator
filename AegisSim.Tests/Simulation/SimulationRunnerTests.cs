
using System;
using System.Collections.Generic;
using AegisSim.Core.Simulation;
using Xunit;

namespace AegisSim.Tests.Simulation;

public sealed class SimulationRunnerTests
{
    [Fact]
    public void Advance_ThreeTicks_ExecutesThreeUpdates()
    {
        int updateCount = 0;

        var runner = new SimulationRunner(_ => updateCount++);

        int ticks = runner.Advance(0.1);

        Assert.Equal(3, ticks);
        Assert.Equal(3, updateCount);
        Assert.Equal(3, runner.TotalTicks);
    }

    [Fact]
    public void Advance_PassesFixedTimestepToEveryUpdate()
    {
        var receivedTimes = new List<double>();

        var runner = new SimulationRunner(
            deltaTime => receivedTimes.Add(deltaTime));

        runner.Advance(0.1);

        Assert.Equal(3, receivedTimes.Count);

        foreach (double deltaTime in receivedTimes)
        {
            Assert.Equal(
                SimulationClock.TargetTickTime,
                deltaTime,
                precision: 12);
        }
    }

    [Fact]
    public void Advance_PartialTick_DoesNotUpdateSimulation()
    {
        int updateCount = 0;

        var runner = new SimulationRunner(_ => updateCount++);

        runner.Advance(SimulationClock.TargetTickTime / 2.0);

        Assert.Equal(0, updateCount);
        Assert.Equal(0, runner.TotalTicks);
    }

    [Fact]
    public void Advance_AccumulatesPartialTicks()
    {
        int updateCount = 0;

        var runner = new SimulationRunner(_ => updateCount++);

        double halfTick = SimulationClock.TargetTickTime / 2.0;

        runner.Advance(halfTick);
        runner.Advance(halfTick);

        Assert.Equal(1, updateCount);
        Assert.Equal(1, runner.TotalTicks);
    }

    [Fact]
    public void InterpolationAlpha_RemainsBetweenZeroAndOne()
    {
        var runner = new SimulationRunner(_ => { });

        runner.Advance(0.05);

        Assert.InRange(
            runner.InterpolationAlpha,
            0.0,
            1.0);
    }

    [Fact]
    public void Reset_ClearsClockState()
    {
        var runner = new SimulationRunner(_ => { });

        runner.Advance(0.1);
        runner.Reset();

        Assert.Equal(0, runner.TotalTicks);
        Assert.Equal(0.0, runner.InterpolationAlpha);
    }

    [Fact]
    public void Constructor_NullCallback_Throws()
    {
        Assert.Throws<ArgumentNullException>(
            () => new SimulationRunner(null!));
    }

    [Fact]
    public void Advance_InvalidElapsedTime_Throws()
    {
        var runner = new SimulationRunner(_ => { });

        Assert.Throws<ArgumentOutOfRangeException>(
            () => runner.Advance(-1.0));
    }
}


using System;
using AegisSim.Core.Simulation;
using Xunit;

namespace AegisSim.Tests.Simulation;

public sealed class SimulationClockTests
{
    [Fact]
    public void Advance_OneTickDuration_ReturnsOneTick()
    {
        var clock = new SimulationClock();

        int ticks = clock.Advance(
            SimulationClock.TargetTickTime);

        Assert.Equal(1, ticks);
        Assert.Equal(1, clock.TotalTicks);
    }

    [Fact]
    public void Advance_ThreeTickDurations_ReturnsThreeTicks()
    {
        var clock = new SimulationClock();

        int ticks = clock.Advance(0.1);

        Assert.Equal(3, ticks);
        Assert.Equal(3, clock.TotalTicks);
    }

    [Fact]
    public void Advance_HalfTick_DoesNotExecuteTick()
    {
        var clock = new SimulationClock();

        int ticks = clock.Advance(
            SimulationClock.TargetTickTime / 2.0);

        Assert.Equal(0, ticks);
        Assert.Equal(0, clock.TotalTicks);

        Assert.InRange(
            clock.AccumulatedTime,
            0.0,
            SimulationClock.TargetTickTime);
    }

    [Fact]
    public void Advance_TwoHalfTicks_ProducesOneTick()
    {
        var clock = new SimulationClock();

        double halfTick = SimulationClock.TargetTickTime / 2.0;

        clock.Advance(halfTick);
        int ticks = clock.Advance(halfTick);

        Assert.Equal(1, ticks);
        Assert.Equal(1, clock.TotalTicks);
    }

    [Fact]
    public void Advance_LongFrame_CapsElapsedTime()
    {
        var clock = new SimulationClock();

        int ticks = clock.Advance(1.0);

        Assert.Equal(7, ticks);
        Assert.Equal(7, clock.TotalTicks);
    }

    [Theory]
    [InlineData(-0.1)]
    [InlineData(double.NaN)]
    [InlineData(double.PositiveInfinity)]
    [InlineData(double.NegativeInfinity)]
    public void Advance_InvalidElapsedTime_Throws(
        double elapsedSeconds)
    {
        var clock = new SimulationClock();

        Assert.Throws<ArgumentOutOfRangeException>(
            () => clock.Advance(elapsedSeconds));
    }

    [Fact]
    public void Reset_ClearsTicksAndAccumulatedTime()
    {
        var clock = new SimulationClock();

        clock.Advance(0.1);
        clock.Reset();

        Assert.Equal(0, clock.TotalTicks);
        Assert.Equal(0.0, clock.AccumulatedTime);
    }
}

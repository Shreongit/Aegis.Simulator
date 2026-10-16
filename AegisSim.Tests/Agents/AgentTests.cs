
using System;
using AegisSim.Core.Agents;
using AegisSim.Core.Mathematics;
using Xunit;

namespace AegisSim.Tests.Agents;

public sealed class AgentTests
{
    [Fact]
    public void Constructor_InitializesAgentCorrectly()
    {
        var position = new Vector2(5.0, 10.0);

        var agent = new Agent(1, position);

        Assert.Equal(1, agent.Id);
        Assert.Equal(position, agent.Position);
        Assert.Equal(Vector2.Zero, agent.Velocity);
        Assert.Equal(position, agent.Destination);
        Assert.Equal(3.0, agent.MaxSpeed);
        Assert.Equal(0.4, agent.Radius);
        Assert.False(agent.HasDestination);
    }

    [Fact]
    public void SetDestination_UpdatesTarget()
    {
        var agent = new Agent(1, Vector2.Zero);
        var destination = new Vector2(10.0, 15.0);

        agent.SetDestination(destination);

        Assert.Equal(destination, agent.Destination);
        Assert.True(agent.HasDestination);
    }

    [Fact]
    public void Stop_ClearsDestinationAndVelocity()
    {
        var agent = new Agent(1, new Vector2(2.0, 3.0));

        agent.Velocity = new Vector2(1.0, 2.0);
        agent.SetDestination(new Vector2(10.0, 10.0));

        agent.Stop();

        Assert.Equal(Vector2.Zero, agent.Velocity);
        Assert.Equal(agent.Position, agent.Destination);
        Assert.False(agent.HasDestination);
    }

    [Fact]
    public void Constructor_NegativeId_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new Agent(-1, Vector2.Zero));
    }

    [Fact]
    public void Constructor_InvalidPosition_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new Agent(
                1,
                new Vector2(double.NaN, 0.0)));
    }

    [Fact]
    public void Constructor_InvalidSpeed_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new Agent(1, Vector2.Zero, maxSpeed: 0.0));

        Assert.Throws<ArgumentOutOfRangeException>(
            () => new Agent(1, Vector2.Zero, maxSpeed: double.NaN));
    }

    [Fact]
    public void Constructor_InvalidRadius_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new Agent(1, Vector2.Zero, radius: 0.0));

        Assert.Throws<ArgumentOutOfRangeException>(
            () => new Agent(1, Vector2.Zero, radius: -1.0));
    }

    [Fact]
    public void SetDestination_NonFiniteCoordinates_Throws()
    {
        var agent = new Agent(1, Vector2.Zero);

        Assert.Throws<ArgumentOutOfRangeException>(
            () => agent.SetDestination(
                new Vector2(0.0, double.PositiveInfinity)));
    }
}

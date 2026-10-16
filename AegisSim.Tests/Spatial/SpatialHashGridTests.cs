
using System;
using AegisSim.Core.Agents;
using AegisSim.Core.Mathematics;
using AegisSim.Core.Spatial;
using Xunit;

namespace AegisSim.Tests.Spatial;

public sealed class SpatialHashGridTests
{
    [Fact]
    public void Constructor_InvalidCellSize_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new SpatialHashGrid(0));

        Assert.Throws<ArgumentOutOfRangeException>(
            () => new SpatialHashGrid(-1));

        Assert.Throws<ArgumentOutOfRangeException>(
            () => new SpatialHashGrid(double.NaN));
    }

    [Fact]
    public void GetCell_PositiveCoordinates_ReturnsExpectedBucket()
    {
        var grid = new SpatialHashGrid(2.0);

        var cell = grid.GetCell(new Vector2(5.0, 7.0));

        Assert.Equal((2, 3), cell);
    }

    [Fact]
    public void GetCell_NegativeCoordinates_UsesFloor()
    {
        var grid = new SpatialHashGrid(2.0);

        var cell = grid.GetCell(new Vector2(-0.5, -2.1));

        Assert.Equal((-1, -2), cell);
    }

    [Fact]
    public void Rebuild_AssignsAgentsToBuckets()
    {
        var grid = new SpatialHashGrid(2.0);
        var manager = new AgentManager();

        manager.CreateAgent(new Vector2(1.0, 1.0));
        manager.CreateAgent(new Vector2(1.5, 1.5));
        manager.CreateAgent(new Vector2(5.0, 5.0));

        grid.Rebuild(manager.Agents);

        Assert.Equal(2, grid.BucketCount);
    }

    [Fact]
    public void Query_ReturnsAgentsFromRelevantBuckets()
    {
        var grid = new SpatialHashGrid(2.0);
        var manager = new AgentManager();

        Agent nearby = manager.CreateAgent(new Vector2(1.0, 1.0));
        manager.CreateAgent(new Vector2(10.0, 10.0));

        grid.Rebuild(manager.Agents);

        var candidates = grid.Query(new Vector2(1.0, 1.0), 1.0);

        Assert.Contains(nearby, candidates);
        Assert.Single(candidates);
    }

    [Fact]
    public void Query_RejectsNegativeRadius()
    {
        var grid = new SpatialHashGrid();

        Assert.Throws<ArgumentOutOfRangeException>(
            () => grid.Query(Vector2.Zero, -1.0));
    }

    [Fact]
    public void Query_RejectsNonFiniteCoordinates()
    {
        var grid = new SpatialHashGrid();

        Assert.Throws<ArgumentOutOfRangeException>(
            () => grid.Query(
                new Vector2(double.NaN, 0.0),
                1.0));
    }

    [Fact]
    public void Rebuild_ClearsPreviousBuckets()
    {
        var grid = new SpatialHashGrid(2.0);
        var manager = new AgentManager();

        manager.CreateAgent(new Vector2(1.0, 1.0));

        grid.Rebuild(manager.Agents);

        Assert.Equal(1, grid.BucketCount);

        grid.Rebuild(Array.Empty<Agent>());

        Assert.Equal(0, grid.BucketCount);
    }
}

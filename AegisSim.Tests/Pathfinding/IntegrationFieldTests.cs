
using System;
using AegisSim.Core.Pathfinding;
using Xunit;

namespace AegisSim.Tests.Pathfinding;

public sealed class IntegrationFieldTests
{
    [Fact]
    public void Constructor_CreatesExpectedDimensions()
    {
        var field = new IntegrationField(10, 8);

        Assert.Equal(10, field.Width);
        Assert.Equal(8, field.Height);
        Assert.Equal(80, field.CellCount);
    }

    [Fact]
    public void Constructor_InitializesAllCellsAsUnreachable()
    {
        var field = new IntegrationField(5, 5);

        Assert.True(float.IsPositiveInfinity(field.GetCost(0, 0)));
        Assert.False(field.IsReachable(0, 0));
    }

    [Fact]
    public void SetCost_StoresAccumulatedCost()
    {
        var field = new IntegrationField(5, 5);

        field.SetCost(2, 3, 12.5f);

        Assert.Equal(12.5f, field.GetCost(2, 3));
        Assert.True(field.IsReachable(2, 3));
    }

    [Fact]
    public void SetCost_AllowsPositiveInfinity()
    {
        var field = new IntegrationField(5, 5);

        field.SetCost(1, 1, float.PositiveInfinity);

        Assert.False(field.IsReachable(1, 1));
    }

    [Fact]
    public void Reset_MakesAllCellsUnreachable()
    {
        var field = new IntegrationField(5, 5);

        field.SetCost(0, 0, 0.0f);
        field.SetCost(2, 2, 5.0f);

        field.Reset();

        Assert.False(field.IsReachable(0, 0));
        Assert.False(field.IsReachable(2, 2));
    }

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 0)]
    [InlineData(-1, 5)]
    public void Constructor_InvalidDimensions_Throws(
        int width,
        int height)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new IntegrationField(width, height));
    }

    [Theory]
    [InlineData(-1.0f)]
    [InlineData(float.NaN)]
    [InlineData(float.NegativeInfinity)]
    public void SetCost_InvalidCost_Throws(float cost)
    {
        var field = new IntegrationField(5, 5);

        Assert.Throws<ArgumentOutOfRangeException>(
            () => field.SetCost(1, 1, cost));
    }

    [Fact]
    public void GetCost_OutOfBounds_Throws()
    {
        var field = new IntegrationField(5, 5);

        Assert.Throws<ArgumentOutOfRangeException>(
            () => field.GetCost(5, 0));
    }

    [Fact]
    public void GetIndex_MapsCoordinatesCorrectly()
    {
        var field = new IntegrationField(10, 8);

        Assert.Equal(0, field.GetIndex(0, 0));
        Assert.Equal(12, field.GetIndex(2, 1));
        Assert.Equal(79, field.GetIndex(9, 7));
    }
}

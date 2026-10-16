
using System;
using AegisSim.Core.Mathematics;
using AegisSim.Core.Pathfinding;
using Xunit;

namespace AegisSim.Tests.Pathfinding;

public sealed class FlowFieldTests
{
    [Fact]
    public void Constructor_CreatesFieldWithExpectedDimensions()
    {
        var field = new FlowField(10, 8);

        Assert.Equal(10, field.Width);
        Assert.Equal(8, field.Height);
        Assert.Equal(80, field.CellCount);
    }

    [Fact]
    public void SetDirection_NormalizesNonZeroDirection()
    {
        var field = new FlowField(10, 10);

        field.SetDirection(3, 4, new Vector2(3, 4));

        Vector2 direction = field.GetDirection(3, 4);

        Assert.Equal(0.6, direction.X, precision: 12);
        Assert.Equal(0.8, direction.Y, precision: 12);
        Assert.Equal(1.0, direction.Length, precision: 12);
    }

    [Fact]
    public void SetDirection_ZeroVector_RemainsZero()
    {
        var field = new FlowField(5, 5);

        field.SetDirection(2, 2, Vector2.Zero);

        Assert.Equal(Vector2.Zero, field.GetDirection(2, 2));
    }

    [Fact]
    public void Clear_ResetsAllDirections()
    {
        var field = new FlowField(5, 5);

        field.SetDirection(1, 1, new Vector2(1, 0));
        field.SetDirection(3, 3, new Vector2(0, 1));

        field.Clear();

        Assert.Equal(Vector2.Zero, field.GetDirection(1, 1));
        Assert.Equal(Vector2.Zero, field.GetDirection(3, 3));
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
            () => new FlowField(width, height));
    }

    [Fact]
    public void GetDirection_OutOfBounds_Throws()
    {
        var field = new FlowField(5, 5);

        Assert.Throws<ArgumentOutOfRangeException>(
            () => field.GetDirection(5, 0));
    }

    [Fact]
    public void SetDirection_NonFiniteComponent_Throws()
    {
        var field = new FlowField(5, 5);

        Assert.Throws<ArgumentOutOfRangeException>(
            () => field.SetDirection(
                1, 1,
                new Vector2(double.NaN, 0)));
    }

    [Fact]
    public void SetDirection_ExcessiveMagnitude_Throws()
    {
        var field = new FlowField(5, 5);

        Assert.Throws<ArgumentOutOfRangeException>(
            () => field.SetDirection(
                1, 1,
                new Vector2(double.MaxValue, double.MaxValue)));
    }
}

using AegisSim.Core.Pathfinding;
using AegisSim.Core.World;
using Xunit;

namespace AegisSim.Tests.Pathfinding;

public sealed class FlowFieldBuilderTests
{
    [Fact]
    public void Build_WithObstacle_KeepsBlockedCellsUnreachable()
    {
        // Arrange
        var world = new WorldMap(10, 10);
        world.AddObstacle(new Obstacle(4, 0, 2, 8));

        var builder = new FlowFieldBuilder(world);

        // Act
        var (integration, flow) = builder.Build(8, 5);

        // Assert
        Assert.True(integration.IsReachable(2, 5));
        Assert.False(integration.IsReachable(4, 5));
        Assert.False(integration.IsReachable(5, 5));

        Assert.True(flow.IsInside(2, 5));
    }

    [Fact]
    public void Build_WithBlockedDestination_ThrowsArgumentException()
    {
        // Arrange
        var world = new WorldMap(10, 10);
        world.AddObstacle(new Obstacle(4, 4, 2, 2));

        var builder = new FlowFieldBuilder(world);

        // Act and Assert
        Assert.Throws<ArgumentException>(
            () => builder.Build(4, 4));
    }

    
    [Fact]
    public void Build_NearObstacle_ProvidesDirectionTowardLowerCost()
    {
        // Arrange
        var world = new WorldMap(10, 10);
        world.AddObstacle(new Obstacle(4, 0, 1, 8));

        var builder = new FlowFieldBuilder(world);

        // Act
        var (integration, flow) = builder.Build(8, 5);

        // Assert
        const int x = 3;
        const int y = 5;

        var direction = flow.GetDirection(x, y);

        Assert.True(direction.LengthSquared > 0.0);
        Assert.True(
            integration.GetCost(x + (int)Math.Round(direction.X),
                y + (int)Math.Round(direction.Y))
            < integration.GetCost(x, y));

        Assert.True(
            world.IsWalkable(
                x + (int)Math.Round(direction.X),
                y + (int)Math.Round(direction.Y)));
    }


}
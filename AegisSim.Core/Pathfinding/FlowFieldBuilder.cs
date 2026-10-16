
using System;
using System.Collections.Generic;
using AegisSim.Core.Mathematics;
using AegisSim.Core.World;

namespace AegisSim.Core.Pathfinding;

/// <summary>
/// Builds integration and flow fields for grid-based navigation.
/// </summary>
public sealed class FlowFieldBuilder
{
    private static readonly (int X, int Y)[] Neighbors =
    {
        ( 0, -1),
        ( 1,  0),
        ( 0,  1),
        (-1,  0),
        ( 1, -1),
        ( 1,  1),
        (-1,  1),
        (-1, -1)
    };

    private readonly WorldMap _world;

    public FlowFieldBuilder(WorldMap world)
    {
        ArgumentNullException.ThrowIfNull(world);
        _world = world;
    }

    /// <summary>
    /// Builds navigation costs and directions for a destination cell.
    /// </summary>
    public (IntegrationField Integration, FlowField Flow) Build(
        int destinationX,
        int destinationY)
    {
        if (!_world.IsInside(destinationX, destinationY))
        {
            throw new ArgumentOutOfRangeException(
                nameof(destinationX),
                "Destination must be inside the world.");
        }

        if (!_world.IsWalkable(destinationX, destinationY))
        {
            throw new ArgumentException(
                "Destination must be walkable.",
                nameof(destinationX));
        }

        var integration = new IntegrationField(
            _world.Width,
            _world.Height);

        var flow = new FlowField(
            _world.Width,
            _world.Height);

        CalculateIntegration(integration, destinationX, destinationY);
        CalculateFlow(integration, flow);

        return (integration, flow);
    }

    private void CalculateIntegration(
        IntegrationField integration,
        int destinationX,
        int destinationY)
    {
        var queue = new PriorityQueue<(int X, int Y), float>();

        integration.SetCost(destinationX, destinationY, 0.0f);
        queue.Enqueue((destinationX, destinationY), 0.0f);

        while (queue.TryDequeue(out var current, out float queuedCost))
        {
            float currentCost = integration.GetCost(current.X, current.Y);

            if (queuedCost > currentCost)
            {
                continue;
            }

            foreach (var neighbor in Neighbors)
            {
                int nextX = current.X + neighbor.X;
                int nextY = current.Y + neighbor.Y;

                if (!_world.IsWalkable(nextX, nextY))
                {
                    continue;
                }

                bool diagonal = neighbor.X != 0 && neighbor.Y != 0;

                // Prevent diagonal movement through blocked corners.
                if (diagonal &&
                    (!_world.IsWalkable(current.X + neighbor.X, current.Y) ||
                     !_world.IsWalkable(current.X, current.Y + neighbor.Y)))
                {
                    continue;
                }

                WorldCell nextCell = _world.GetCell(nextX, nextY);

                float stepDistance = diagonal
                    ? 1.41421356f
                    : 1.0f;

                float newCost = currentCost +
                    stepDistance * nextCell.MovementCost;

                if (newCost >= integration.GetCost(nextX, nextY))
                {
                    continue;
                }

                integration.SetCost(nextX, nextY, newCost);
                queue.Enqueue((nextX, nextY), newCost);
            }
        }
    }

    private void CalculateFlow(
        IntegrationField integration,
        FlowField flow)
    {
        for (int y = 0; y < _world.Height; y++)
        {
            for (int x = 0; x < _world.Width; x++)
            {
                if (!_world.IsWalkable(x, y))
                {
                    continue;
                }

                float currentCost = integration.GetCost(x, y);

                if (!float.IsFinite(currentCost) || currentCost == 0.0f)
                {
                    continue;
                }

                float bestCost = currentCost;
                Vector2 bestDirection = Vector2.Zero;

                foreach (var neighbor in Neighbors)
                {
                    int nextX = x + neighbor.X;
                    int nextY = y + neighbor.Y;

                    if (!_world.IsWalkable(nextX, nextY))
                    {
                        continue;
                    }

                    bool diagonal = neighbor.X != 0 && neighbor.Y != 0;

                    if (diagonal &&
                        (!_world.IsWalkable(x + neighbor.X, y) ||
                         !_world.IsWalkable(x, y + neighbor.Y)))
                    {
                        continue;
                    }

                    float neighborCost = integration.GetCost(nextX, nextY);

                    if (neighborCost >= bestCost)
                    {
                        continue;
                    }

                    bestCost = neighborCost;

                    bestDirection = new Vector2(
                        neighbor.X,
                        neighbor.Y);
                }

                flow.SetDirection(x, y, bestDirection);
            }
        }
    }
}

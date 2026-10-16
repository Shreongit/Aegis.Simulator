using System;
using System.Collections.Generic;
using AegisSim.Core.Agents;
using AegisSim.Core.Mathematics;

namespace AegisSim.Core.Spatial;

/// <summary>
/// Performs exact distance filtering on spatial-grid candidates.
/// </summary>
public sealed class NeighborQuery
{
    private readonly SpatialHashGrid _spatialGrid;

    public NeighborQuery(SpatialHashGrid spatialGrid)
    {
        ArgumentNullException.ThrowIfNull(spatialGrid);

        _spatialGrid = spatialGrid;
    }

    /// <summary>
    /// Finds agents whose centers are within the specified radius.
    /// The query excludes the supplied agent, if any.
    /// </summary>
    public List<Agent> FindNeighbors(
        Vector2 position,
        double radius,
        Agent? excludeAgent = null)
    {
        if (!double.IsFinite(position.X) ||
            !double.IsFinite(position.Y))
        {
            throw new ArgumentOutOfRangeException(
                nameof(position),
                "Position coordinates must be finite.");
        }

        if (!double.IsFinite(radius) || radius < 0.0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(radius),
                "Radius must be finite and non-negative.");
        }

        var candidates = _spatialGrid.Query(position, radius);
        var neighbors = new List<Agent>();

        double radiusSquared = radius * radius;

        foreach (Agent candidate in candidates)
        {
            if (excludeAgent is not null &&
                candidate.Id == excludeAgent.Id)
            {
                continue;
            }

            double distanceSquared = Vector2.DistanceSquared(
                position,
                candidate.Position);

            if (distanceSquared <= radiusSquared)
            {
                neighbors.Add(candidate);
            }
        }

        return neighbors;
    }
}

using System;
using System.Collections.Generic;
using AegisSim.Core.Agents;
using AegisSim.Core.Mathematics;

namespace AegisSim.Core.Spatial;

/// <summary>
/// Spatial partitioning grid for efficient nearby-agent queries.
/// Rebuild the grid after agent positions change.
/// </summary>
public sealed class SpatialHashGrid
{
    private readonly Dictionary<(int X, int Y), List<Agent>> _buckets = new();

    public double CellSize { get; }

    public int BucketCount => _buckets.Count;

    public SpatialHashGrid(double cellSize = 2.0)
    {
        if (!double.IsFinite(cellSize) || cellSize <= 0.0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(cellSize),
                "Cell size must be finite and positive.");
        }

        CellSize = cellSize;
    }

    /// <summary>
    /// Clears existing buckets and inserts all supplied agents.
    /// </summary>
    public void Rebuild(IEnumerable<Agent> agents)
    {
        ArgumentNullException.ThrowIfNull(agents);

        _buckets.Clear();

        foreach (Agent agent in agents)
        {
            ArgumentNullException.ThrowIfNull(agent);

            var key = GetCell(agent.Position);

            if (!_buckets.TryGetValue(key, out List<Agent>? bucket))
            {
                bucket = new List<Agent>();
                _buckets.Add(key, bucket);
            }

            bucket.Add(agent);
        }
    }

    /// <summary>
    /// Returns agents in buckets overlapping the requested radius.
    /// Results are broad-phase candidates, not exact collision results.
    /// </summary>
    public List<Agent> Query(Vector2 position, double radius)
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

        var results = new List<Agent>();

        int minX = GetCellCoordinate(position.X - radius);
        int maxX = GetCellCoordinate(position.X + radius);
        int minY = GetCellCoordinate(position.Y - radius);
        int maxY = GetCellCoordinate(position.Y + radius);

        for (int y = minY; ; y++)
        {
            for (int x = minX; ; x++)
            {
                if (_buckets.TryGetValue((x, y), out List<Agent>? bucket))
                {
                    results.AddRange(bucket);
                }

                if (x == maxX)
                {
                    break;
                }
            }

            if (y == maxY)
            {
                break;
            }
        }

        return results;
    }

    /// <summary>
    /// Returns the bucket coordinate containing a world position.
    /// </summary>
    public (int X, int Y) GetCell(Vector2 position)
    {
        if (!double.IsFinite(position.X) ||
            !double.IsFinite(position.Y))
        {
            throw new ArgumentOutOfRangeException(
                nameof(position),
                "Position coordinates must be finite.");
        }

        return (
            GetCellCoordinate(position.X),
            GetCellCoordinate(position.Y));
    }

    private int GetCellCoordinate(double coordinate)
    {
        double result = Math.Floor(coordinate / CellSize);

        if (result < int.MinValue || result > int.MaxValue)
        {
            throw new ArgumentOutOfRangeException(
                nameof(coordinate),
                "Coordinate exceeds the supported spatial grid range.");
        }

        return (int)result;
    }
}

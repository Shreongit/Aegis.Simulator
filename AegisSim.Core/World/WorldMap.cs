
using System;
using System.Collections.Generic;

namespace AegisSim.Core.World;

/// <summary>
/// Represents the grid-based world used by Aegis-Sim.
/// </summary>
public sealed class WorldMap
{
    private readonly WorldCell[] _cells;

    public int Width { get; }

    public int Height { get; }

    public IReadOnlyList<WorldCell> Cells => _cells;

    public WorldMap(int width, int height)
    {
        if (width <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(width));
        }

        if (height <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(height));
        }

        Width = width;
        Height = height;

        _cells = new WorldCell[checked(width * height)];

        Array.Fill(_cells, new WorldCell(true, 1.0f));
    }

    /// <summary>
    /// Returns whether a coordinate is inside the world.
    /// </summary>
    public bool IsInside(int x, int y)
    {
        return x >= 0 &&
               y >= 0 &&
               x < Width &&
               y < Height;
    }

    /// <summary>
    /// Returns the flat array index for a valid coordinate.
    /// </summary>
    public int GetIndex(int x, int y)
    {
        EnsureInside(x, y);

        return y * Width + x;
    }

    /// <summary>
    /// Reads the cell at a coordinate.
    /// </summary>
    public WorldCell GetCell(int x, int y)
    {
        return _cells[GetIndex(x, y)];
    }

    /// <summary>
    /// Updates the cell at a coordinate.
    /// </summary>
    public void SetCell(int x, int y, WorldCell cell)
    {
        if (!float.IsFinite(cell.MovementCost) ||
            cell.MovementCost <= 0.0f)
        {
            throw new ArgumentOutOfRangeException(
                nameof(cell),
                "Movement cost must be finite and positive.");
        }

        _cells[GetIndex(x, y)] = cell;
    }

    /// <summary>
    /// Marks all cells covered by an obstacle as blocked.
    /// </summary>
    public void AddObstacle(Obstacle obstacle)
    {
        if (!obstacle.IsValid)
        {
            throw new ArgumentException(
                "Obstacle dimensions and position are invalid.",
                nameof(obstacle));
        }

        if (!IsInside(obstacle.X, obstacle.Y) ||
            (long)obstacle.X + obstacle.Width > Width ||
            (long)obstacle.Y + obstacle.Height > Height)
        {
            throw new ArgumentOutOfRangeException(
                nameof(obstacle),
                "Obstacle must fit entirely inside the world.");
        }

        for (int y = obstacle.Y; y < obstacle.Y + obstacle.Height; y++)
        {
            for (int x = obstacle.X; x < obstacle.X + obstacle.Width; x++)
            {
                SetCell(x, y, new WorldCell(false, 1.0f));
            }
        }
    }

    /// <summary>
    /// Checks whether an agent can traverse a coordinate.
    /// </summary>
    public bool IsWalkable(int x, int y)
    {
        return IsInside(x, y) && GetCell(x, y).IsWalkable;
    }

    private void EnsureInside(int x, int y)
    {
        if (!IsInside(x, y))
        {
            throw new ArgumentOutOfRangeException(
                nameof(x),
                $"Coordinate ({x}, {y}) is outside the world.");
        }
    }
}

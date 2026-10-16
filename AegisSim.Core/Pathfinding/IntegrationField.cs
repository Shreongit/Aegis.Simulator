
using System;

namespace AegisSim.Core.Pathfinding;

/// <summary>
/// Stores accumulated pathfinding costs for a grid.
/// </summary>
public sealed class IntegrationField
{
    private readonly float[] _costs;

    public int Width { get; }

    public int Height { get; }

    public int CellCount => _costs.Length;

    public IntegrationField(int width, int height)
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

        _costs = new float[checked(width * height)];

        Reset();
    }

    /// <summary>
    /// Resets every cell to an unreachable state.
    /// </summary>
    public void Reset()
    {
        Array.Fill(_costs, float.PositiveInfinity);
    }

    /// <summary>
    /// Returns the accumulated cost at a grid coordinate.
    /// </summary>
    public float GetCost(int x, int y)
    {
        return _costs[GetIndex(x, y)];
    }

    /// <summary>
    /// Sets the accumulated cost at a grid coordinate.
    /// Positive infinity represents an unreachable cell.
    /// </summary>
    public void SetCost(int x, int y, float cost)
    {
        if (float.IsNaN(cost) ||
            float.IsNegativeInfinity(cost) ||
            cost < 0.0f)
        {
            throw new ArgumentOutOfRangeException(
                nameof(cost),
                "Cost must be non-negative or positive infinity.");
        }

        _costs[GetIndex(x, y)] = cost;
    }

    /// <summary>
    /// Checks whether a coordinate is inside the field.
    /// </summary>
    public bool IsInside(int x, int y)
    {
        return x >= 0 &&
               y >= 0 &&
               x < Width &&
               y < Height;
    }

    /// <summary>
    /// Checks whether a cell has a finite accumulated cost.
    /// </summary>
    public bool IsReachable(int x, int y)
    {
        return float.IsFinite(GetCost(x, y));
    }

    /// <summary>
    /// Converts grid coordinates into a flat array index.
    /// </summary>
    public int GetIndex(int x, int y)
    {
        if (!IsInside(x, y))
        {
            throw new ArgumentOutOfRangeException(
                nameof(x),
                $"Coordinate ({x}, {y}) is outside the field.");
        }

        return y * Width + x;
    }
}

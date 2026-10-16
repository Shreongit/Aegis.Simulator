
using System;
using AegisSim.Core.Mathematics;

namespace AegisSim.Core.Pathfinding;

/// <summary>
/// Stores a movement direction for each cell in a grid.
/// </summary>
public sealed class FlowField
{
    private readonly Vector2[] _directions;

    public int Width { get; }

    public int Height { get; }

    public int CellCount => _directions.Length;

    public FlowField(int width, int height)
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

        _directions = new Vector2[checked(width * height)];
    }

    /// <summary>
    /// Returns the movement direction at a coordinate.
    /// A zero vector means no direction is assigned.
    /// </summary>
    public Vector2 GetDirection(int x, int y)
    {
        return _directions[GetIndex(x, y)];
    }

    /// <summary>
    /// Sets the movement direction at a coordinate.
    /// Non-zero directions are normalized automatically.
    /// </summary>
    public void SetDirection(int x, int y, Vector2 direction)
    {
        if (!double.IsFinite(direction.X) ||
            !double.IsFinite(direction.Y))
        {
            throw new ArgumentOutOfRangeException(
                nameof(direction),
                "Direction components must be finite.");
        }

        double lengthSquared = direction.LengthSquared;

        if (!double.IsFinite(lengthSquared))
        {
            throw new ArgumentOutOfRangeException(
                nameof(direction),
                "Direction magnitude is too large.");
        }

        _directions[GetIndex(x, y)] =
            lengthSquared > 0.0
                ? direction.Normalized
                : Vector2.Zero;
    }

    /// <summary>
    /// Clears every movement direction.
    /// </summary>
    public void Clear()
    {
        Array.Clear(_directions);
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

    private int GetIndex(int x, int y)
    {
        if (!IsInside(x, y))
        {
            throw new ArgumentOutOfRangeException(
                nameof(x),
                $"Coordinate ({x}, {y}) is outside the flow field.");
        }

        return y * Width + x;
    }
}

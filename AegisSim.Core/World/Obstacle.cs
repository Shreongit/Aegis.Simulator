namespace AegisSim.Core.World;

/// <summary>
/// Represents a rectangular obstacle in the simulation world.
/// Coordinates use the world grid, not terminal screen positions.
/// </summary>
public readonly record struct Obstacle(
    int X,
    int Y,
    int Width,
    int Height)
{
    /// <summary>
    /// Determines whether the obstacle has valid positive dimensions.
    /// </summary>
    public bool IsValid =>
        X >= 0 &&
        Y >= 0 &&
        Width > 0 &&
        Height > 0;

    /// <summary>
    /// Determines whether a grid coordinate lies inside this obstacle.
    /// </summary>
    public bool Contains(int x, int y)
    {
        return x >= X &&
               y >= Y &&
               x < X + Width &&
               y < Y + Height;
    }
}
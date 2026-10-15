namespace AegisSim.Core.World;

/// <summary>
/// Represents one traversable or blocked cell in the simulation world.
/// </summary>
public struct WorldCell
{
    /// <summary>
    /// Whether agents can move through this cell.
    /// </summary>
    public bool IsWalkable { get; set; }

    /// <summary>
    /// Additional cost for moving through this cell.
    /// Higher values make the cell less desirable for pathfinding.
    /// </summary>
    public float MovementCost { get; set; }

    public WorldCell(bool isWalkable = true, float movementCost = 1.0f)
    {
        IsWalkable = isWalkable;
        MovementCost = movementCost;
    }
}
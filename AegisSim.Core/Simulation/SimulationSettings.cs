namespace AegisSim.Core.Simulation;

/// <summary>
/// Holds configuration values for the Aegis-Sim simulation.
/// </summary>
public sealed class SimulationSettings
{
    /// <summary>
    /// Number of simulation updates per second.
    /// </summary>
    public double TickRate { get; init; } = 30.0;

    /// <summary>
    /// Maximum elapsed time accepted from a single frame.
    /// </summary>
    public double MaxFrameTime { get; init; } = 0.25;

    /// <summary>
    /// Number of agents created when the simulation starts.
    /// </summary>
    public int InitialAgentCount { get; init; } = 200;

    /// <summary>
    /// Width of the simulation world in cells.
    /// </summary>
    public int WorldWidth { get; init; } = 80;

    /// <summary>
    /// Height of the simulation world in cells.
    /// </summary>
    public int WorldHeight { get; init; } = 30;

    /// <summary>
    /// Creates a configuration with validated values.
    /// </summary>
    public void Validate()
    {
        if (!double.IsFinite(TickRate) || TickRate <= 0.0)
        {
            throw new System.ArgumentOutOfRangeException(
                nameof(TickRate),
                "Tick rate must be finite and positive.");
        }

        if (!double.IsFinite(MaxFrameTime) || MaxFrameTime <= 0.0)
        {
            throw new System.ArgumentOutOfRangeException(
                nameof(MaxFrameTime),
                "Maximum frame time must be finite and positive.");
        }

        if (InitialAgentCount < 0)
        {
            throw new System.ArgumentOutOfRangeException(
                nameof(InitialAgentCount),
                "Initial agent count cannot be negative.");
        }

        if (WorldWidth <= 0 || WorldHeight <= 0)
        {
            throw new System.ArgumentOutOfRangeException(
                nameof(WorldWidth),
                "World dimensions must be positive.");
        }
    }
}
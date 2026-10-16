
using System;
using AegisSim.Core.Mathematics;

namespace AegisSim.Core.Agents;

/// <summary>
/// Represents an individual moving unit in the simulation.
/// </summary>
public sealed class Agent
{
    public int Id { get; }

    public Vector2 Position { get; set; }

    public Vector2 Velocity { get; set; }

    public Vector2 Destination { get; set; }

    public double MaxSpeed { get; }

    public double Radius { get; }

    public bool HasDestination { get; set; }

    public Agent(
        int id,
        Vector2 position,
        double maxSpeed = 3.0,
        double radius = 0.4)
    {
        if (id < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(id));
        }

        if (!double.IsFinite(position.X) ||
            !double.IsFinite(position.Y))
        {
            throw new ArgumentOutOfRangeException(
                nameof(position),
                "Position coordinates must be finite.");
        }

        if (!double.IsFinite(maxSpeed) || maxSpeed <= 0.0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(maxSpeed),
                "Maximum speed must be finite and positive.");
        }

        if (!double.IsFinite(radius) || radius <= 0.0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(radius),
                "Radius must be finite and positive.");
        }

        Id = id;
        Position = position;
        Velocity = Vector2.Zero;
        Destination = position;
        MaxSpeed = maxSpeed;
        Radius = radius;
        HasDestination = false;
    }

    /// <summary>
    /// Sets a new destination for this agent.
    /// </summary>
    public void SetDestination(Vector2 destination)
    {
        if (!double.IsFinite(destination.X) ||
            !double.IsFinite(destination.Y))
        {
            throw new ArgumentOutOfRangeException(
                nameof(destination),
                "Destination coordinates must be finite.");
        }

        Destination = destination;
        HasDestination = true;
    }

    /// <summary>
    /// Stops the agent and clears its movement target.
    /// </summary>
    public void Stop()
    {
        Velocity = Vector2.Zero;
        Destination = Position;
        HasDestination = false;
    }
}

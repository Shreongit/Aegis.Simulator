using System;
using AegisSim.Core.Mathematics;
using AegisSim.Core.Pathfinding;

namespace AegisSim.Core.Agents;

/// <summary>
/// Updates agent movement during simulation ticks.
/// </summary>
public sealed class AgentSystem
{
private const double ArrivalThreshold = 0.05;

private readonly AgentManager _agentManager;
private FlowField? _flowField;

public AgentSystem(AgentManager agentManager)
{
    ArgumentNullException.ThrowIfNull(agentManager);
    _agentManager = agentManager;
}

/// <summary>
/// Sets the flow field used to steer agents toward a shared destination.
/// Pass null to disable flow-field navigation.
/// </summary>
public void SetFlowField(FlowField? flowField)
{
    _flowField = flowField;
}

/// <summary>
/// Updates every agent for one simulation timestep.
/// </summary>
public void Update(double deltaTime)
{
    if (!double.IsFinite(deltaTime) || deltaTime <= 0.0)
    {
        throw new ArgumentOutOfRangeException(
            nameof(deltaTime),
            "Delta time must be finite and positive.");
    }

    foreach (Agent agent in _agentManager.Agents)
    {
        UpdateAgent(agent, deltaTime);
    }
}

private void UpdateAgent(Agent agent, double deltaTime)
{
    if (!agent.HasDestination)
    {
        agent.Velocity = Vector2.Zero;
        return;
    }

    Vector2 offset = agent.Destination - agent.Position;
    double distanceSquared = offset.LengthSquared;

    if (distanceSquared <= ArrivalThreshold * ArrivalThreshold)
    {
        Arrive(agent);
        return;
    }

    Vector2 direction = offset.Normalized;

    if (_flowField is not null)
    {
        int cellX = (int)Math.Floor(agent.Position.X);
        int cellY = (int)Math.Floor(agent.Position.Y);

        if (_flowField.IsInside(cellX, cellY))
        {
            Vector2 flowDirection = _flowField.GetDirection(cellX, cellY);

            if (flowDirection.LengthSquared > 0.0)
            {
                direction = flowDirection;
            }
        }
    }

    double travelDistance = agent.MaxSpeed * deltaTime;

    // Never step farther than the remaining distance to the destination.
    if (travelDistance >= Math.Sqrt(distanceSquared))
    {
        agent.Position = agent.Destination;
        Arrive(agent);
        return;
    }

    agent.Velocity = direction * agent.MaxSpeed;
    agent.Position += agent.Velocity * deltaTime;

    // Flow-field steering can carry an agent past its destination.
    // Check the new position as well as the starting position.
    Vector2 remaining = agent.Destination - agent.Position;

    if (remaining.LengthSquared <= ArrivalThreshold * ArrivalThreshold)
    {
        Arrive(agent);
    }
}

private static void Arrive(Agent agent)
{
    agent.Position = agent.Destination;
    agent.Velocity = Vector2.Zero;
    agent.HasDestination = false;
}

}
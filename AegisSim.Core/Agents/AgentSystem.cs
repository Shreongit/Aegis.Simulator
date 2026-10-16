using System;
using AegisSim.Core.Mathematics;

namespace AegisSim.Core.Agents;

/// <summary>
/// Updates agent movement during simulation ticks.
/// </summary>
public sealed class AgentSystem
{
    private const double ArrivalThreshold = 0.05;

    private readonly AgentManager _agentManager;

    public AgentSystem(AgentManager agentManager)
    {
        ArgumentNullException.ThrowIfNull(agentManager);

        _agentManager = agentManager;
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

    private static void UpdateAgent(Agent agent, double deltaTime)
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
            agent.Position = agent.Destination;
            agent.Velocity = Vector2.Zero;
            agent.HasDestination = false;
            return;
        }

        double distance = Math.Sqrt(distanceSquared);

        Vector2 direction = offset / distance;

        agent.Velocity = direction * agent.MaxSpeed;

        double travelDistance = agent.MaxSpeed * deltaTime;

        if (travelDistance >= distance)
        {
            agent.Position = agent.Destination;
            agent.Velocity = Vector2.Zero;
            agent.HasDestination = false;
            return;
        }

        agent.Position += agent.Velocity * deltaTime;
    }
}
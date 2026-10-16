using System;
using System.Collections.Generic;

namespace AegisSim.Core.Agents;

/// <summary>
/// Manages agent creation, lookup, and removal.
/// </summary>
public sealed class AgentManager
{
    private readonly List<Agent> _agents = new();
    private readonly Dictionary<int, Agent> _agentsById = new();

    private int _nextId;

    public int Count => _agents.Count;

    public IReadOnlyList<Agent> Agents => _agents.AsReadOnly();

    /// <summary>
    /// Creates and registers a new agent.
    /// </summary>
    public Agent CreateAgent(
        AegisSim.Core.Mathematics.Vector2 position,
        double maxSpeed = 3.0,
        double radius = 0.4)
    {
        if (_nextId == int.MaxValue)
        {
            throw new InvalidOperationException(
                "The agent ID space is exhausted.");
        }

        var agent = new Agent(
            _nextId++,
            position,
            maxSpeed,
            radius);

        _agents.Add(agent);
        _agentsById.Add(agent.Id, agent);

        return agent;
    }

    /// <summary>
    /// Finds an agent by its ID.
    /// </summary>
    public bool TryGetAgent(int id, out Agent? agent)
    {
        return _agentsById.TryGetValue(id, out agent);
    }

    /// <summary>
    /// Removes an agent by its ID.
    /// </summary>
    public bool RemoveAgent(int id)
    {
        if (!_agentsById.Remove(id, out Agent? agent))
        {
            return false;
        }

        _agents.Remove(agent);

        return true;
    }

    /// <summary>
    /// Removes every registered agent.
    /// IDs are not reused after clearing.
    /// </summary>
    public void Clear()
    {
        _agents.Clear();
        _agentsById.Clear();
    }
}
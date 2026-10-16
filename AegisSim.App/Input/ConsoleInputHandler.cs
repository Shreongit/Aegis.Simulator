using System;

namespace AegisSim.App.Input;

/// <summary>
/// Handles non-blocking keyboard input for the simulation.
/// </summary>
public sealed class ConsoleInputHandler
{
    public bool IsPaused { get; private set; }

    public bool IsQuitRequested { get; private set; }

    /// <summary>
    /// Processes pending keyboard input.
    /// Call this regularly from the main application loop.
    /// </summary>
    public void Update()
    {
        while (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(intercept: true);

            switch (key.Key)
            {
                case ConsoleKey.Spacebar:
                    IsPaused = !IsPaused;
                    break;

                case ConsoleKey.Escape:
                case ConsoleKey.Q:
                    IsQuitRequested = true;
                    break;
            }
        }
    }
}
using System;

namespace AegisSim.Core.Mathematics;

/// <summary>
/// Common mathematical operations used by the simulation engine.
/// </summary>
public static class MathUtils
{
    /// <summary>
    /// Restricts a value to an inclusive range.
    /// </summary>
    public static double Clamp(double value, double min, double max)
    {
        if (min > max)
        {
            throw new ArgumentException(
                "Minimum cannot exceed maximum.");
        }

        return Math.Clamp(value, min, max);
    }

    /// <summary>
    /// Linearly interpolates between two values.
    /// </summary>
    public static double Lerp(double start, double end, double amount)
    {
        return start + (end - start) * amount;
    }

    /// <summary>
    /// Calculates the squared distance between two points.
    /// </summary>
    public static double DistanceSquared(
        double x1,
        double y1,
        double x2,
        double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;

        return dx * dx + dy * dy;
    }

    /// <summary>
    /// Determines whether a value is approximately zero.
    /// </summary>
    public static bool ApproximatelyZero(
        double value,
        double epsilon = 1e-9)
    {
        if (!double.IsFinite(value) ||
            !double.IsFinite(epsilon) ||
            epsilon < 0.0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(value),
                "Value must be finite and epsilon must be finite and non-negative.");
        }

        return Math.Abs(value) <= epsilon;
    }

    /// <summary>
    /// Converts degrees to radians.
    /// </summary>
    public static double DegreesToRadians(double degrees)
    {
        return degrees * (Math.PI / 180.0);
    }

    /// <summary>
    /// Converts radians to degrees.
    /// </summary>
    public static double RadiansToDegrees(double radians)
    {
        return radians * (180.0 / Math.PI);
    }
}
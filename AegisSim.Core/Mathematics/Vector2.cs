using System;

namespace AegisSim.Core.Mathematics;

/// <summary>
/// Represents a two-dimensional vector using double-precision values.
/// </summary>
public readonly record struct Vector2(double X, double Y)
{
    public static Vector2 Zero => new(0.0, 0.0);

    public double LengthSquared => X * X + Y * Y;

    public double Length => Math.Sqrt(LengthSquared);

    public Vector2 Normalized
    {
        get
        {
            double length = Length;

            return length > 0.0
                ? this / length
                : Zero;
        }
    }

    public static Vector2 operator +(Vector2 a, Vector2 b) =>
        new(a.X + b.X, a.Y + b.Y);

    public static Vector2 operator -(Vector2 a, Vector2 b) =>
        new(a.X - b.X, a.Y - b.Y);

    public static Vector2 operator *(Vector2 vector, double scalar) =>
        new(vector.X * scalar, vector.Y * scalar);

    public static Vector2 operator *(double scalar, Vector2 vector) =>
        vector * scalar;

    public static Vector2 operator /(Vector2 vector, double scalar)
    {
        if (scalar == 0.0)
        {
            throw new DivideByZeroException(
                "A vector cannot be divided by zero.");
        }

        return new Vector2(
            vector.X / scalar,
            vector.Y / scalar);
    }

    public static double Dot(Vector2 a, Vector2 b) =>
        a.X * b.X + a.Y * b.Y;

    public static double DistanceSquared(Vector2 a, Vector2 b) =>
        (a - b).LengthSquared;

    public static double Distance(Vector2 a, Vector2 b) =>
        Math.Sqrt(DistanceSquared(a, b));
}
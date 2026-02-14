using FlaxEngine;

namespace Utilities;

public class MathTools
{
    public static float Magnitude(Vector3 vec3) //Unity-like vector3 magnitude
    {
        return float.Sqrt((vec3.X * vec3.X) + (vec3.Y * vec3.Y) + (vec3.Z * vec3.Z));
    }

    public static Vector3 ClampMagnitude(Vector3 vec3, float maxLength)//Unity-like clamp magnitude
    {
        Vector3 result;
        if (Magnitude(vec3) > maxLength * maxLength)
        {
            result = vec3.Normalized * maxLength;
        }
        else
        {
            result = vec3;
        }
        return result;
    }

    public Vector3 Normalized
    {
        get { return Vector3.Normalize(Normalized); }
    }
}

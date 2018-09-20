using UnityEngine;

public static class Vector3Extensions
{

    public static Vector2 ToVector2(this Vector3 vector)
    {
        return vector;
    }

    public static Vector3 SetX(this Vector3 vector, float x)
    {
        return new Vector3(x, vector.y, vector.z);
    }

    public static Vector3 SetY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, y, vector.z);
    }

    public static Vector3 SetZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, z);
    }

    public static Vector3 PlusX(this Vector3 vector, float plusX)
    {
        return new Vector3(vector.x + plusX, vector.y, vector.z);
    }

    public static Vector3 PlusY(this Vector3 vector, float plusY)
    {
        return new Vector3(vector.x, vector.y + plusY, vector.z);
    }

    public static Vector3 PlusZ(this Vector3 vector, float plusZ)
    {
        return new Vector3(vector.x, vector.y, vector.z + plusZ);
    }

    public static Vector3 TimesX(this Vector3 vector, float timesX)
    {
        return new Vector3(vector.x * timesX, vector.y, vector.z);
    }

    public static Vector3 TimesY(this Vector3 vector, float timesY)
    {
        return new Vector3(vector.x, vector.y * timesY, vector.z);
    }

    public static Vector3 TimesZ(this Vector3 vector, float timesZ)
    {
        return new Vector3(vector.x, vector.y, vector.z * timesZ);
    }

    public static Vector3 xyz(this Vector3 v, float x, float y, float z)
    {
        v.x = x; v.y = y; v.z = z;
        return v;
    }
    public static Vector3 xy(this Vector3 v, float x, float y)
    {
        v.x = x; v.y = y;
        return v;
    }
    /// <summary>
    /// Vector3 v = Vector3.zero;
    /// v.xz(5f,10f)
    /// </summary>
    /// <param name="v"></param>
    /// <param name="x"></param>
    /// <param name="z"></param>
    /// <returns></returns>
    public static Vector3 xz(this Vector3 v, float x, float z)
    {
        v.x = x; v.z = z;
        return v;
    }
}
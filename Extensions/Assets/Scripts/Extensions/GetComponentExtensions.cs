using UnityEngine;

public static class GetComponentExtensions
{
    public static T Get<T>(this GameObject gameObject) where T : Component
    {
        return gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
    }
}

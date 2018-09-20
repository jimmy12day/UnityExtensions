using UnityEngine;

public static class Rigidbody2DExtension
{
    /// <summary>
    /// Handling nulls during freeze
    /// </summary>
    /// <param name="rigidbody2D"></param>
    /// <returns></returns>
    public static bool Freeze(this Rigidbody2D rigidbody2D)
    {
        if (rigidbody2D == null)
            return false;

        rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.angularVelocity = 0;
        rigidbody2D.isKinematic = true;
        return true;
    }


    // Inside the Rigidbody2DExtension class
    /// <summary>
    /// Saving the state :Rigidbody2DState state rigidbody2D.GetState();
    /// </summary>
    /// <param name="rigidbody2D"></param>
    /// <returns></returns>
    public static Rigidbody2DState GetState(this Rigidbody2D rigidbody2D)
    {
        Rigidbody2DState state = new Rigidbody2DState();
        state.velocity = rigidbody2D.velocity;
        state.angularVelocity = rigidbody2D.angularVelocity;
        return state;
    }

    /// <summary>
    /// Adding references for getstate: state = rigidbody2D.GetState(state)
    /// </summary>
    /// <param name="rigidbody2D"></param>
    /// <param name="state"></param>
    /// <returns></returns>
    public static Rigidbody2DState GetState(this Rigidbody2D rigidbody2D, Rigidbody2DState state = null)
    {
        if (state == null)
            state = new Rigidbody2DState();

        state.velocity = rigidbody2D.velocity;
        state.angularVelocity = rigidbody2D.angularVelocity;
        return state;
    }
}


// The state of a Rigidbody2D
public class Rigidbody2DState
{
    public Vector2 velocity;
    public float angularVelocity;
}

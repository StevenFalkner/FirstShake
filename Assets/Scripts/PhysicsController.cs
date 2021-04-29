using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    public float ShakeForceMultiplier;
    public Rigidbody2D[] ShakingRigidbodies;

    public void ShakeRigidbodies(Vector3 deviceAcceleration)
    {
        foreach (var rigidBody in ShakingRigidbodies)
        {
            rigidBody.AddForce(deviceAcceleration * ShakeForceMultiplier, ForceMode2D.Impulse);
        }
    }
}

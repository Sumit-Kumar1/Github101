using UnityEngine;

public class collision : MonoBehaviour
{
    public movement MovementScript;
    public Rigidbody rb;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            print("we hit an obstacle");
            MovementScript.enabled = false;
            rb.constraints = RigidbodyConstraints.FreezePosition; // rb is rigid body and we access freeze position constraints using rigid body constraints
        }
    }
}

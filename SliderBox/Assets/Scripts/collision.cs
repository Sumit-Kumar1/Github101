using System.Net.Sockets;
using UnityEngine;

public class collision : MonoBehaviour
{
    public movement MovementScript;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            print("we hit an obstacle");
            MovementScript.enabled = false;
            //rb.constraints = RigidbodyConstraints.FreezePosition; // rb is rigid body and we access freeze position constraints using rigid body constraints
            FindObjectOfType<GameManager>().EndGame(); //ends game if collision detected
        }
    }

    //end game if the y position goes below -1 value.
    void FixedUpdate()
    {
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
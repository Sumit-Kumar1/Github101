using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	[SerializeField] Rigidbody rb;
	[SerializeField] float forceforward = 800f, forceSideway = 350f;
	
    void FixedUpdate()
	{
		rb.AddForce(0, 0, -forceforward * Time.deltaTime);
		if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
		{
			rb.AddForce(forceSideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
		{
			rb.AddForce(-forceSideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		
	}
}

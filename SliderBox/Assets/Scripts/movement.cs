using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	[SerializeField] Rigidbody rb;
	[SerializeField] float forceforward = 800f, forceSideway = 350f;
	public GameObject _pauseUI;
	public bool flag = false;
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
		if (Input.GetKey(KeyCode.Escape)){
			if (!flag)
			{
				Time.timeScale = 0;
				flag = true;
				_pauseUI.SetActive(true);
			}
			else
			{
				flag = false;
				_pauseUI.SetActive(false);
				Time.timeScale = 1;
			}
		}
	}
}

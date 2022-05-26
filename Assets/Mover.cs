using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Transform transform;
	public CharacterController controller;

	public float movementSpeed = 8.0f;
	void Update()
	{
	float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");

	Vector3 movement = (transform.right * x + transform.forward * z);

	controller.Move(movement * movementSpeed * Time.deltaTime);
	}

}

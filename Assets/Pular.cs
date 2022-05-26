using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pular : MonoBehaviour
{
    public CharacterController controller;
    private float verticalVelocity;
    private float gravity = 9.84f;
    private float jumpForce = 6.0f;


    void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if(Input.GetKey(KeyCode.Space))
			{
                verticalVelocity = jumpForce;
			}
        }
		else
		{
            verticalVelocity -= gravity * Time.deltaTime;
		}
        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveVector * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour {

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float push_power = 10.0f;

    private Vector3 Axis;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController Controller;

    void Start()
    {
        Controller = GetComponent<CharacterController>();

        Axis = gameObject.transform.position;

        //// let the gameObject fall down
        gameObject.transform.position = new Vector3(Axis.x, Axis.y, Axis.z);
    }

    void Update()
    {
        if (Controller.isGrounded)
        {
            // We are grounded, so recalculate
            // Move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);

            moveDirection.y = 0.0f;
            moveDirection.Normalize();

            moveDirection = moveDirection * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }

        }

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        Controller.Move(moveDirection * Time.deltaTime);
    }

    // Original Code Found Here: https://docs.unity3d.com/ScriptReference/CharacterController.Move.html

    void  OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        // Checks to see if there is no rigidbody
        if (body == null || body.isKinematic)
        {
            return;
        }

        // Ensures object is not pushed down when hit from above
        if (hit.moveDirection.y < -0.3)
        {
            return;
        }

        //Calculate the direction the charcter is hitting the object at on the X and Z axis, so it is not pushed up or down.
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        // Push the object by the speed of the character hitting the object times the push power variable.
        body.velocity = pushDir * push_power;

    }
    //Original Code Found Here: https://answers.unity.com/questions/17566/how-can-i-make-my-player-a-charactercontroller-pus.html
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    // Create a Speed property that can be changed in the editor.
    public float Speed = 10f;
    // Create a Jump Height Variable.
    public float JumpHeight = 20f;
    // Create a reference for the rigid body in the script.
    public Rigidbody2D Rigid;
    // Create a CharaChange Boolean
    private bool CharaChange = true;
    // Create a constant float variable "MaxSpeed"
    public const float MaxSpeed = 3;




    // Use this for initialization.
    void Start () {
        // Gives Rigid Context.
        Rigid = GetComponent<Rigidbody2D>();

	}

    // Update is called once per frame.
    void FixedUpdate () {
        // Creates the variable "Velocity".
        Vector2 Velocity = Rigid.velocity;
        // Assigns the variable "LayerM" to the chosen layer that that is relevant.
        int LayerGround = 1 << LayerMask.NameToLayer("Ground");
        // This creates a variable that creates a value that is the size of the collision box on the object the script is attached on with an extra 0.5 length.
        float RayLen = GetComponent<Collider2D>().bounds.extents.y+0.05f;
        // This determines if the object the script is attached to is touching an object on the relevant layer that is specified by the variable "LayerGround".
        bool IsGrounded = Physics2D.Raycast(transform.position, Vector2.down, RayLen, LayerGround);

        // This changes the state of the boolean "CharaChange" when the "E" key is pressed
        if (Input.GetButtonDown("Change"))
        {
            if (CharaChange == false)
            {
                CharaChange = true;
            }
            else
            {
                CharaChange = false;
            }
        }

        // Changes the character the player controls depending on the state of the boolean "CharaChange"
        if (CharaChange == true)
        {
            //Checks to see if the boolean is true
            if (IsGrounded == true)
            {
                //Check to see if the "Jump" axis buttons have been pressed returning true.
                if (Input.GetButtonDown("Jump"))
                {
                    // This changes the velocity of the object by the value of the variable "JumpHeight" on the "y" axis.
                    Velocity.y += JumpHeight;
                }
            }

            // This changes the velocity of the object by the value of the variable "Speed" on the "x" axis.
            Velocity.x = Input.GetAxis("Horizontal") * Speed;
            // This ensures that the player does not move faster than the MAX_X_SPEED value
            Velocity.x = Mathf.Clamp(Velocity.x, -MaxSpeed, MaxSpeed);
            // Gives "Velocity" a value in conjunction to the abject the script is attached to.
            Rigid.velocity = Velocity;
        }
    }
}
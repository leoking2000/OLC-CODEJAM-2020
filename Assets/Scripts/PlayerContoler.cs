﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoler : MonoBehaviour
{

    public float moveSpeed = 30f;
    public float jumpForce = 15f;
    public float yVelLimit = 7f;
    public float fallMultiplier = 1.2f;
    public float lowJumpMultiplier = 1.2f;


    Rigidbody rb;

    float horizontalInput;
    float  jumpKeyPress;

    bool jumpBuffer = true;

    State state = State.Grounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        jumpKeyPress = Input.GetAxisRaw("Jump");
    }

    private void FixedUpdate()
    {
        // move
        rb.AddForce(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime, ForceMode.VelocityChange);

        if (jumpKeyPress > 0 && state == State.Grounded)
        {

            if (jumpBuffer)
            {
                Jump();
                jumpBuffer = false;
            }
        }
        else
        {
            jumpBuffer = true;
        }


        if (rb.velocity.y > yVelLimit)
        {
            rb.velocity = new Vector3(rb.velocity.x, yVelLimit, 0);
        }
        else if (rb.velocity.y > 0 && jumpKeyPress <= 0)
        {
            rb.AddForce(Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1), ForceMode.VelocityChange);
        }
        else if (rb.velocity.y < 0)
        {
            rb.AddForce(Vector3.up * Physics.gravity.y * (fallMultiplier - 1), ForceMode.VelocityChange);
        }


        // checkpoint
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(-111, -2.5f, 0);
        }

    }


    // private
    private void Jump()
    {
        rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.VelocityChange);
    }




    // Collition
    private void OnCollisionEnter(Collision collision)
    {
        state = State.Grounded;
    }

    private void OnCollisionStay(Collision collision)
    {
        state = State.Grounded;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(rb.velocity.y == 0)
        {
            state = State.Grounded;
        }
        state = State.Flying;
    }

    private enum State
    {
        Flying,
        Grounded
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoler : MonoBehaviour
{

    public float moveSpeed = 2;
    public float jumpForce = 10;


    Rigidbody rb;
    float horizontalInput;
    bool  jumpKeyPress;

    State state = State.Grounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        jumpKeyPress = Input.GetKey(KeyCode.UpArrow);

    }

    private void FixedUpdate()
    {
        //transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);

        rb.AddForce(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime, ForceMode.VelocityChange);

        if (jumpKeyPress && state == State.Grounded)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0),ForceMode.VelocityChange);
        }





        if (rb.velocity.y == 0)
        {
            state = State.Grounded;
        }
    }


    private void OnCollisionEnter(Collision collision)
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


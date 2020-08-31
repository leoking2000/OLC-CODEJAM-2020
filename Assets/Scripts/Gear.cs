using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{

    Rigidbody rb;

    public float Torque = 5f;

    public bool isRotating;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    private void FixedUpdate()
    {
        if (isRotating)
        {
            rb.AddTorque(new Vector3(0, 0, Torque), ForceMode.Impulse);
        }
        
    }
}

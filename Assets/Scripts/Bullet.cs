using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float InitialSpeed = 30f;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Start()
    {
        if (transform.rotation.y == 0)
        {
            rb.AddForce(Vector3.right * InitialSpeed, ForceMode.VelocityChange);
        }
        else
        {
            rb.AddForce(-Vector3.right * InitialSpeed, ForceMode.VelocityChange);
        }
    }

    private void Update()
    {
        if(transform.position.y < -100)
        {
            Destroy(this.gameObject);
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public Transform muzzle;
    public Bullet bullet;
    public float msfires = 200;

    float nextFireTime = 0;

    private void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Fire();
        }
    }

    public void Fire()
    {
        if (Time.time > nextFireTime)
        {
            nextFireTime = Time.time + msfires / 1000;
            Bullet b = Instantiate(bullet, muzzle.position, muzzle.rotation) as Bullet;
        }
    }

}

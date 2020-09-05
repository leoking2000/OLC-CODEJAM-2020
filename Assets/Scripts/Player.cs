using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform Start;


    private void Update()
    {
        if(transform.position.y < -10)
        {
            transform.position = Start.position;
            GetComponent<PlayerAudio>().PlayDie();
        }
    }



}

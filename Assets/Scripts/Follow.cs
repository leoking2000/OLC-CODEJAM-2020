using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform obj;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, transform.position.z);
        
    }
}

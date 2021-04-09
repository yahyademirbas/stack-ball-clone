using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float force = 150f;
    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        Debug.Log(rigidBody.velocity);
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddForce(0, -force, 0);
        }
    }
}

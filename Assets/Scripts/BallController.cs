using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float force = 150f;
    public bool flag = false;
    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            DestroyPentagons.instance.Flag();
            rigidBody.AddForce(0, -force, 0);
            
        }
    }
}

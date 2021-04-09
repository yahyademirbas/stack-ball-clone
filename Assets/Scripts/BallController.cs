using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float force = 20f;
    public bool flag = false;
    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            DestroyPentagons.instance.Space();
            rigidBody.AddForce(0, -force, 0);
            
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            DestroyPentagons.instance.DeSpace();
        }
    }
}

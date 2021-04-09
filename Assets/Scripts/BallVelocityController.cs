using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVelocityController : MonoBehaviour
{
    float maxVelocity = 5f;
    Rigidbody rigidBody;
   void Start()

    {
        rigidBody = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
       if (rigidBody.velocity.magnitude > maxVelocity)
            rigidBody.velocity = rigidBody.velocity.normalized * maxVelocity;

       if (rigidBody.velocity.y < 0 && rigidBody.velocity.magnitude< maxVelocity)
            rigidBody.velocity = rigidBody.velocity.normalized * maxVelocity;

    }
}

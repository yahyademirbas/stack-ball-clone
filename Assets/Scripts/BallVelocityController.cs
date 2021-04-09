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
        //float clampedY = Mathf.Clamp(velocity.y, minVelocity, maxVelocity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(rigidBody.velocity);
       if (rigidBody.velocity.magnitude > maxVelocity)
            rigidBody.velocity = rigidBody.velocity.normalized * maxVelocity;
       if (rigidBody.velocity.y < 0 && rigidBody.velocity.magnitude< maxVelocity)
            rigidBody.velocity = rigidBody.velocity.normalized * maxVelocity;

    }
}

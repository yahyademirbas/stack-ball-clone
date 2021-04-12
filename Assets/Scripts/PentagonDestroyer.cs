using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentagonDestroyer : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    bool col = false;
    bool trig = false;
    public void CollisionDetectedInChild(PentagonChild pentagonChild)
    {
        Debug.Log("collision in child detected");
        col = true;

    }
    public void TriggerDetectedInChild(TriggerCollider triggerCollider)
    {
        Debug.Log("trigger in child detected");
        trig = true;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && trig && col)
            Destroy(gameObject);
        trig = false;
        col = false;
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "Ball")
            DestroyPentagons.instance.isTriggered();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour
{

    void Start()
    {

    }

    void OnTriggerStay(Collider other)
    {
        transform.parent.GetComponent<PentagonDestroyer>().TriggerDetectedInChild(this);
    }


    void Update()
    {
        
    }
}

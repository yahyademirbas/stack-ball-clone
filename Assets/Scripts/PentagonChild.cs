using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentagonChild : MonoBehaviour
{
    PentagonDestroyer pentagonDestroyer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        transform.parent.GetComponent<PentagonDestroyer>().CollisionDetectedInChild(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

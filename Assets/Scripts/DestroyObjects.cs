using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrotObjects : MonoBehaviour
{
    // Start is called before the first frame update
    BoxCollider boxCollider;
    void Start()
    {
        boxCollider = GetComponentInChildren<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPos : MonoBehaviour
{
    // Start is called be
    // fore the first frame update
    public Transform target;
    public float speed = 0.7f;
    public bool takip=false;
 
 
    public static CamPos instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
 
    {
        
    }
  
 
    public void Takip() 
    { 
        takip = true; 
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) { this.transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime); }


    }
}

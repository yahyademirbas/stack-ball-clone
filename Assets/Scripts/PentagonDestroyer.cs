using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentagonDestroyer : MonoBehaviour
{
    
    public float speed = 0.1f;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        
       
        Ball = GameObject.Find("Ball");
      
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
        {
            CamPos.instance.Takip();
            Ball.GetComponent<Rigidbody>().AddForce(0, -1881f, 0);
            Destroy(gameObject);
            trig = false;
            col = false;
            

        }
       
    }

}

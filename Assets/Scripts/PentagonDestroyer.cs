using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void TriggerDetectedInChild(TriggerCollider triggerCollider)
    {
        //Debug.Log("trigger in child detected");
        trig = true;
    }
    public void CollisionDetectedInChild(PentagonChild pentagonChild)
    {
        if (Input.GetKey(KeyCode.Space) && trig == false)
        {
           // Debug.Log("Game Over");
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }
        if (Input.GetKey(KeyCode.Space) && trig)
        {
            CamPos.instance.Takip();
            Ball.GetComponent<Rigidbody>().AddForce(0, -1881f, 0);
            Score.instance.GainScore();
            Destroy(gameObject);
            trig = false;
            col = false;


        }

    }

}
  


    // Update is called once per frame

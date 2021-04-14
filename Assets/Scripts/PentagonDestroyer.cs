using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PentagonDestroyer : MonoBehaviour
{
    public GameObject Ball;
    public static PentagonDestroyer instance;
   
void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update

    void Start()
    {
        Ball = GameObject.Find("Ball");
    }
    bool trig = false;

    public void TriggerDetectedInChild(TriggerCollider triggerCollider)
    {
        //Debug.Log("trigger in child detected");
        trig = true;
    }


    // Update is called once per frame
    void Update()
    {
       
    }
    public void CollisionDetectedInChild(PentagonChild pentagonChild)
    {
        if (Input.GetKey(KeyCode.Space) && trig == false)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }

        if (Input.GetKey(KeyCode.Space) && trig)
        {
            Ball.GetComponent<Rigidbody>().AddForce(0, -1881f, 0);
            Score.instance.GainScore();
            Destroy(gameObject);
            trig = false;

        }
        
    }





}


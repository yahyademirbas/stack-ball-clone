using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPentagons : MonoBehaviour
{
    
    public static DestroyPentagons instance;
    bool space;
    int i= 1;
    bool isTrigger;
    GameObject toBeDestructed;
    //bool mcTrigger = false;
    public void Awake()
    {
        instance = this;
        toBeDestructed = GameObject.Find("Pentagon1 (" + i + ")");
    }
    public void Space()
    {
        //bug.Log("bastı");
        space = true;
    }
    public void DeSpace()
    {
       //Debug.Log("kalktı");
        space = false;
    }

    public void isTriggered()
    {
        isTrigger = true;
    }
    public void deTriggered()
    {
        isTrigger = false;
    }
    public void Incrementi() {
        i++;
    }

        

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball" && space == true && isTrigger == false) {
            
            
            Incrementi();
            Destroy(toBeDestructed);

            

        }
    }

}





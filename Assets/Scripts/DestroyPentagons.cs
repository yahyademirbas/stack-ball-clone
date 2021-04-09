using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPentagons : MonoBehaviour
{
    public static DestroyPentagons instance;
    bool space = false;
    BoxCollider boxCollider;
    MeshCollider meshCollider;
    bool isTrigger = false;
    //bool mcTrigger = false;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    { 

    }
    public void Space()
    {
        space = true;
    }
    public void DeSpace()
    {
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

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball") {
            if (space == true && isTrigger == false) //&& mcTrigger == true)
            {
                Destroy(gameObject);
                space = false;
                isTrigger = false;
            }

        }
    }


    void Update()
    {/*
        Debug.Log("is " + isTrigger);
        Debug.Log("mc " + mcTrigger);
        Debug.Log("space " + space);*/
      
    }}





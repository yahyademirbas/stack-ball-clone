using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPentagons : MonoBehaviour
{
    public static DestroyPentagons instance;
    bool flag = false;
    BoxCollider boxCollider;
    MeshCollider meshCollider;
    bool isTrigger = false;
    bool mcTrigger = false;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    { 

    }
    public void Flag()
    {
        flag = true;
    }


    public void isTriggered()
    {

        isTrigger = true;
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ball")
        mcTrigger = true;
    }


    void Update()
    {
        Debug.Log("is " + isTrigger);
        Debug.Log("mc " + mcTrigger);
        Debug.Log("flag " + flag);
        if (flag == true && isTrigger == false && mcTrigger == true) 
        {
            Destroy(gameObject);
            flag = false;
            isTrigger = false;
        }
    }}





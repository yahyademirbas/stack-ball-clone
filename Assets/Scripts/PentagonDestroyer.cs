using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentagonDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> pentagonList = new List<GameObject>();
   
    void Start()
    {
 
         foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag("pentagon")) {

            pentagonList.Add(fooObj);
         }
}


    // Update is called once per frame

    private void OnDestroy()
    {
        pentagonList.Remove(gameObject);
    }
    void Update()
    {
        /* for (int i = 0; i < length; i++)
         {
             Destroy(PentagonManager.instance.pentagonModel[i]);
         }*/
        

        
    }
}

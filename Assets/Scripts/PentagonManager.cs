using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentagonManager : MonoBehaviour
{

    public static PentagonManager instance;
    public GameObject[] pentagonModel;
    [HideInInspector]
    public GameObject[] pentagonPrefab = new GameObject[4];

    private GameObject temp1Pentagon;

    int pentagonNumber;
    public int pentagonQuantity = 29;
    // Start is called before the first frame update
    public void Awake()
    {
        instance = this;
    }
    public GameObject Pentagons;
    void Start()
    {

        for (pentagonNumber = 8; pentagonNumber < pentagonQuantity; pentagonQuantity--) 
        {

            temp1Pentagon = Instantiate(pentagonModel[Random.Range(0,3)]);
            temp1Pentagon.transform.SetParent(Pentagons.transform);
            temp1Pentagon.transform.position = new Vector3(0, pentagonQuantity-21, 0);
            temp1Pentagon.transform.eulerAngles = new Vector3(0, pentagonQuantity*8, 0);

        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher1say : MonoBehaviour
{
       
       public GameObject NPCSay;


    // Start is called before the first frame update
    void Start()
    {
        NPCSay.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        NPCSay.SetActive(true);
    }
    void OnTriggerExit()
    {
        NPCSay.SetActive(false);
    }
}

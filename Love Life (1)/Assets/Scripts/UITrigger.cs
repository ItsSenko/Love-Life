using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITrigger : MonoBehaviour
{

    public GameObject cs;

    void Start()
    {
        cs.SetActive(false);
    }
    void OnTriggerEnter()
    {
        cs.SetActive(true);
    }
    void OnTriggerExit()
    {
        cs.SetActive(false);
    }



}   

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    void OnTriggerStay()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene(5);
		}
	}
}   

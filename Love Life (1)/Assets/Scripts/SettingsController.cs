using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SettingsController : MonoBehaviour
{

    public GameObject Full;

    void Start()
    {
        EventSystem.current.SetSelectedGameObject(Full);
    }
    void Update()
    {
        if (Input.GetKeyDown("joystick button 1"))
        {
            SceneManager.LoadScene(0);
        }
    }

}

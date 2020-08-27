using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterDialog : MonoBehaviour
{
    public static bool isTalking = false;

    public GameObject NPCUI;

    public GameObject NPCButtons;

    public NPCAnswer IW;

    void Start()
    {
        NPCUI.SetActive(false);
    }



    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isTalking)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        else if (Input.GetKeyDown("joystick button 2"))
        {
            if (isTalking)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    void Resume()
    {
        NPCUI.SetActive(false);
        Time.timeScale = 1f;
        isTalking = false;
    }
    void Pause()
    {
        NPCUI.SetActive(true);
        Time.timeScale = 0f;
        isTalking = true;

        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set selected button
        EventSystem.current.SetSelectedGameObject(NPCButtons);
    }
}

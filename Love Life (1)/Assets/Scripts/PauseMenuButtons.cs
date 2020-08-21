using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    public void PressedMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void PressedQuit()
    {
        Application.Quit();
    }    
}

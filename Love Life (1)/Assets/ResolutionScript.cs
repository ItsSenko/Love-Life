using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionScript : MonoBehaviour
{

    public void Pressed1080()
    {
        Screen.SetResolution(1920, 1080, true);
        if (Screen.fullScreen = false)
        {
            Screen.fullScreen = true;
        }
        else
        {
            Screen.fullScreen = false;
        }
    }
    public void Pressed720()
    {
        Screen.SetResolution(1280, 720, true);
        if (Screen.fullScreen = false)
        {
            Screen.fullScreen = true;
        }
        else
        {
            Screen.fullScreen = false;
        }
    }
    public void Pressed480()
    {
        Screen.SetResolution(852, 480, true);
        if (Screen.fullScreen = false)
        {
            Screen.fullScreen = true;
        }
        else
        {
            Screen.fullScreen = false;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{

	public GameObject Resolutions;

	void Start()
    {
		Resolutions.SetActive(false);
    }
	
	public void PressedBack()
	{
		SceneManager.LoadScene(0);
	}
	public void PressedFull()
    {
			Screen.fullScreen = !Screen.fullScreen;
    }
	public void PressedRes()
    {
		Resolutions.SetActive(true);
    }
}
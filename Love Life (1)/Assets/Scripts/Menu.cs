using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	bool isMute;

	public void Mute()
	{
		isMute = !isMute;
   
	 AudioListener.volume = isMute ? 0 : 1;
	}

	public void PlayGame()
	{
		SceneManager.LoadScene(1);
	}
	public void QuitGame()
	{
		Application.Quit();
	}
	public void Settings()
	{
		SceneManager.LoadScene(2);
	}
}

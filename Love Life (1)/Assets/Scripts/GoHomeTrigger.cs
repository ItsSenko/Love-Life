using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHomeTrigger : MonoBehaviour
{
	void OnTriggerStay(Collider collider)
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			SceneManager.LoadScene(3);
		}
		if(Input.GetKeyDown("joystick button 0"))
        {
			SceneManager.LoadScene(3);
        }
	}
}

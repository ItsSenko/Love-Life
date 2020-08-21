using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    public Animator trans;

    public string sceneNameToLoad;

    public rumbletrigger rumbletrigger;

    void OnTriggerStay(Collider collider)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            trans.SetTrigger("end");
            rumbletrigger.RumbleStart();
            Invoke("LoadScene", 1f);
	    }
        if(Input.GetKey("joystick button 0"))
        {
            trans.SetTrigger("end");
            rumbletrigger.RumbleStart();
            Invoke("LoadScene", 1f);
        }
	}

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}

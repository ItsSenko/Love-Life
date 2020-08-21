using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitInGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && (Input.GetKey(KeyCode.M)))
        {
            SceneManager.LoadScene(0);
		} 
        if (Input.GetKey(KeyCode.LeftControl) && (Input.GetKey(KeyCode.H)))
        {
            SceneManager.LoadScene(3);  
		}
    }
}

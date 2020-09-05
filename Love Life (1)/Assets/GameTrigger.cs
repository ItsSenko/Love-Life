using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTrigger : MonoBehaviour
{

        public GameObject Game;

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        Game.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerExit()
    {
        
        Game.SetActive(false);
        
    }
    void Start()
    {
        Game.SetActive(false);
	}
    void OnTriggerStay()
    {
      if (Input.GetKeyDown(KeyCode.E))
      {
        SceneManager.LoadScene(8);
	  }
	}
}

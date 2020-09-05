using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskOne : MonoBehaviour
{

    public GameObject Task;

    // Start is called before the first frame update
    void Start()
    {
        Task.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        Task.SetActive(true);
    }
    void OnTriggerExit()
    {
        Task.SetActive(false);
	}
}

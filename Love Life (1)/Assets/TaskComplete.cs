using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskComplete : MonoBehaviour
{
    public GameObject Complete;
    public GameObject TaskDone;

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(Complete);
            Destroy(TaskDone);
		}
    }
}

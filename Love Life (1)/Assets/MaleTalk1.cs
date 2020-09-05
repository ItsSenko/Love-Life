using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleTalk1 : MonoBehaviour
{

    public GameObject BoyTalk;

    // Start is called before the first frame update
    void Start()
    {
        BoyTalk.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        BoyTalk.SetActive(true);
    }
    void OnTriggerExit()
    {
        BoyTalk.SetActive(false);
	}
}

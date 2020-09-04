using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buy : MonoBehaviour
{
    public GameObject ui;

    public moneyspend buyscript;

    public bool inRange;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ui.SetActive(true);
            inRange = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ui.SetActive(false);
            inRange = false;
        }
    }

    private void Update()
    {
        if(inRange == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                buyscript.Buy();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{

    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
      Cursor.visible = false;
    }
    void Update()
    {
        if (UI.activeInHierarchy)
        {
            Cursor.visible = true;
        }
        else
        {
            Cursor.visible = false;
        }
    }
}

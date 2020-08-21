using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{

    public GameObject Play;


    // Start is called before the first frame update
    void Start()
    {

        EventSystem.current.SetSelectedGameObject(Play);




    }
}

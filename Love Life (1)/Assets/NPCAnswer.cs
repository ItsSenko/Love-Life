using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NPCAnswer : MonoBehaviour
{
    public GameObject first;
    public GameObject Sickk;
    public GameObject Sleep;
    public GameObject Death;
    public GameObject WhySelectedTired;
    public GameObject WhySelectedSick;
    public GameObject Okay;
   


    void Start()
    {
        first.SetActive(false);
        Sickk.SetActive(false);
        Sleep.SetActive(false);
        Death.SetActive(false);
	}
    public void Sick()
    {
        first.SetActive(false);
        Sickk.SetActive(true);
        Sleep.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(WhySelectedSick);
	}
    public void Tired()
    {
        first.SetActive(false);
        Sickk.SetActive(false);
        Sleep.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(WhySelectedTired);
	}
    public void Why()
    {
        first.SetActive(false);
        Sickk.SetActive(false);
        Sleep.SetActive(false);
        Death.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(Okay);
	}
    public void Ok()
    {
        first.SetActive(false);
        Sickk.SetActive(false);
        Sleep.SetActive(false);
        Death.SetActive(false);
        Time.timeScale = 1f;
	}
}
